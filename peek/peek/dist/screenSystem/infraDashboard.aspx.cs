﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace peek.dist.css
{
    public partial class infraDashboard : System.Web.UI.Page
    {
        string linkserver = "Server=tcp:mateuzserver.database.windows.net,1433;Initial Catalog=MEU;Persist Security Info=False;User ID=mateuz;Password=Banco2k18;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        int numComp = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            #region Contar e visualizar os computadores
            using (SqlConnection conexao = new SqlConnection(linkserver))
            {
                conexao.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM PEEK_COMPUTADOR", conexao))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lblComp.Text = "" + numComp++;
                        }
                    }
                }
            }
            #endregion
        }
    }
}