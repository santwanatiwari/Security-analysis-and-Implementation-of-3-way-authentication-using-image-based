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
using System.Windows.Forms;

public partial class _Default : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    ConnectionString cs = new ConnectionString();   
    SqlDataAdapter sda;
    DataSet ds;
    String userid, mailid, password;
    String fname;
    protected void Page_Load(object sender, EventArgs e)
    {
        //userid = Session["Uid"].ToString();
       // mailid = Session["mail"].ToString();
        DataTable dt = new DataTable();
        //con = new SqlConnection("Data Source=DEVARAJAN\\SQLEXPRESS;Initial Catalog=ImageProcess;Integrated Security=True");
        //con.Open();
        Cal();
    }




    void Cal()
    {
        string strQuery = "select * from ImageTab1 where Id='" + RandomNumber(1, 9) + "'";
        cmd = new SqlCommand(strQuery,cs.con);
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cs.con;

        SqlDataReader dr = cmd.ExecuteReader();

        dtlist.DataSource = dr;
        dtlist.DataBind();

        dr.Close();
    }


    static int RandomNumber(int min, int max)
    {
        Random random = new Random(); return random.Next(1, 9);

    }
    protected void dtlist_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
   
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        //Cal();
    }

    

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
    }
    protected void dtlist_ItemDataBound(object sender, DataListItemEventArgs e)
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
    protected void dtlist_ItemCommand(object source, DataListCommandEventArgs e)
    {

        for (int i = 0; i < dtlist.Items.Count; i++)
        {
            ImageButton lnkTrf = (ImageButton)dtlist.Items[0].FindControl("ImageButton1");
            lnkTrf.ImageUrl.ToString();
            cmd = new SqlCommand("SELECT * FROM  ImageTab Where ImagePath='" + lnkTrf.ImageUrl.ToString() + "'", cs.con);           
            SqlDataReader dr= cmd.ExecuteReader();
            while(dr.Read())
            {
                 fname=dr[1].ToString();
            }
                dr.Close();

                fname = "x28.png";


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
                Session["mail"] = mail;
                Response.Redirect("Level3.aspx");
            }
            else
            {
                cmd = new SqlCommand("insert into EmailPassword values('" + userid + "','" + password + "')", cs.con);
                cmd.ExecuteNonQuery();
                Session["Uid"] = userid;
                Session["mail"] = mail;
                Response.Redirect("Level3.aspx");
            }
        }
        else
        {

        }       
            
        }
        //String fname = "x28.png";
        
       
    }
    protected void dtlist_SelectedIndexChanged1(object sender, EventArgs e)
    {
        string Friendid = dtlist.DataKeys[dtlist.SelectedIndex].ToString();
        //You can simply get the selected Items values like this 
        DataListItem item = dtlist.SelectedItem;
        string name = ((LinkButton)item.FindControl("LinkButton1")).Text;

        MessageBox.Show(name);

        
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Cal();
    }
}
