using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Data;
using WCFUserService.DataContract;

namespace WCFUserService
{
    public class Manager
    {
        internal User GetUser(long id)
        {
            var user = new User();
            try
            {
                var myDatabase = DatabaseFactory.CreateDatabase("Passport");
                DbCommand myCommand = myDatabase.GetStoredProcCommand("spGetAccountByUsername");

                myDatabase.AddInParameter(myCommand, "@username", DbType.String, id);
                DataSet dataset = myDatabase.ExecuteDataSet(myCommand);

                var dr = dataset.Tables[0].Rows[0];

                user.Id = long.Parse(dr["Code"].ToString());
                user.Username = dr["Username"].ToString();
                user.Email = dr["Email"].ToString();
                user.Name=new Name();
                user.Name.FirstName = dr["FirstName"].ToString();
                user.Name.MiddleName = dr["LastName"].ToString();
                user.Name.MiddleName = dr["LastName"].ToString();
            }
            catch (Exception)
            {
                //supress;
            }
            return user;


        }
    }
}