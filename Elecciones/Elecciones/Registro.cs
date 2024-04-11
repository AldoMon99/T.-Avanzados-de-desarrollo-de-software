using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data .SqlClient;

namespace Elecciones
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            txtCURP.KeyPress += new KeyPressEventHandler(txtCURP_KeyPress); 
            txtCURP.MaxLength = 18; 
        }
        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Elecciones;Integrated Security=True");

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("¿Estas seguro que desea salir?", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                txtNombre.Focus();
            }
            else
            {
                Form b = new Form1();
                this.Hide();
                b.Show();
            }
        }

        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCURP.Clear();
            txtContraseña.Clear();
            cbxEstado.SelectedIndex = -1;
            cbxDia.SelectedIndex = -1;
            cbxMes.SelectedIndex = -1;
            cbxAño.SelectedIndex=-1;
            rdbMasculino.Checked = false;
            rdbFemenino.Checked = false;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCURP.Text.Length < 18)
            {
                MessageBox.Show("La CURP está incompleta. Debe tener 18 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conexion.Open();

                SqlCommand Guardar = new SqlCommand("insert into Datos (curp, nombres, ApellidoPaterno, ApellidoMaterno, " +
                    "Dia, Mes, Año, Estado, Genero, Contraseña, EntidadFederativa, DistritoElectoral, Municipio,Voto) " +
                    "values (@curp, @nombres, @ApellidoPaterno, @ApellidoMaterno, @Dia, @Mes, @Año, @Estado, @Genero, @Contraseña, @EntidadFederativa, @DistritoElectoral, @Municipio,@Voto)", conexion);
                if (txtCURP.Text == "" || txtNombre.Text == "" || txtApellidoPaterno.Text == "" || txtApellidoMaterno.Text == "" || cbxDia.Text == "" || cbxMes.Text == "" || cbxAño.Text == "" || cbxEstado.Text == "" || txtContraseña.Text == "" || rdbFemenino.Checked == false && rdbMasculino.Checked == false)
                {
                    MessageBox.Show("Es obligatorio llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                }
                else
                {


                    Guardar.Parameters.AddWithValue("curp", txtCURP.Text);
                    Guardar.Parameters.AddWithValue("nombres", txtNombre.Text);
                    Guardar.Parameters.AddWithValue("ApellidoPaterno", txtApellidoPaterno.Text);
                    Guardar.Parameters.AddWithValue("ApellidoMaterno", txtApellidoMaterno.Text);
                    Guardar.Parameters.AddWithValue("Dia", cbxDia.Text);
                    Guardar.Parameters.AddWithValue("Mes", cbxMes.Text);
                    Guardar.Parameters.AddWithValue("Año", cbxAño.Text);
                    Guardar.Parameters.AddWithValue("Estado", cbxEstado.Text);
                    string valor = string.Empty;
                    if (rdbFemenino.Checked == true)
                    {
                        valor = "Femenino";
                    }
                    if (rdbMasculino.Checked == true)
                    {
                        valor = "Masculino";
                    }
                    Guardar.Parameters.AddWithValue("Genero", valor);
                    Guardar.Parameters.AddWithValue("Contraseña", txtContraseña.Text);
                    Guardar.Parameters.AddWithValue("EntidadFederativa", "");
                    Guardar.Parameters.AddWithValue("DistritoElectoral", "");
                    Guardar.Parameters.AddWithValue("Municipio", "");
                    Guardar.Parameters.AddWithValue("Voto", "");
                    Guardar.ExecuteNonQuery();
                    MessageBox.Show("Registrado exitosamente");
                    Form l = new Form1();
                    this.Hide();
                    l.Show();





                }

                conexion.Close();






            }

            catch
            {
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 33 && e.KeyChar <=64) || (e.KeyChar >=91 && e.KeyChar <=96) || 
                (e.KeyChar >=123 && e.KeyChar <= 129) || (e.KeyChar >=131 && e.KeyChar <=159) || 
                (e.KeyChar >=166 && e.KeyChar <=180) || (e.KeyChar >=182 && e.KeyChar <=223) || 
                (e.KeyChar >= 225 && e.KeyChar <=232) || e.KeyChar >=234 && e.KeyChar <=255) 
            {
                MessageBox.Show("Favor de solo ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
                (e.KeyChar >= 123 && e.KeyChar <= 129) || (e.KeyChar >= 131 && e.KeyChar <= 159) ||
                (e.KeyChar >= 166 && e.KeyChar <= 180) || (e.KeyChar >= 182 && e.KeyChar <= 223) ||
                (e.KeyChar >= 225 && e.KeyChar <= 232) || e.KeyChar >= 234 && e.KeyChar <= 255)
            {
                MessageBox.Show("Favor de solo ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
                (e.KeyChar >= 123 && e.KeyChar <= 129) || (e.KeyChar >= 131 && e.KeyChar <= 159) ||
                (e.KeyChar >= 166 && e.KeyChar <= 180) || (e.KeyChar >= 182 && e.KeyChar <= 223) ||
                (e.KeyChar >= 225 && e.KeyChar <= 232) || e.KeyChar >= 234 && e.KeyChar <= 255)
            {
                MessageBox.Show("Favor de solo ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

       

            private void cbxDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCURP_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                
                MessageBox.Show("Solo se pueden ingresar letras y números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; 
                return;
            }
        }
    }
}
