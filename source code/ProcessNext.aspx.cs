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
using System.IO;
using System.Net;

public partial class ProcessNext : System.Web.UI.Page
{
    ConnectionString cs = new ConnectionString();
    SqlCommand cmd;
    SqlDataAdapter sda;
    DataSet ds;
    String userid, mailid, password;
    String filename;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        { 
            AutoId();
        }

            userid = Session["Uid"].ToString();
            mailid = Session["mail"].ToString();
        

        Label4.Text = mailid;
    }
    public void AutoId()
    {
        sda = new SqlDataAdapter("SELECT  FileTab.* FROM  FileTab", cs.con);
        ds = new DataSet();
        sda.Fill(ds);
        if (ds.Tables[0].Rows.Count != 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
               
                    ListBox1.Items.Add(ds.Tables[0].Rows[i][2].ToString());
               
            }
        }
        

    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        foreach (ListItem li in ListBox1.Items)
        {
            if (li.Selected==true)
            {
                Label2.Text = li.Text ;
            }
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        
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
        try
        {
            password = CreateRandomPassword(8);
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("Smtp.gmail.com");

            mail.From = new MailAddress("usha.cse07@gmail.com");
            mail.To.Add(Label4.Text);
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

            sda = new SqlDataAdapter("select FileMailId, UserId from FileMailTab where UserId='" + userid + "'", cs.con);
            ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                cmd = new SqlCommand("update FileMailTab set FileMailId='" + password + "' where UserId='" + userid + "'  ", cs.con);
                cmd.ExecuteNonQuery();
                Session["Uid"] = userid;
                //Response.Redirect("Level3.aspx");
            }
            else
            {
                cmd = new SqlCommand("insert into FileMailTab values('" + password + "','" + userid + "')", cs.con);
                cmd.ExecuteNonQuery();
                Session["Uid"] = userid;
                //Response.Redirect("Level3.aspx");
            }
        }
        catch (Exception ex)
        {

        }
    }    
    protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
    {
        sda = new SqlDataAdapter("SELECT  FileMailId, UserId FROM   FileMailTab where FileMailId='" + TextBox1.Text + "'", cs.con);
        ds = new DataSet();
        sda.Fill(ds);
        if (ds.Tables[0].Rows.Count != 0)
        {
            Session["Uid"] = userid;
            Session["mail"] = mailid;
            try
            {
                string strURL = Label2.Text;
                WebClient req = new WebClient();
                HttpResponse response = HttpContext.Current.Response;
                response.Clear();
                response.ClearContent();
                response.ClearHeaders();
                response.Buffer = true;
                response.AddHeader("Content-Disposition", "attachment;filename=" + Server.MapPath(strURL));
                //response.AddHeader("Content-Disposition", Server.MapPath(strURL));
                byte[] data = req.DownloadData(Server.MapPath(strURL));
                response.BinaryWrite(data);
                response.End();
            }
            catch (Exception ex)
            {
            }
            //Response.Redirect("ProcessMain.aspx");
        }
        else
        {
            Label4.Visible = true;
            Label4.Text = "Check Your Password";
        }
    }
}
