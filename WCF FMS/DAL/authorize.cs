using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL
{
    public class authorize
    {
        #region CheckUser
        public static int ExistUser(string Username, string Password)
        {
            using (RasaFMSCommonDBEntities t = new RasaFMSCommonDBEntities())
            {
                var user = t.spr_tblUserSelect("CheckPass", Username, Password, 1).FirstOrDefault();
                if (user != null)
                    return user.fldId;
                else
                    return 0;
            }
        }

        #endregion
        public static bool CheckActiveUser(string Username, string Password)
        {
            using (RasaFMSCommonDBEntities t = new RasaFMSCommonDBEntities())
            {
                var user = t.spr_tblUserSelect("CheckPass", Username, Password, 1).FirstOrDefault();
                if (user != null)
                {
                    if (user.fldActive_Deactive == false)
                        return false;
                    else
                        return true;
                }
                else
                    return false;
            }

        }
        #region GenerateHash
        public static string GenerateHash(string value)
        {
            SHA1 sha1 = SHA1.Create();
            //convert the input text to array of bytes
            if (value == null)
            {
                return "رمز عبور ضروری است.";
            }
            byte[] hashData = sha1.ComputeHash(Encoding.UTF8.GetBytes(value));

            //create new instance of StringBuilder to save hashed data
            StringBuilder returnValue = new StringBuilder();

            //loop for each byte and add it to StringBuilder
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString("X2"));
            }

            // return hexadecimal string
            return returnValue.ToString();
        }
        #endregion
    }
}