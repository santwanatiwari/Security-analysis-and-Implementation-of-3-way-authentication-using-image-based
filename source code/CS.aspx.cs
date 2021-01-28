using System;
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
using System.Net.Mail;

public partial class _Default : System.Web.UI.Page 
{
    protected string UploadFolderPath = "~/Uploads/";
    ConnectionString cs = new ConnectionString();
    SqlCommand cmd;
    SqlDataAdapter sda;
    DataSet ds;
    protected void FileUploadComplete(object sender, EventArgs e)
    {
        filename  = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        AsyncFileUpload1.SaveAs(Server.MapPath(this.UploadFolderPath) + filename);
        SqlCommand sda = new SqlCommand("insert into ImageTab values('" + userid + "','" + filename + "')", cs.con);
        sda.ExecuteNonQuery();
    }
    String userid,mailid,password;
    String filename;
    protected void Page_Load(object sender, EventArgs e)
    {
        userid = Session["Uid"].ToString();
        mailid = Session["mail"].ToString();
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
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
         Session["Uid"] = userid;
         Session["mail"]=mailid;
        Response.Redirect("Test.aspx");
        
    }
}
