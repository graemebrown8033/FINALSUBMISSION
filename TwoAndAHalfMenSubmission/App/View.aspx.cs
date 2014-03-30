using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using speechRec;

public partial class Account_View : System.Web.UI.Page
{
    
    Class1 info = new Class1();

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnGo_Click(object sender, EventArgs e)
    {
        int num;
        num = Convert.ToInt32(buildDD.SelectedValue);
        info.Connect("127.0.0.1");
        info.printBuilding2(num);

        Label1.Text = "ID: " + info.myArr[0].ToString();
        Label2.Text = "Name: " + info.myArr[1].ToString();
        Label3.Text = "Start Location: " + info.myArr[3].ToString();
        Label4.Text = "Info 1: " + info.myArr[4].ToString();
        Label5.Text = "Info 2: " + info.myArr[5].ToString();
        Label6.Text = "Info 3: " + info.myArr[6].ToString();
        Label7.Text = "Info 4: " + info.myArr[7].ToString();
       


    }
}