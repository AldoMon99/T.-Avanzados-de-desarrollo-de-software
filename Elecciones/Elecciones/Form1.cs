using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libreria para la conexion de la base de datos
using System.Data.SqlClient;

namespace Elecciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }
        //Conexion a la base de datos
        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Elecciones;Integrated Security=True");
        
        //Boton para ingresar a la pagina principal
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            //Sentencia en sql server para loguearse 
            SqlCommand login = new SqlCommand("select curp, Contraseña from Datos where curp= '"+txtUsuario.Text+"' and Contraseña= '"+txtContraseña.Text+"'",conexion);
            SqlDataReader dr = login.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login existoso");
                principal p = new principal();
                this.Hide();
                p.ShowDialog();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtUsuario.Focus();
            }
            conexion.Close();
            Dato.valor = txtUsuario.Text;
            Dato.valor2 = txtUsuario.Text;
        }

        //Limpia todos los campos 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtUsuario.Focus();
        }

        //Cierra programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo KeyDown y KeyPress para poder loguearse al darle enter
     

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtUsuario.Focus();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtContraseña.Focus();
        }

        private void txtContraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnIngresar_Click(sender, e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form a = new Registro();
            this.Hide();
            a.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
