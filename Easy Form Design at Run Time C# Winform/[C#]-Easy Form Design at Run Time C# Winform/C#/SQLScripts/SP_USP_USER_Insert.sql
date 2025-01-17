USE [DynamicProject]
GO
/****** Object:  StoredProcedure [dbo].[USP_Item_Insert]    Script Date: 04/16/2015 16:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Author      : Shanu                                                                  
-- Create date : 2015-02-05                                                                  
-- Description : To Insert Item Master                                                
-- Tables used :  ItemMasters                                                                 
-- Modifier    : Shanu                                                                  
-- Modify date : 2015-02-05                                                                  
-- =============================================                                                                  
-- exec USP_User_Insert '',''      
-- =============================================                                                             
Create PROCEDURE [dbo].[USP_User_Insert]                                                
   (        
     @USR_ID          VARCHAR(20)     = '',                              
     @User_Name       VARCHAR(100)     = '',  
     @Email           VARCHAR(100)     = '',  
     @Phone           VARCHAR(100)     = '',  
     @Address         VARCHAR(100)     = '' 
      )                                                          
AS                                                                  
BEGIN                  

   IF NOT EXISTS (SELECT * FROM UserMasters WHERE USR_ID=@USR_ID and User_Name=@User_Name)  
  BEGIN  
  
   INSERT INTO [UserMasters]     
      ([USR_ID],[User_Name],[Email],[Phone],[Address])  
   VALUES  
        (@USR_ID,@User_Name,@Email,@Phone,@Address)  
      select 'Inserted' as 'Result'
   END
   ELSE
   BEGIN
   select 'Error Insert' as 'Result'
   END
 
END  