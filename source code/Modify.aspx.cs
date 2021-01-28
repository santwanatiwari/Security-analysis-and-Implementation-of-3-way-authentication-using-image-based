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

public partial class Modify : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    DataTable dt =new DataTable();
    ConnectionString cs = new ConnectionString(); 
    protected void Page_Load(object sender, EventArgs e)
    {
                 
        //con = new SqlConnection("Data Source=DEVARAJAN\\SQLEXPRESS;Initial Catalog=ImageProcess;Integrated Security=True");
        //con.Open();
        if (!Page.IsPostBack)
        {
            string strQuery5 = "select * from Image2 where sno='" + RandomNumber(1, 4) + "'";
            SqlDataAdapter sda = new SqlDataAdapter(strQuery5, cs.con);
            sda.Fill(dt);

            try
            {

                dtlist.DataSource = dt;
                dtlist.DataBind();

                DataList3.DataSource = dt;
                DataList3.DataBind();
                DataList1.DataSource = dt;
                DataList1.DataBind();
                DataList2.DataSource = dt;
                DataList2.DataBind();
                DataList4.DataSource = dt;
                DataList4.DataBind();
                DataList5.DataSource = dt;
                DataList5.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
    static int RandomNumber(int min, int max)
    {
        Random random = new Random(); return random.Next(1, 4);
    }
  
    void Cac()
    {

        string strQuery5 = "select * from Image2 where sno='" + RandomNumber(1, 4) + "'";
        SqlDataAdapter sda = new SqlDataAdapter(strQuery5, cs.con);
        sda.Fill(dt);

        try
        {

            dtlist.DataSource = dt;
            dtlist.DataBind();

            DataList3.DataSource = dt;
            DataList3.DataBind();
            DataList1.DataSource = dt;
            DataList1.DataBind();
            DataList2.DataSource = dt;
            DataList2.DataBind();
            DataList4.DataSource = dt;
            DataList4.DataBind();
            DataList5.DataSource = dt;
            DataList5.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Cac();
        }
    }
    protected void DataList3_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Load")
        {
            //string keyID;

            //// Get the index of the row from which this event was raised. 
            //int idx = e.Item.ItemIndex;

            //// Get the DataKey with the same index. 
            //object thisKey = DataList3.DataKeys(idx);
            //if (thisKey != null)
            //{
            //    keyID = thisKey.ToString();
            //    // do something here 
            //} 
        }
    }
    protected void dtlist_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Load")
        {

        }
    }
    protected void DataList4_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Load")
        {

        }
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Load")
        {

        }
    }
    protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Load")
        {

        }
    }
    protected void DataList5_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Load")
        {

        }
    }
}
