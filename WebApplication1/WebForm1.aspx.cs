using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvertToForeign_Click(object sender, EventArgs e)
        {
            if (txtVND.Value == "" || double.Parse(txtVND.Value) <= 0)
            {
                lblerrorVND.Text = "Please input VND to exchange";
            } else
            {
                double vnd = double.Parse(txtVND.Value);
                string foreign = Select1.Value;
                WebApplication1.ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
                double result = client.VNDToForeignCurrencies(foreign, vnd);
                lblResult.Text = "" + result;
                lblerrorVND.Text = "";
            }
        }

        protected void btnConvertToVND_Click(object sender, EventArgs e)
        {
            if (txtMoney.Value == "" || double.Parse(txtVND.Value) <= 0)
            {
                lblErrorMoney.Text = "Please input money to exchange";
            } else
            {
                double money = double.Parse(txtMoney.Value);
                string foreign = Select2.Value;
                //localhost.WebService1 convert = new localhost.WebService1();
                WebApplication1.ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
                double result = client.ForeignCurrenciesToVND(foreign, money);
                lblReceive.Text = "" + result + "VND";
                lblErrorMoney.Text = "";
            }

        }
    }
}