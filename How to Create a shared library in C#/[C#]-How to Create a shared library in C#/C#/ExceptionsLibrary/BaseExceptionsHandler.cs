﻿using System;
using System.Data.SqlClient;

namespace ExceptionsLibrary
{
    public class BaseExceptionsHandler
    {

        protected bool mHasException;
        /// <summary>
        /// Indicate the last operation thrown an 
        /// exception or not
        /// </summary>
        /// <returns></returns>
        public bool HasException
        {
            get
            {
                return mHasException;
            }
        }
        protected Exception mLastException;
        /// <summary>
        /// Provides access to the last exception thrown
        /// </summary>
        /// <returns></returns>
        public Exception LastException
        {
            get
            {
                return mLastException;
            }
        }

        /// <summary>
        /// Indicates if there was a sql related exception
        /// </summary>
        public bool HasSqlException
        {
            get
            {
                if (mLastException != null)
                {
                    Console.WriteLine(mLastException is SqlException);
                    return mLastException is SqlException;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// If you don't need the entire exception as in 
        /// LastException this provides just the text of the exception
        /// </summary>
        /// <returns></returns>
        public string LastExceptionMessage
        {
            get
            {
                return mLastException.Message;
            }
        }
        /// <summary>
        /// Indicate for return of a function if there was an 
        /// exception thrown or not.
        /// </summary>
        /// <returns></returns>
        public bool IsSuccessFul
        {
            get
            {
                return !mHasException;
            }
        }
    }
}
