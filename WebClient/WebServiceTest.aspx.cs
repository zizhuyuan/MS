using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class WebServiceTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            WebClient.WebServiceDemo.HelloServiceSoapClient hc = new WebServiceDemo.HelloServiceSoapClient();
            string result = hc.Hello(this.txt_Name.Text);
            Response.Write(result);
        }
    }
}