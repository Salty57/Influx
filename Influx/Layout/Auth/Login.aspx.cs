using System;
using InfluxLibrary;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;

namespace Influx.Layout.Auth
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // hi
        }

        /// <summary>
        /// Login button on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean valideCredentials = false;
                DataBase db = new DataBase();

                string query = "SELECT uti_id from auth where auth_id = @username and auth_pwd = @password";
                using (SqlConnection connection = new SqlConnection(db.connection.ToString()))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlParameter usernameParam = new SqlParameter("username", SqlDbType.VarChar);
                    SqlParameter passwordParam = new SqlParameter("password", SqlDbType.VarChar);

                    usernameParam.Value = username_textbox.Text.Trim();
                    passwordParam.Value = password_textbox.Text.Trim();

                    command.Parameters.Add(usernameParam); // Ajout param username
                    command.Parameters.Add(passwordParam); // Ajout param password

                    SqlDataReader results = command.ExecuteReader();

                    if (results.FieldCount > 0)
                    {
                        valideCredentials = true;
                    }
                }

                if (valideCredentials)
                {
                    FormsAuthentication.RedirectFromLoginPage(username_textbox.Text, true);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Layout/Auth/Register.aspx");
        }
    }
}