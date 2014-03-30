using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using speechRec;

public partial class Account_Add : System.Web.UI.Page
{

    Class1 info = new Class1();

    protected void Page_Load(object sender, EventArgs e)
    {
        info.Connect("127.0.0.1");
        int counter = info.getIdBuilding();

    }




    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int counter = info.getIdBuilding();
        int id = Convert.ToInt32(counter);
        string build = txtName.Text;
        int sensor = id;
        string locat = txtLocation.Text;
        string info1 = txt1.Text;
        string info2 = txt2.Text;
        string info3 = txt3.Text;
        string info4 = txt4.Text;

        info.AddBuilding(id, build, sensor, locat, info1, info2, info3, info4);
        Success.Visible = true;
        btnReset_Click(sender, e);
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtName.Text = "";
        txtLocation.Text = "";
        txt1.Text = "";
        txt2.Text = "";
        txt3.Text = "";
        txt4.Text = "";
    }
    protected void btnAdminMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin.aspx");
    }
}