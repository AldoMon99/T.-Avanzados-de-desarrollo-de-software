using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libreria de bd
using System.Data.SqlClient;

namespace Elecciones
{
    public partial class Cuenta : Form
    {
        public Cuenta()
        {
            InitializeComponent();
            
           
            
        }
        
        //Conexion a la base de datos
        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Elecciones;Integrated Security=True");
        public void DatosPersonales()
        {
            //Sentencia para seleccionar los datos personales
            SqlCommand ver = new SqlCommand("select * from Datos where curp= @curp", conexion);
            ver.Parameters.AddWithValue("@curp", Dato.valor);
            conexion.Open();
            SqlDataReader re = ver.ExecuteReader();
            if (re.Read())
            {
                txtCCurp.Text = re["curp"].ToString();
                txtCEstado.Text = re["Estado"].ToString();
                txtCGenero.Text = re["Genero"].ToString();
                txtCNombre.Text = re["nombres"].ToString();
                txtAP.Text = re["ApellidoPaterno"].ToString();
                txtAM.Text = re["ApellidoMaterno"].ToString();
                txtDia.Text = re["Dia"].ToString();
                txtMes.Text = re["Mes"].ToString();
                txtAño.Text = re["Año"].ToString();
               


            }
          
           
            conexion.Close();
            
        }

        public void DatosVoto()
        {
            //Sentencia para seleccionar los datos del voto
            SqlCommand votos = new SqlCommand("select * from Datos where curp= @curp", conexion);
            votos.Parameters.AddWithValue("@curp",Dato.valor );
            conexion.Open();
            SqlDataReader ri = votos.ExecuteReader();
            if (ri.Read())
            {
                txtCDistrito.Text = ri["DistritoElectoral"].ToString();
                txtCEntidad.Text = ri["EntidadFederativa"].ToString();
                txtCMunicipio.Text = ri["Municipio"].ToString();
                txtCVoto.Text = ri["Voto"].ToString();
            }
            conexion.Close();
        }

       

       

        private void Cuenta_Load(object sender, EventArgs e)
        {
            
            
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            txtCCurp.Hide();
            txtCNombre.Hide();
            txtAP.Hide();
            txtAM.Hide();
            txtCEstado.Hide();
            txtCGenero.Hide();
            txtDia.Hide();
            txtMes.Hide();
            txtAño.Hide();
            pcbMenos.Hide();
            pictureBox2.Hide();
            gbxVotos.Hide();
            pictureBox2.Hide();
        }
        //Metodo para mostrar los datos personales
        public void mas()
        {
            DatosPersonales();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
            label12.Show();
            txtCCurp.Show();
            txtCNombre.Show();
            txtAP.Show();
            txtAM.Show();
            txtCEstado.Show();
            txtCGenero.Show();
            txtDia.Show();
            txtMes.Show();
            txtAño.Show();
            pcbMostrar.Hide();
            lblvoto.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pcbMenos.Show();
          
            
        }
        //Oculta los datos personales
        public void menos()
        {
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            txtCCurp.Hide();
            txtCNombre.Hide();
            txtAP.Hide();
            txtAM.Hide();
            txtCEstado.Hide();
            txtCGenero.Hide();
            txtDia.Hide();
            txtMes.Hide();
            txtAño.Hide();
            pcbMenos.Hide();
            pcbMostrar.Show();
            lblvoto.Show();
            pictureBox1.Show();
            pictureBox2.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mas();
            pictureBox2.Hide();
            
            
           
        }

        private void pcbMenos_Click(object sender, EventArgs e)
        {
            menos();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DatosVoto();
            label5.Hide();
            pcbMostrar.Hide();
            pcbMenos.Hide();
            gbxVotos.Show();
            pictureBox2.Show();
            pictureBox1.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gbxVotos.Hide();
            pictureBox1.Show();
            label5.Show();
            pcbMostrar.Show();
            pictureBox2.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form sd = new principal();
            this.Hide();
            sd.Show();
        }
    }
}
