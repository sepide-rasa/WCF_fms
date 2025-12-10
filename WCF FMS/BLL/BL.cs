using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL;

namespace WCF_FMS.BLL
{
    public class BL
    {
        public bool BLPermission(int AppId, int UserId, int OrganId)
        {
            return new DL().DLPermission(AppId, UserId, OrganId);
        }
        public string BLErrorMsg(string UserName, string Er, string IP, int? UserId)
        {
            return new DL().DLErrorMsg(UserName, Er, IP, UserId);
        }

        internal string BLErrorMsg(string UserName, string Er, int UserId)
        {
            throw new NotImplementedException();
        }
        public int checkCodeMeli(string codec)
        {
            char[] chArray = codec.ToCharArray();
            int[] numArray = new int[chArray.Length];
            string x = codec;
            switch (x)
            {
                case "0000000000":
                case "1111111111":
                case "2222222222":
                case "3333333333":
                case "4444444444":
                case "5555555555":
                case "6666666666":
                case "7777777777":
                case "8888888888":
                case "9999999999":
                case "0123456789":
                case "9876543210":

                    return 0;
                    break;
            }
            for (int i = 0; i < chArray.Length; i++)
            {
                numArray[i] = (int)char.GetNumericValue(chArray[i]);
            }
            int num2 = numArray[9];

            int num3 = ((((((((numArray[0] * 10) + (numArray[1] * 9)) + (numArray[2] * 8)) + (numArray[3] * 7)) + (numArray[4] * 6)) + (numArray[5] * 5)) + (numArray[6] * 4)) + (numArray[7] * 3)) + (numArray[8] * 2);
            int num4 = num3 - ((num3 / 11) * 11);
            if ((((num4 == 0) && (num2 == num4)) || ((num4 == 1) && (num2 == 1))) || ((num4 > 1) && (num2 == Math.Abs((int)(num4 - 11)))))
            {
                return 1;
            }
            else
            {
                return 0;

            }
        }
    }
}