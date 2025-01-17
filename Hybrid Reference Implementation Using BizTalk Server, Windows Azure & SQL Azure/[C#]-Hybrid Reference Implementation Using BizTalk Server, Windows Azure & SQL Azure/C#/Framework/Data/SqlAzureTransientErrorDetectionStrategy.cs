﻿//==================================================================================
// Contoso Cloud Integration Service Layer Solution
//
// The Framework library is a set of common components shared across multiple
// projects in the Contoso Cloud Integration solution.
//
//==================================================================================
// Copyright © 2011 Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE. YOU BEAR THE RISK OF USING IT.
//=================================================================================
namespace Contoso.Cloud.Integration.Framework.Data
{
    #region Using references
    using System;
    using System.Data;
    using System.Data.SqlClient;
    #endregion

    /// <summary>
    /// Provides the transient error detection logic for transient faults that are specific to SQL Azure.
    /// </summary>
    public sealed class SqlAzureTransientErrorDetectionStrategy : ITransientErrorDetectionStrategy
    {
        #region ITransientErrorDetectionStrategy implementation
        /// <summary>
        /// Determines whether the specified exception represents a transient failure that can be compensated by a retry.
        /// </summary>
        /// <param name="ex">The exception object to be verified.</param>
        /// <returns>True if the specified exception is considered as transient, otherwise false.</returns>
        public bool IsTransient(Exception ex)
        {
            SqlException sqlException = null;
            EntityException entityException = null;

            if (ex != null)
            {
                if ((sqlException = ex as SqlException) != null)
                {
                    // Enumerate through all errors found in the exception.
                    foreach (SqlError err in sqlException.Errors)
                    {
                        switch (err.Number)
                        {
                            // SQL Error Code: 40501
                            // The service is currently busy. Retry the request after 10 seconds. Code: (reason code to be decoded).
                            case ThrottlingCondition.ThrottlingErrorNumber:
                                // Decode the reason code from the error message to determine the grounds for throttling.
                                var condition = ThrottlingCondition.FromError(err);

                                // Attach the decoded values as additional attributes to the original SQL exception.
                                sqlException.Data[condition.ThrottlingMode.GetType().Name] = condition.ThrottlingMode.ToString();
                                sqlException.Data[condition.GetType().Name] = condition;

                                return true;
                            // SQL Error Code: 40197
                            // The service has encountered an error processing your request. Please try again.
                            case 40197:
                            // SQL Error Code: 10053
                            // A transport-level error has occurred when receiving results from the server.
                            // An established connection was aborted by the software in your host machine.
                            case 10053:
                            // SQL Error Code: 10054
                            // A transport-level error has occurred when sending the request to the server. 
                            // (provider: TCP Provider, error: 0 - An existing connection was forcibly closed by the remote host.)
                            case 10054:
                            // SQL Error Code: 10060
                            // A network-related or instance-specific error occurred while establishing a connection to SQL Server. 
                            // The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server 
                            // is configured to allow remote connections. (provider: TCP Provider, error: 0 - A connection attempt failed 
                            // because the connected party did not properly respond after a period of time, or established connection failed 
                            // because connected host has failed to respond.)"}
                            case 10060:
                            // SQL Error Code: 40613
                            // Database XXXX on server YYYY is not currently available. Please retry the connection later. If the problem persists, contact customer 
                            // support, and provide them the session tracing ID of ZZZZZ.
                            case 40613:
                            // SQL Error Code: 40143
                            // The service has encountered an error processing your request. Please try again.
                            case 40143:
                            // SQL Error Code: 233
                            // The client was unable to establish a connection because of an error during connection initialization process before login. 
                            // Possible causes include the following: the client tried to connect to an unsupported version of SQL Server; the server was too busy 
                            // to accept new connections; or there was a resource limitation (insufficient memory or maximum allowed connections) on the server. 
                            // (provider: TCP Provider, error: 0 - An existing connection was forcibly closed by the remote host.)
                            case 233:
                            // SQL Error Code: 64
                            // A connection was successfully established with the server, but then an error occurred during the login process. 
                            // (provider: TCP Provider, error: 0 - The specified network name is no longer available.) 
                            case 64:
                            // DBNETLIB Error Code: 20
                            // The instance of SQL Server you attempted to connect to does not support encryption.
                            case (int)ProcessNetLibErrorCode.EncryptionNotSupported:
                                return true;
                        }
                    }
                }
                else if (ex is TimeoutException)
                {
                    return true;
                }
                else if ((entityException = ex as EntityException) != null)
                {
                    return IsTransient(entityException.InnerException);
                }
            }

            return false;
        }
        #endregion

        #region ProcessNetLibErrorCode enumeration
        /// <summary>
        /// Error codes reported by the DBNETLIB module.
        /// </summary>
        private enum ProcessNetLibErrorCode
        {
            ZeroBytes = -3,
            Timeout = -2,  /* Timeout expired. The timeout period elapsed prior to completion of the operation or the server is not responding. */
            Unknown = -1,
            InsufficientMemory = 1,
            AccessDenied = 2,
            ConnectionBusy = 3,
            ConnectionBroken = 4,
            ConnectionLimit = 5,
            ServerNotFound = 6,
            NetworkNotFound = 7,
            InsufficientResources = 8,
            NetworkBusy = 9,
            NetworkAccessDenied = 10,
            GeneralError = 11,
            IncorrectMode = 12,
            NameNotFound = 13,
            InvalidConnection = 14,
            ReadWriteError = 15,
            TooManyHandles = 16,
            ServerError = 17,
            SSLError = 18,
            EncryptionError = 19,
            EncryptionNotSupported = 20
        }
        #endregion
    }
}
