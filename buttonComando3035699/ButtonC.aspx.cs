using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace buttonComando3035699
{
    public partial class ButtonC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Butto_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "View")
            {

                lblMessage.ForeColor = System.Drawing.Color.Green;
                switch (e.CommandArgument.ToString())
                {
                    case "Adidas":
                        lblMessage.Text = e.CommandArgument.ToString();
                        break;

                    case "Babolat":
                        lblMessage.Text = e.CommandArgument.ToString();
                        break;

                    case "Head":
                        lblMessage.Text = e.CommandArgument.ToString();
                        break;

                    case "Nike":
                        lblMessage.Text = e.CommandArgument.ToString();
                        break;

                    case "Prince":
                        lblMessage.Text = e.CommandArgument.ToString();
                        break;
                }

            }
            else { 
            lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Cancel";
            
            }
        }
    }
}