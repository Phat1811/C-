using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ConvertCurrentcy
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        private const double AUD = 15394.88;
        private const double EUR = 25400.81;
        private const double GBP = 29295.26;
        private const double HKD = 2911.78;
        private const double JPY = 203.3;
        private const double SGD = 16690.08;
        private const double THB = 747.79;
        private const double USD = 23110.00;

        [WebMethod]
        public double VNDToForeignCurrencies(string foreign, double vnd)
        {
            double receive = 0;
            if (foreign.Equals("AUST.DOLLAR"))
            {
                receive = vnd / AUD;
            } else if (foreign.Equals("EURO"))
            {
                receive = vnd / EUR;
            }
            else if (foreign.Equals("BRITISH POUND"))
            {
                receive = vnd / GBP;
            }
            else if (foreign.Equals("HONGKONG DOLLAR"))
            {
                receive = vnd / HKD;
            }
            else if (foreign.Equals("JAPANESE YEN"))
            {
                receive = vnd / JPY;
            }
            else if (foreign.Equals("SINGAPORE DOLLAR"))
            {
                receive = vnd / SGD;
            }
            else if (foreign.Equals("THAI BAHT"))
            {
                receive = vnd / THB;
            }
            else if (foreign.Equals("US DOLLAR"))
            {
                receive = vnd / USD;
            }
            return receive;
        }
        [WebMethod]
        public double ForeignCurrenciesToVND(string foreign, double money)
        {
            double exchange = 0;
            if (foreign.Equals("AUST.DOLLAR"))
            {
                exchange = money * AUD;
            }
            else if (foreign.Equals("EURO"))
            {
                exchange = money * EUR;
            }
            else if (foreign.Equals("BRITISH POUND"))
            {
                exchange = money * GBP;
            }
            else if (foreign.Equals("HONGKONG DOLLAR"))
            {
                exchange = money * HKD;
            }
            else if (foreign.Equals("JAPANESE YEN"))
            {
                exchange = money * JPY;
            }
            else if (foreign.Equals("SINGAPORE DOLLAR"))
            {
                exchange = money * SGD;
            }
            else if (foreign.Equals("THAI BAHT"))
            {
                exchange = money * THB;
            }
            else if (foreign.Equals("US DOLLAR"))
            {
                exchange = money * USD;
            }
            return exchange;
        }
        
    }
}
