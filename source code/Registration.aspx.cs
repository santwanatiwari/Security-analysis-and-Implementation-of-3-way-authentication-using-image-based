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
using AjaxControlToolkit;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
public partial class Registration : System.Web.UI.Page
{
    ConnectionString cs = new ConnectionString();
    String id;
    int i;
    protected void Page_Load(object sender, EventArgs e)
    {
        AutoId();
    }
    protected string UploadFolderPath = "~/Uploads/";   
    SqlCommand cmd;
    SqlDataAdapter sda;
    DataSet ds;
    protected void FileUploadComplete(object sender, EventArgs e)
    {
       
        //filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        //AsyncFileUpload1.SaveAs(Server.MapPath(this.UploadFolderPath) + filename);       
        SqlCommand sda = new SqlCommand("insert into ImageTab values('" + i.ToString() + "','" + filename + "')", cs.con);
        sda.ExecuteNonQuery();
    }
    
    String filename;
    public void AutoId()
    {
        SqlDataAdapter sda = new SqlDataAdapter("SELECT  * FROM  Reg", cs.con);
        DataSet ds = new DataSet();
        sda.Fill(ds);
        if (ds.Tables[0].Rows.Count != 0)
        {
            i = ds.Tables[0].Rows.Count + 1;
        }
        else
        {
            i = ds.Tables[0].Rows.Count + 1;
        }
        id = i.ToString();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        
        AutoId();
        sda = new SqlDataAdapter("SELECT  Uid, UserName FROM  Reg", cs.con);
        ds = new DataSet();
        sda.Fill(ds);
        if (ds.Tables[0].Rows.Count != 0)
        {
            for(int z=1;z<ds.Tables[0].Rows.Count;z++)
            {
                string us = ds.Tables[0].Rows[z][1].ToString();

                if (txtUserName.Text == us)
                {
                    lblMsg.Text = "USER NAME IS INVALID,CHANGE YOUR USER NAME";
                    return;
                }
            }
        }
        SqlCommand cmd = new SqlCommand("INSERT into Reg (Uid,FirstName,LastName,UserName,Password,Email,Address,Gender) values (@Uid,@FirstName,@LastName,@UserName,@Password,@Email,@Address,@Gender)",cs.con);
        SqlParameter uerid = new SqlParameter("@Uid", SqlDbType.VarChar, 50);
        uerid.Value = id;
        cmd.Parameters.Add(uerid);

        SqlParameter firstName = new SqlParameter("@FirstName", SqlDbType.VarChar, 50);
        firstName.Value = txtFirstName.Text.ToString();
        cmd.Parameters.Add(firstName);

        SqlParameter lastName = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
        lastName.Value = txtLastName.Text.ToString();
        cmd.Parameters.Add(lastName);

        SqlParameter userName = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
        userName.Value = txtUserName.Text.ToString();
        cmd.Parameters.Add(userName);

        SqlParameter pwd = new SqlParameter("@Password", SqlDbType.VarChar, 50);
        pwd.Value = txtPwd.Text.ToString();
        cmd.Parameters.Add(pwd);

        SqlParameter email = new SqlParameter("@Email", SqlDbType.VarChar, 50);
        email.Value = txtEmailID.Text.ToString();
        cmd.Parameters.Add(email);

        SqlParameter address = new SqlParameter("@Address", SqlDbType.VarChar, 50);
        address.Value = txtAdress.Text.ToString();
        cmd.Parameters.Add(address);

        SqlParameter gender = new SqlParameter("@Gender", SqlDbType.VarChar, 10);
        gender.Value = rdoGender.SelectedItem.ToString();
        cmd.Parameters.Add(gender);

        cmd.ExecuteNonQuery();
        try
            {
            FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
            Path = Server.MapPath("~/Uploads/" + FileUpload1.FileName);
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("Smtp.gmail.com");
            mail.From = new MailAddress("usha.cse07@gmail.com");
            mail.To.Add(txtEmailID.Text);
            mail.Subject = ("Security Code");
            mail.Body = ("Your Image Password:");
            //memorystream zipf = new memorystream();
            mail.IsBodyHtml = true;           
           // mail.Attachments.Add(new Attachment(Path));               
           
            System.Net.Mail.Attachment at=new Attachment(Path, MediaTypeNames.Application.Octet);
            mail.Attachments.Add(at);

            //mail.Attachments.Add(new Attachment(textBox6.Text.ToString(), MediaTypeNames.Application.Octet));

            SmtpServer.Timeout = 1000000;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("usha.cse07@gmail.com", "ushapriyanka");// email address & password
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

            Response.Write("<Script>alert('Mail Had Send Successfully')</Script>");            
            
            SqlCommand sda1 = new SqlCommand("insert into ImageTab values('" + i.ToString() + "','" + FileUpload1.FileName + "')", cs.con);
            sda1.ExecuteNonQuery();

            lblMsg.Text = "User Registration successful";
            Response.Redirect("MainPage.aspx");
            
        }
        catch (SqlException ex)
        {
            string errorMessage = "Error in registering user";
            errorMessage += ex.Message;
            throw new Exception(errorMessage);

        }
        finally
        {
            cs.close();
        }
    }
    
    protected void txtEmailID_TextChanged(object sender, EventArgs e)
    {
        //AsyncFileUpload1.Visible = true;
        //imgLoader.Visible = true;
    }
    String Path;
    protected void Button1_Click(object sender, EventArgs e)
    {
        FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
        Path = Server.MapPath("~/Uploads/" + FileUpload1.FileName);
        //SET IMAGE URL HERE
        Image1.ImageUrl = "~/Uploads/" + FileUpload1.FileName;
        Image1.Visible = true;
    }
}
