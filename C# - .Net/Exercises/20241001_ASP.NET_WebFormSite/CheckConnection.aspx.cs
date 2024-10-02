using System;
using _20241001_BusinessLayer;

public partial class CheckConnection : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCheckedConnection_Click(object sender, EventArgs e)
    {
        
        try
        {
            if (CheckConnectionUtility.CheckConnectionString(txtConnectionString.Text))
                lblResult.Text = "Connection OK!";
            else
                lblResult.Text = "No Connection!";
        }
        catch (ArgumentException ex)
        {
            lblResult.Text = "Ooops, That is an error: " + ex.Message;
        }
    }
}