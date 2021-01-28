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
using System.IO;
public partial class ProcessMain : System.Web.UI.Page
{
    SqlDataAdapter sda;
    DataSet ds;
    SqlCommand sqm;
    String userid, mailid;
    ConnectionString conn = new ConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {
        AutoId();
        userid = Session["Uid"].ToString();
        mailid = Session["mail"].ToString();
    }
    int i;
    public void AutoId()
    {
        sda = new SqlDataAdapter("SELECT  FileTab.* FROM  FileTab", conn.con);
        ds = new DataSet();
        sda.Fill(ds);
        if (ds.Tables[0].Rows.Count != 0)
        {
            i = ds.Tables[0].Rows.Count + 1;
        }
        else
        {
            i = ds.Tables[0].Rows.Count + 1;
        }
        
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (TextBox1.Text == "")
        {

        }
        string filename = Path.GetFileName(FileUpload1.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/") + filename);
        string rr = "N";
        DateTime dt = DateTime.Now;     
        sqm = new SqlCommand("insert into FileTab values('" + i.ToString() + "','" + TextBox1.Text + "','" + filename + "')", conn.con);
        sqm.ExecuteNonQuery();        
        TextBox1.Text = "";
    }    
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Session["Uid"] = userid;
        Session["mail"] = mailid;
        Response.Redirect("ProcessNext.aspx");
    }
}
