using System;//
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using speechRec;

public partial class Account_Login : System.Web.UI.Page
{
    Class1 info = new Class1();


    protected void Page_Load(object sender, EventArgs e)
    {
        RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        int fname = Convert.ToInt32(txtUser.Text);
        String pass = txtPass.Text;
        checkLoginDetails(fname, pass);
    }

    public void checkLoginDetails(int fname, String pass)
    {
        info.Connect("127.0.0.1");
        info.getUsers(fname);
        checkPassword(pass);
    }

    public void checkPassword(String pass)
    {
        if (pass == info.userArr[4])
        {
            Response.Redirect("~/Admin.aspx");
        }
        else
        {
            Label2.Text = "Incorrect login ya muppet.";
        }



    }
}
