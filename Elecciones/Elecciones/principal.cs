using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Elecciones
{
    
    public partial class principal : Form
    {
        string gen = "";
        
        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Elecciones;Integrated Security=True");
        public principal()
        {
            InitializeComponent();

            var t = new ToolTip();
            t.SetToolTip(pictureBox2, "Realizar voto");
            var t2 = new ToolTip();
            t2.SetToolTip(pcbUsuario, "Cuenta");

           


        }

        public void Genero()
        {
           
            SqlCommand Ge = new SqlCommand("select Genero from Datos where curp= @curp", conexion);
            Ge.Parameters.AddWithValue("@curp","MOPA010531HNTNZLA7");
            conexion.Open();
            SqlDataReader sqlDataReader = Ge.ExecuteReader();
            
            if(sqlDataReader.Read())
            {
                gen = sqlDataReader["Genero"].ToString();
                if (gen == "Femenino")
                {
                    pcbUsuario.Image = Image.FromFile("C:/Users/aldoo/OneDrive/Imágenes/Femenino.png");
                }
                else
                {
                    pcbUsuario.Image = Image.FromFile("C:/Users/aldoo/OneDrive/Imágenes/Masculino.png");

                }

            }
           

            conexion.Close();




        }
       
        //Metodo para cerrar sesion 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("¿Estas seguro que desea cerrar sesion?", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {

            }
            else
            {
                Form login = new Form1();
                this.Hide();
                login.Show();
            }
        }
        
        //Nos manda a la ventana del voto
        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
            
            
                Form m = new VotacionesLocales();
                this.Hide();
                m.Show();
            
           


        }

        //Metodo para redireccionar al usuario a la pagina oficial del INE
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ine.mx/");
        }
       

        //Metodo click para ir a nuestra cuenta
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            Form x = new Cuenta();
            
            this.Close();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form rv = new Rvotos();
            this.Close();
            rv.Show();
        }

       
    }
    
}
