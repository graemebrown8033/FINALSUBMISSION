using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using speechRec;

public partial class Admin : System.Web.UI.Page
{

    Class1 info = new Class1();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        info.Connect("127.0.0.1");
        Response.Redirect("~/Add.aspx");
    }
}