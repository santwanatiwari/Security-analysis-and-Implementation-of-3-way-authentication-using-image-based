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
public partial class Process : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    String pageurl;
    ConnectionString ccs = new ConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        con = new SqlConnection("Data Source=DEVARAJAN\\SQLEXPRESS;Initial Catalog=ImageProcess;Integrated Security=True");
        con.Open();
        pageurl = Request.Url.AbsoluteUri;
        int k = pageurl.Length;
        pageurl = pageurl.Substring(67);
        Label1.Text = "Download File:" + pageurl;
    }
    protected void dtlist_ItemCommand(object source, DataListCommandEventArgs e)
    {
        foreach(DataList ds in dtlist.Items)
        {

            ImageButton img1 = (ImageButton)ds.FindControl("ImageButton1");

           String ss= img1.ImageUrl.ToString();

            

        }

    }
    void Cal()
    {
        string strQuery = "select * from Images where Sno='" + RandomNumber(1, 6) + "'";
        cmd = new SqlCommand(strQuery);
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        SqlDataReader dr = cmd.ExecuteReader();

        dtlist.DataSource = dr;
        dtlist.DataBind();

        dr.Close();
    }
    static int RandomNumber(int min, int max)
    {
        Random random = new Random(); return random.Next(1, 6);

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        Cal();
    }
    protected void dtlist_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
