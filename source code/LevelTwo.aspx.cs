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
using System.IO;
using System.Data.SqlClient;
using System.Net.Mail;
public partial class LevelTwo : System.Web.UI.Page
{
    ConnectionString cs = new ConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {
        //chooseImage();
        if (!Page.IsPostBack)
        {
            Label5.Text = Session["mail"].ToString();
            //bind();
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT  uid FROM   ImageGallery",cs.con);
            //DataSet ds = new DataSet();
            //sda.Fill(ds);
            //if (ds.Tables[0].Rows.Count != 0)
            //{
            //    for (int i = 0; i <ds.Tables[0].Rows.Count; i++)
            //    {
            //        ListBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            //    }
               
            //}
            //GridView1.DataSource = FetchAllImagesInfo();
            //GridView1.DataBind();
        }
    }
    public string chooseImage()
    {
        if (Session["img"] == null)
        {
            string imgPath;
            int fileCount = System.IO.Directory.GetFiles(Server.MapPath("/image"), "*.*", SearchOption.TopDirectoryOnly).Length;
            fileCount = fileCount + 1;
            imgPath = "media/img/" + RandomNumber(1, fileCount) + ".png";
            Session["img"] = imgPath;
            return imgPath;
        }
        else
            return Session["img"].ToString();
    }

    private int RandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
    public static string CreateRandomPassword(int PasswordLength)
    {
        string _allowedChars = "0123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ";
        Random randNum = new Random();
        char[] chars = new char[PasswordLength];
        int allowedCharCount = _allowedChars.Length;
        for (int i = 0; i < PasswordLength; i++)
        {
            chars[i] = _allowedChars[(int)((_allowedChars.Length) * randNum.NextDouble())];
        }
        return new string(chars);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label4.Text = "YOU HAVE WRONG WAY";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["ma"] = Label5.Text;
        Response.Redirect("Level3.aspx");
       
    }
    public void bind()
    {
        try
        {
            string sql = "Select pic from ImageGallery";
            SqlDataAdapter da = new SqlDataAdapter("Select * from ImageGallery ", cs.con);
            DataSet  dt = new DataSet();
            da.Fill(dt);
            //GridView1.DataSource = dt;
           // GridView1.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    public DataTable FetchAllImagesInfo()
    {
        string sql = "Select * from ImageGallery";
        SqlDataAdapter da = new SqlDataAdapter("Select * from ImageGallery ", cs.con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Label4.Text = "YOU HAVE WRONG WAY";
    }
}
