using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajouter_Chefeur
{
    public partial class Form1 : Form
    {
        static string conString = ConfigurationManager.ConnectionStrings["monConnection"].ConnectionString;
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(conString);
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || nom.Text == "" || prenom.Text == "" || adresse.Text == "" || salaire.Text == "") return;
            try
            {
                command = new SqlCommand("insert into chauffeur(ID_chauffeur,Nom,Prenom,Adresse,Salaire,Date_Recrutement) values(@id,@nom,@prenom,@adresse,@salaire,@dateRecrutement);", connection);
                command.Parameters.AddWithValue("@id", id.Text);
                command.Parameters.AddWithValue("@nom", nom.Text);
                command.Parameters.AddWithValue("@prenom", prenom.Text);
                command.Parameters.AddWithValue("@adresse", adresse.Text);
                command.Parameters.AddWithValue("@salaire", salaire.Text);
                command.Parameters.AddWithValue("@dateRecrutement", dateRecrutement.Value);

                connection.Open();
                int num = command.ExecuteNonQuery();
                if (num != 0)
                {
                    MessageBox.Show("l'ajout a ete effectue");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
