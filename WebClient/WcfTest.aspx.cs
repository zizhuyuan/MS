using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.WcfServiceTest;

namespace WebClient
{
    public partial class WcfTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            UserClient user = new UserClient();
            string result = user.ShowName(this.txtName.Text);
            Response.Write(result);
        }
    }
}