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
using System.Net.Mail;


public partial class Level3 : System.Web.UI.Page
{
    
    SqlDataAdapter sda;
    DataSet ds;
    String userid,mailid;
    SqlConnection con;
    SqlCommand cmd;
    string pageurl, password, id, ImageMapp;
    ConnectionString cs = new ConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {
        userid = Session["Uid"].ToString();
        mailid = Session["mail"].ToString();
        if (!Page.IsPostBack)
        {
            //con = new SqlConnection("Data Source=DEVARAJAN\\SQLEXPRESS;Initial Catalog=ImageProcess;Integrated Security=True");
            //con.Open();
            pageurl = Request.Url.AbsoluteUri;
            int k = pageurl.Length;
            pageurl = pageurl.Substring(48);
            id = (pageurl);
            //Label6.Text = id.ToString();

            try
            {
                //String fname = "x28.png";
                sda = new SqlDataAdapter("SELECT  uid, filename FROM   ImageTab where uid='" + userid + "' and filename ='" + pageurl + "'", cs.con);
                ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    password = CreateRandomPassword(8);
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("Smtp.gmail.com");
                    mail.From = new MailAddress("usha.cse07@gmail.com");
                    mail.To.Add(mailid);
                    mail.Subject = ("Security Code");
                    mail.Body = ("Your New Password:" + password);
                    //memorystream zipf = new memorystream();
                    mail.IsBodyHtml = true;
                    //System.Net.Mail.Attachment at=new Attachment(textBox6.Text.ToString(), MediaTypeNames.Application.Octet);
                    //mail.Attachments.Add(at);

                    //mail.Attachments.Add(new Attachment(textBox6.Text.ToString(), MediaTypeNames.Application.Octet));

                    SmtpServer.Timeout = 1000000;
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("usha.cse07@gmail.com", "ushapriyanka");// email address & password
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);

                    Response.Write("<Script>alert('Mail Had Send Successfully')</Script>");

                    sda = new SqlDataAdapter("select Userid password from EmailPassword where Userid='" + userid + "'", cs.con);
                    ds = new DataSet();
                    sda.Fill(ds);
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        cmd = new SqlCommand("update EmailPassword set password='" + password + "' where Userid='" + userid + "'  ", cs.con);
                        cmd.ExecuteNonQuery();
                        //Session["Uid"] = userid;
                        //Response.Redirect("Level3.aspx");
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into EmailPassword values('" + userid + "','" + password + "')", cs.con);
                        cmd.ExecuteNonQuery();
                        //Session["Uid"] = userid;
                        //Response.Redirect("Level3.aspx");
                    }
                }
                else
                {
                    Label5.Text = "WRONG USER HAS ENTERED....";
                    Response.Redirect("MainPage.aspx");
                }
            }
            catch (Exception ex)
            {

            }
        }
       
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
        sda = new SqlDataAdapter("select Userid,password from EmailPassword where password='" + TextBox2.Text + "'", cs.con);
        ds = new DataSet();
        sda.Fill(ds);
        if (ds.Tables[0].Rows.Count != 0)
        {
            Session["Uid"] = userid;
            Session["mail"] = mailid;
            Response.Redirect("ProcessMain.aspx");
        }
        else
        {
            Label5.Text = "Check Your Password";
        }
    }
}