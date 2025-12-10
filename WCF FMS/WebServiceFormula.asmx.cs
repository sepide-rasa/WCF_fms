using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCF_FMS
{
    /// <summary>
    /// Summary description for WebServiceFormula
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceFormula : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet GetData(string Code)
        {

            DataSet dt = new DataSet();


            dt.Tables.Add("tblData");
            string commandText = Code;
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["RasaNewFMSConnectionString"].ConnectionString;
            //SqlConnection con = new SqlConnection(@"Data Source=192.168.1.33,1433\sql2008;Initial Catalog=RaiTrainRatingDB;User ID=FormulatorUser;Password=R@3@system;MultipleActiveResultSets=True;Application Name=EntityFramework");
            SqlConnection con = new SqlConnection(connection);
            SqlCommand com = new SqlCommand(commandText, con);
            SqlDataAdapter adap = new SqlDataAdapter(com);
            com.CommandTimeout = 200000000;
            //////////////////////////////////////////
            //SqlConnection con = new SqlConnection(conectionString);
            //SqlCommand com = new SqlCommand(commandText, con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(com);
            ad.Fill(dt.Tables["tblData"]);
            var c = dt.Tables["tblData"].Rows.Count;
            con.Close();
            com = null;
            con = null;
            ad = null;
            return dt;

            //TrainTaghlilWebService.DataSet1 d = new DataSet1();
            //TrainTaghlilWebService.DataSet1TableAdapters.sp_SelectTaghlilTableAdapter taghlil = new TrainTaghlilWebService.DataSet1TableAdapters.sp_SelectTaghlilTableAdapter();
            //d.Tables.Add("tblTaghlilSorat");
            //taghlil.Fill(d.sp_SelectTaghlil);
            //return d;
        }
    }
}
