using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjetivaScripts.SQL
{
    internal class Query
    {
        public static void UpdateCadSys()
        {
            using (SqlConnection con = new SqlConnection(SqlConn.ConnString))
            {
                try
                {
                    con.Open();

                    string update =
                        "UPDATE CADSYS SET DTIMPLANTACAO ='01/01/2000'";

                    SqlCommand cmd = new SqlCommand(update, con)
                    {
                        CommandTimeout = 600
                    };

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Correções feitas com sucesso", "Deu bom paizão", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
