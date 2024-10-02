using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class CheckConnection : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCheckConnection_Click(object sender, EventArgs e)
    {
        try
        {
            if (CheckConnectionUtility.CheckConnectionString(txtConnectionString.Text))
                lblRisultato.Text = "Connessione OK";
            else
                lblRisultato.Text = "Connessione KO";
        }
        catch (ArgumentException ex)
        {
            lblRisultato.Text = "Errore: " + ex.Message;
        }
    }
}