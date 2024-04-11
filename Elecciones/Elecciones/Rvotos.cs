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
    public partial class Rvotos : Form
    {
        string vpri="";
        string vpan = "";
        string vprd = "";
        string vverde = "";
        string vpt = "";
        string vna = "";
        string vmo = "";
        string vci = "";

        public Rvotos()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Elecciones;Integrated Security=True");

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form prin = new principal();
            this.Close();
            prin.Show();
        }

        private void Rvotos_Load(object sender, EventArgs e)
        {
            SqlCommand pri = new SqlCommand("Select count(*) from Datos where Voto= @Voto", conexion);
            pri.Parameters.AddWithValue("@Voto", "PRI");
            conexion.Open();
            SqlDataReader voto = pri.ExecuteReader();

            if (voto.Read())
            {
                conexion.Close();
                conexion.Open();
                vpri = pri.ExecuteScalar().ToString();
                pgbPri.Value = Convert.ToInt32(vpri);
                lblPri.Text = vpri;


            }
            conexion.Close();
            SqlCommand pan = new SqlCommand("Select count(*) from Datos where Voto= @Voto", conexion);
            pan.Parameters.AddWithValue("@Voto", "PAN");
            conexion.Open();
            SqlDataReader voto2 = pan.ExecuteReader();
            if (voto2.Read())
            {
                conexion.Close();
                conexion.Open();
                vpan = pan.ExecuteScalar().ToString();
                pgbPan.Value = Convert.ToInt32(vpan);
                lblPan.Text = vpan;

            }
            conexion.Close();
            SqlCommand prd = new SqlCommand("Select count(*) from Datos where Voto= @Voto", conexion);
            prd.Parameters.AddWithValue("@Voto", "PRD");
            conexion.Open();
            SqlDataReader voto3 = prd.ExecuteReader();
            if (voto3.Read())
            {
                conexion.Close();
                conexion.Open();
                vprd = prd.ExecuteScalar().ToString();
                pgbPrd.Value = Convert.ToInt32(vprd);
                lblPrd.Text = vprd;

            }
            conexion.Close();
            SqlCommand verde = new SqlCommand("Select count(*) from Datos where Voto= @Voto", conexion);
            verde.Parameters.AddWithValue("@Voto", "Partido Verde");
            conexion.Open();
            SqlDataReader voto4 = verde.ExecuteReader();
            if (voto4.Read())
            {
                conexion.Close();
                conexion.Open();
                vverde = verde.ExecuteScalar().ToString();
                pgbVerde.Value = Convert.ToInt32(vverde);
                lblVerde.Text = vverde;

            }
            conexion.Close();
            SqlCommand pt = new SqlCommand("Select count(*) from Datos where Voto= @Voto", conexion);
            pt.Parameters.AddWithValue("@Voto", "PT");
            conexion.Open();
            SqlDataReader voto5 = pt.ExecuteReader();
            if (voto5.Read())
            {
                conexion.Close();
                conexion.Open();
                vpt = pt.ExecuteScalar().ToString();
                pgbPt.Value = Convert.ToInt32(vpt);
                lblPt.Text = vpt;

            }
            conexion.Close();
            SqlCommand na = new SqlCommand("Select count(*) from Datos where Voto= @Voto", conexion);
            na.Parameters.AddWithValue("@Voto", "Naranja");
            conexion.Open();
            SqlDataReader voto6 = na.ExecuteReader();
            if (voto6.Read())
            {
                conexion.Close();
                conexion.Open();
                vna = na.ExecuteScalar().ToString();
                pgbNa.Value = Convert.ToInt32(vna);
                lblNa.Text = vna;

            }
            conexion.Close();
            SqlCommand mo = new SqlCommand("Select count(*) from Datos where Voto= @Voto", conexion);
            mo.Parameters.AddWithValue("@Voto", "Morena");
            conexion.Open();
            SqlDataReader voto7 = mo.ExecuteReader();
            if (voto7.Read())
            {
                conexion.Close();
                conexion.Open();
                vmo = mo.ExecuteScalar().ToString();
                pgbMo.Value = Convert.ToInt32(vmo);
                lblMo.Text = vmo;

            }
            conexion.Close();
            SqlCommand ci = new SqlCommand("Select count(*) from Datos where Voto= @Voto", conexion);
            ci.Parameters.AddWithValue("@Voto", "Partido Independiente: " + Dato.valor2);
            conexion.Open();
            SqlDataReader voto8 = ci.ExecuteReader();
            if (voto8.Read())
            {
                conexion.Close();
                conexion.Open();
                vci = ci.ExecuteScalar().ToString();
                pgbCi.Value = Convert.ToInt32(vci);
                lblCi.Text = vci;

            }
            conexion.Close();
            int tv,tv1,tv2,tv3,tv4,tv5,tv6,tv7;
           
            int resultado;
            tv = Convert.ToInt32(vpri);
            tv1 = Convert.ToInt32(vpan);
            tv2 = Convert.ToInt32(vpt);
            tv3 = Convert.ToInt32(vprd);
            tv4 = Convert.ToInt32(vmo);
            tv5 = Convert.ToInt32(vna);
            tv6 = Convert.ToInt32(vverde);
            tv7 = Convert.ToInt32(vci);
            resultado = tv + tv1 + tv2 + tv3 + tv4 + tv5 + tv6 + tv7;
            txtTotalVotos.Text = "Votos totales: " + resultado.ToString();

            int resultadoPan, resultadoPri, resultadoPrd,resultadoPt,resultadoVerde,resultadoMorena,resultadoNaranja,resultadoIndependiente;
            resultadoPan = (tv1 * 100)/resultado;
            resultadoPri = (tv * 100) / resultado;
            resultadoPrd = (tv3 * 100) / resultado;
            resultadoPt = (tv2 * 100) / resultado;
            resultadoVerde = (tv6 * 100) / resultado;
            resultadoMorena = (tv4 * 100) / resultado;
            resultadoNaranja = (tv5 * 100) / resultado;
            resultadoIndependiente = (tv7 * 100) / resultado;
            lblPpan.Text = resultadoPan.ToString() + "%";
            lblPpri.Text = resultadoPri.ToString() +"%";
            lblPprd.Text = resultadoPrd.ToString() +"%";
            lblPpt.Text = resultadoPt.ToString() +"%";
            lblPverde.Text = resultadoVerde.ToString() +"%";
            lblPmo.Text = resultadoMorena.ToString() +"%";
            lblPna.Text = resultadoNaranja.ToString() +"%";
            lblPci.Text = resultadoIndependiente.ToString() +"%";

        }
    }
}
