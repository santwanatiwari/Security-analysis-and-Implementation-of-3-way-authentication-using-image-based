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
public partial class Test : System.Web.UI.Page
{
    ConnectionString cs = new ConnectionString();
    SqlCommand cmd;
    SqlDataAdapter sda;
    DataSet ds;
    String userid, mailid, password;
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
    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod]    
    public static AjaxControlToolkit.Slide[] GetSlides()
    {

        AjaxControlToolkit.Slide[] imgSlide = new AjaxControlToolkit.Slide[32];

        imgSlide[0] = new AjaxControlToolkit.Slide("image/x1.png", "x1.png", "² z  Z");
        imgSlide[1] = new AjaxControlToolkit.Slide("image/x2.png", "x2.png", "are you for real");
        imgSlide[2] = new AjaxControlToolkit.Slide("image/x3.png", "x3.png", "beaten");
        imgSlide[3] = new AjaxControlToolkit.Slide("image/x4.png", "x4.png", "bouaaaaah");
        imgSlide[4] = new AjaxControlToolkit.Slide("image/x5.png", "x5.png", "brzzzzz");
        imgSlide[5] = new AjaxControlToolkit.Slide("image/x6.png", "x6.png", "burnt");
        imgSlide[6] = new AjaxControlToolkit.Slide("image/x7.png", "x7.png", "confident");
        imgSlide[7] = new AjaxControlToolkit.Slide("image/x8.png", "x8.png", "dark mood");
        imgSlide[8] = new AjaxControlToolkit.Slide("image/x9.png", "x9.png", "disapointed");
        imgSlide[9] = new AjaxControlToolkit.Slide("image/x10.png", "x10.png", "eyes on fire");
        imgSlide[10] = new AjaxControlToolkit.Slide("image/x11.png", "x11.png", "faill");
        imgSlide[11] = new AjaxControlToolkit.Slide("image/x12.png", "x12.png", "gangs");
        imgSlide[12] = new AjaxControlToolkit.Slide("image/x13.png", "x13.png", "hidden");
        imgSlide[13] = new AjaxControlToolkit.Slide("image/x14.png", "x14.png", "high");
        imgSlide[14] = new AjaxControlToolkit.Slide("image/x15.png", "x15.png", "ignoring");
        imgSlide[15] = new AjaxControlToolkit.Slide("image/x16.png", "x16.png ", "indifferent");
        imgSlide[16] = new AjaxControlToolkit.Slide("image/x17.png", "x17.png", "innocent");
        imgSlide[17] = new AjaxControlToolkit.Slide("image/x18.png", "x18.png", "mah (chilling)");
        imgSlide[18] = new AjaxControlToolkit.Slide("image/x19.png", "x19.png", "nom nom");
        imgSlide[19] = new AjaxControlToolkit.Slide("image/x20.png", "x20.png", "nose bleed");
        imgSlide[20] = new AjaxControlToolkit.Slide("image/x21.png", "x21.png", "nose pick");
        imgSlide[21] = new AjaxControlToolkit.Slide("image/x22.png", "x22.png", "oh noes");
        imgSlide[22] = new AjaxControlToolkit.Slide("image/x23.png", "x23.png", "oh u !");
        imgSlide[23] = new AjaxControlToolkit.Slide("image/x24.png", "x24.png", "on fire");
        imgSlide[24] = new AjaxControlToolkit.Slide("image/x25.png", "x25.png", "psychotic");
        imgSlide[25] = new AjaxControlToolkit.Slide("image/x26.png", "x26.png", "relief");
        imgSlide[26] = new AjaxControlToolkit.Slide("image/x27.png", "x27.png", "scared");
        imgSlide[27] = new AjaxControlToolkit.Slide("image/x28.png", "x28.png", "secret laugh");
        imgSlide[28] = new AjaxControlToolkit.Slide("image/x29.png", "x29.png", "Ashocked");
        imgSlide[29] = new AjaxControlToolkit.Slide("image/x30.png", "x30.png", "shocked...again");
        imgSlide[30] = new AjaxControlToolkit.Slide("image/x31.png", "x31.png", "shout");
        imgSlide[31] = new AjaxControlToolkit.Slide("image/x32.png", "x32.png", "shy");

        String filename =imgSlide[30].Name;
        return (imgSlide);

    }
    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod]
    public static AjaxControlToolkit.Slide[] GetSlides1()
    {

        AjaxControlToolkit.Slide[] imgSlide = new AjaxControlToolkit.Slide[32];

        imgSlide[0] = new AjaxControlToolkit.Slide("image/x21.png", "x1.png", "² z  Z");
        imgSlide[1] = new AjaxControlToolkit.Slide("image/x22.png", "x2.png", "are you for real");
        imgSlide[2] = new AjaxControlToolkit.Slide("image/x23.png", "x3.png", "beaten");
        imgSlide[3] = new AjaxControlToolkit.Slide("image/x24.png", "x4.png", "bouaaaaah");
        imgSlide[4] = new AjaxControlToolkit.Slide("image/x25.png", "x5.png", "brzzzzz");
        imgSlide[5] = new AjaxControlToolkit.Slide("image/x26.png", "x6.png", "burnt");
        imgSlide[6] = new AjaxControlToolkit.Slide("image/x27.png", "x7.png", "confident");
        imgSlide[7] = new AjaxControlToolkit.Slide("image/x28.png", "x8.png", "dark mood");
        imgSlide[8] = new AjaxControlToolkit.Slide("image/x29.png", "x9.png", "disapointed");
        imgSlide[9] = new AjaxControlToolkit.Slide("image/x30.png", "x10.png", "eyes on fire");
        imgSlide[10] = new AjaxControlToolkit.Slide("image/x1.png", "x11.png", "faill");
        imgSlide[11] = new AjaxControlToolkit.Slide("image/x2.png", "x12.png", "gangs");
        imgSlide[12] = new AjaxControlToolkit.Slide("image/x3.png", "x13.png", "hidden");
        imgSlide[13] = new AjaxControlToolkit.Slide("image/x4.png", "x14.png", "high");
        imgSlide[14] = new AjaxControlToolkit.Slide("image/x5.png", "x15.png", "ignoring");
        imgSlide[15] = new AjaxControlToolkit.Slide("image/x6.png", "x16.png ", "indifferent");
        imgSlide[16] = new AjaxControlToolkit.Slide("image/x7.png", "x17.png", "innocent");
        imgSlide[17] = new AjaxControlToolkit.Slide("image/x8.png", "x18.png", "mah (chilling)");
        imgSlide[18] = new AjaxControlToolkit.Slide("image/x9.png", "x19.png", "nom nom");
        imgSlide[19] = new AjaxControlToolkit.Slide("image/x10.png", "x20.png", "nose bleed");
        imgSlide[20] = new AjaxControlToolkit.Slide("image/x11.png", "x21.png", "nose pick");
        imgSlide[21] = new AjaxControlToolkit.Slide("image/x12.png", "x22.png", "oh noes");
        imgSlide[22] = new AjaxControlToolkit.Slide("image/x13.png", "x23.png", "oh u !");
        imgSlide[23] = new AjaxControlToolkit.Slide("image/x14.png", "x24.png", "on fire");
        imgSlide[24] = new AjaxControlToolkit.Slide("image/x15.png", "x25.png", "psychotic");
        imgSlide[25] = new AjaxControlToolkit.Slide("image/x16.png", "x26.png", "relief");
        imgSlide[26] = new AjaxControlToolkit.Slide("image/x17.png", "x27.png", "scared");
        imgSlide[27] = new AjaxControlToolkit.Slide("image/x18.png", "x28.png", "secret laugh");
        imgSlide[28] = new AjaxControlToolkit.Slide("image/x19.png", "x29.png", "Ashocked");
        imgSlide[29] = new AjaxControlToolkit.Slide("image/x20.png", "x30.png", "shocked...again");
        imgSlide[30] = new AjaxControlToolkit.Slide("image/x31.png", "x31.png", "shout");
        imgSlide[31] = new AjaxControlToolkit.Slide("image/x32.png", "x32.png", "shy");
        String filename = imgSlide[30].Name;
        return (imgSlide);

    }
    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod]
    public static AjaxControlToolkit.Slide[] GetSlides2()
    {

        AjaxControlToolkit.Slide[] imgSlide = new AjaxControlToolkit.Slide[32];

        imgSlide[0] = new AjaxControlToolkit.Slide("image/x10.png", "x1.png", "² z  Z");
        imgSlide[1] = new AjaxControlToolkit.Slide("image/x11.png", "x2.png", "are you for real");
        imgSlide[2] = new AjaxControlToolkit.Slide("image/x12.png", "x3.png", "beaten");
        imgSlide[3] = new AjaxControlToolkit.Slide("image/x13.png", "x4.png", "bouaaaaah");
        imgSlide[4] = new AjaxControlToolkit.Slide("image/x14.png", "x5.png", "brzzzzz");
        imgSlide[5] = new AjaxControlToolkit.Slide("image/x15.png", "x6.png", "burnt");
        imgSlide[6] = new AjaxControlToolkit.Slide("image/x16.png", "x7.png", "confident");
        imgSlide[7] = new AjaxControlToolkit.Slide("image/x17.png", "x8.png", "dark mood");
        imgSlide[8] = new AjaxControlToolkit.Slide("image/x18.png", "x9.png", "disapointed");
        imgSlide[9] = new AjaxControlToolkit.Slide("image/x19.png", "x10.png", "eyes on fire");
        imgSlide[10] = new AjaxControlToolkit.Slide("image/x20.png", "x11.png", "faill");
        imgSlide[11] = new AjaxControlToolkit.Slide("image/x21.png", "x12.png", "gangs");
        imgSlide[12] = new AjaxControlToolkit.Slide("image/x22.png", "x13.png", "hidden");
        imgSlide[13] = new AjaxControlToolkit.Slide("image/x23.png", "x14.png", "high");
        imgSlide[14] = new AjaxControlToolkit.Slide("image/x24.png", "x15.png", "ignoring");
        imgSlide[15] = new AjaxControlToolkit.Slide("image/x25.png", "x16.png ", "indifferent");
        imgSlide[16] = new AjaxControlToolkit.Slide("image/x26.png", "x17.png", "innocent");
        imgSlide[17] = new AjaxControlToolkit.Slide("image/x27.png", "x18.png", "mah (chilling)");
        imgSlide[18] = new AjaxControlToolkit.Slide("image/x28.png", "x19.png", "nom nom");
        imgSlide[19] = new AjaxControlToolkit.Slide("image/x29.png", "x20.png", "nose bleed");
        imgSlide[20] = new AjaxControlToolkit.Slide("image/x30.png", "x21.png", "nose pick");
        imgSlide[21] = new AjaxControlToolkit.Slide("image/x31.png", "x22.png", "oh noes");
        imgSlide[22] = new AjaxControlToolkit.Slide("image/x32.png", "x23.png", "oh u !");
        imgSlide[23] = new AjaxControlToolkit.Slide("image/x1.png", "x24.png", "on fire");
        imgSlide[24] = new AjaxControlToolkit.Slide("image/x2.png", "x25.png", "psychotic");
        imgSlide[25] = new AjaxControlToolkit.Slide("image/x3.png", "x26.png", "relief");
        imgSlide[26] = new AjaxControlToolkit.Slide("image/x4.png", "x27.png", "scared");
        imgSlide[27] = new AjaxControlToolkit.Slide("image/x5.png", "x28.png", "secret laugh");
        imgSlide[28] = new AjaxControlToolkit.Slide("image/x6.png", "x29.png", "Ashocked");
        imgSlide[29] = new AjaxControlToolkit.Slide("image/x7.png", "x30.png", "shocked...again");
        imgSlide[30] = new AjaxControlToolkit.Slide("image/x8.png", "x31.png", "shout");
        imgSlide[31] = new AjaxControlToolkit.Slide("image/x9.png", "x32.png", "shy");

        String filename = imgSlide[30].Name;
        return (imgSlide);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        
    }
    protected void Image1_Click(object sender, ImageClickEventArgs e)
    {
        String fname = "x28.png";
        sda = new SqlDataAdapter("SELECT  uid, filename FROM   ImageTab where uid='" + userid + "' and filename ='" + fname + "'", cs.con);
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
                Session["Uid"] = userid;
                Response.Redirect("Level3.aspx");
            }
            else
            {
                cmd = new SqlCommand("insert into EmailPassword values('" + userid + "','" + password + "')", cs.con);
                cmd.ExecuteNonQuery();
                Session["Uid"] = userid;
                Response.Redirect("Level3.aspx");
            }
        }
        else
        {

        }

       
    }
    protected void Image2_Click(object sender, ImageClickEventArgs e)
    {
        String fname = "x28.png";
        sda = new SqlDataAdapter("SELECT  uid, filename FROM   ImageTab where uid='" + userid + "' and filename ='" + fname + "'", cs.con);
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
                Session["Uid"] = userid;
                Response.Redirect("Level3.aspx");
            }
            else
            {
                cmd = new SqlCommand("insert into EmailPassword values('" + userid + "','" + password + "')", cs.con);
                cmd.ExecuteNonQuery();
                Session["Uid"] = userid;
                Response.Redirect("Level3.aspx");
            }
        }
        else
        {

        }
    }
    protected void img1_Click(object sender, ImageClickEventArgs e)
    {
        String fname = "x28.png";
        sda = new SqlDataAdapter("SELECT  uid, filename FROM   ImageTab where uid='" + userid + "' and filename ='" + fname + "'", cs.con);
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
                Session["Uid"] = userid;
                Response.Redirect("Level3.aspx");
            }
            else
            {
                cmd = new SqlCommand("insert into EmailPassword values('" + userid + "','" + password + "')", cs.con);
                cmd.ExecuteNonQuery();
                Session["Uid"] = userid;
                Response.Redirect("Level3.aspx");
            }
        }
        else
        {

        }
    }
}
