using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class MainPage : System.Web.UI.Page
{
    ConnectionString css = new ConnectionString();
    SqlDataAdapter da;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
             da = new SqlDataAdapter("Select Uid,UserName,Password,Email from Reg where UserName='"+ TextBox1.Text +"' and Password='"+ TextBox2.Text +"'",css.con);
            DataSet ds=new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count!=0)
            {
                Session["Uid"] = ds.Tables[0].Rows[0][0].ToString();
                Session["mail"] = ds.Tables[0].Rows[0][3].ToString();
                Response.Redirect("Modify.aspx");
            }
            else
            {
                Label4.Visible=true;
                Label4.Text="User Enter Wrong";
            }
        }
        catch (Exception ex)
        {

        }
    }   
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Registration.aspx");
    }
}
