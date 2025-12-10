using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS
{
    /// <summary>
    /// این کلاس جهت نمایش و مدیریت خطاهای مربوط به برنامه مورد استفاده قرار می گیرد
    /// </summary>
    public class ClsError
    {
        /// <summary>
        ///حاوی متن خطا می باشد
        /// </summary>
        public string ErrorMsg = "";
        public string Msg = "";
        /// <summary>
        ///می شود true در صورت بروز خطا مقدار این فیلد  
        /// </summary>
        public bool ErrorType = false;

        public int OutputId { get; set; }//برای برخی توابعی که id به صورت output در insert دارن
        public int OutputId2 { get; set; }//برای برخی توابعی که id به صورت output در insert دارن

        public ClsError()
        {
            OutputId = 0;
            OutputId2 = 0;
        }
    }
}