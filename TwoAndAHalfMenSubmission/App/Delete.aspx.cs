using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using speechRec;

public partial class Account_Delete : System.Web.UI.Page
{
    Class1 info = new Class1();

    protected void Page_Load(object sender, EventArgs e)
    {
        info.Connect("127.0.0.1");
    }

    protected void btnGo_Click(object sender, EventArgs e)
    {

        int num;
        num = Convert.ToInt32(buildDD.SelectedValue);
        info.Connect("127.0.0.1");
        info.printBuilding2(num);

        try
        {
            TextBox1.Text = info.myArr[0].ToString();
            TextBox2.Text = info.myArr[1].ToString();
            TextBox8.Text = info.myArr[2].ToString();
            TextBox3.Text = info.myArr[3].ToString();
            TextBox4.Text = info.myArr[4].ToString();
            TextBox5.Text = info.myArr[5].ToString();
            TextBox6.Text = info.myArr[6].ToString();
            TextBox7.Text = info.myArr[7].ToString();

            //Buttons
            btnDelete.Visible = true;
            btnEdit.Visible = true;
            btnUpdate.Visible = false;

            //TextBoxes
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            TextBox5.Visible = true;
            TextBox6.Visible = true;
            TextBox7.Visible = true;
            TextBox8.Visible = true;
            //Labels
            ID.Visible = true;
            Location.Visible = true;
            Sensor.Visible = true;
            Name.Visible = true;
            Info1.Visible = true;
            Info2.Visible = true;
            Info3.Visible = true;
            Info4.Visible = true;
            noinfo.Visible = false;
        }
        catch (Exception)
        {
            noinfo.Visible = true;
           
        }

        

    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        txtBoxFalse();
        btnUpdate.Visible = true;
    }

    protected void txtBoxTrue()
    {
        TextBox1.ReadOnly = true;
        TextBox2.ReadOnly = true;
        TextBox3.ReadOnly = true;
        TextBox4.ReadOnly = true;
        TextBox5.ReadOnly = true;
        TextBox6.ReadOnly = true;
        TextBox7.ReadOnly = true;
        TextBox8.ReadOnly = true;
    }

    protected void txtBoxFalse()
    {
        TextBox1.ReadOnly = true;
        TextBox2.ReadOnly = false;
        TextBox3.ReadOnly = false;
        TextBox4.ReadOnly = false;
        TextBox5.ReadOnly = false;
        TextBox6.ReadOnly = false;
        TextBox7.ReadOnly = false;
        TextBox8.ReadOnly = true;
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        info.Connect("127.0.0.1");

        int id = Convert.ToInt32(TextBox1.Text);
        String build = TextBox2.Text;
        int sensor = Convert.ToInt32(TextBox8.Text);
        String locat = TextBox3.Text;
        String info1 = TextBox4.Text;
        String info2 = TextBox5.Text;
        String info3 = TextBox6.Text;
        String info4 = TextBox7.Text;

        info.editBuild(id, build, locat, info1, info2, info3, info4);

        txtBoxTrue();
        btnUpdate.Visible = false;

        success.Text = "Your changes have been saved.";

    }


    protected void btnDelete_Click(object sender, EventArgs e)
    {
        info.Connect("127.0.0.1");
        int num;
        num = Convert.ToInt32(buildDD.SelectedValue);

        buildDD.Items.Remove(buildDD.SelectedValue);

        info.deleteBuild(num);


        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";

    }
}