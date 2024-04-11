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
    public partial class VotacionesLocales : Form
    {
        private List<CheckBox> checkBoxes;
        public VotacionesLocales()
        {
            InitializeComponent();
            checkBoxes = new List<CheckBox>
            {
                cbxPan, cbxPri, cbxPrd, cbxVerde, cbxPt, cbxNaranja, cbxMorena, cbxIndependiente
            };

            // Asigna el mismo evento para cada CheckBox
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
            }


        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Desmarca todos los demás CheckBoxes excepto el actual
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox != sender)
                {
                    checkBox.Checked = false;
                }
            }
        }
        //Conexion a la base de datos
        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Elecciones;Integrated Security=True");
        private void btnVoto_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string name;
            
            if (txtDistrito.Text==""||txtEntidad.Text==""||txtMunicipio.Text=="")
            {
                MessageBox.Show("Es obligatorio llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                name = txtNombre.Text;
                Dato.valor2 = txtNombre.Text;
                //Sentencia para registrar el voto del usuario 
                SqlCommand GuardarVoto = new SqlCommand("update Datos set EntidadFederativa= @EntidadFederativa, DistritoElectoral=@DistritoElectoral, Municipio=@Municipio, Voto=@Voto where curp=@curp ", conexion);
                GuardarVoto.Parameters.AddWithValue("DistritoElectoral", txtDistrito.Text);
                GuardarVoto.Parameters.AddWithValue("EntidadFederativa", txtEntidad.Text);
                GuardarVoto.Parameters.AddWithValue("Municipio", txtMunicipio.Text);
                GuardarVoto.Parameters.AddWithValue("curp", Dato.valor);
                string valorr = string.Empty;

               




                if (cbxPan.Checked == true)
                {

                    valorr = "PAN";
                }
                if (cbxPri.Checked == true)
                {
                    valorr = "PRI";
                }
                if (cbxPrd.Checked == true)
                {
                    valorr = "PRD";
                }
                if (cbxVerde.Checked == true)
                {
                    valorr = "Partido Verde";
                }
                if (cbxPt.Checked == true)
                {
                    valorr = "PT";
                }
                if (cbxNaranja.Checked == true)
                {
                    valorr = "Naranja";
                }
                if (cbxMorena.Checked == true)
                {
                    valorr = "Morena";
                }
                if (cbxIndependiente.Checked == true)
                {
                    
                    valorr = "Partido independiente: "+name;
                }
                GuardarVoto.Parameters.AddWithValue("Voto", valorr);








                if (valorr == "")
                {
                    MessageBox.Show("Por favor elige tu voto");
                }
                else
                {



                    DialogResult d = MessageBox.Show("Voto elegido:" + valorr + "\nTu voto no se podra cambiar despues de esto \n¿Estas seguro de tu voto?", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        GuardarVoto.ExecuteNonQuery();
                        MessageBox.Show("Tu voto ha sido registrado correctamente \nGracias por votar");
                        Form j = new principal();
                        this.Hide();
                        j.Show();

                    }
                    else
                    {
                        cbxPan.Checked = false;
                        cbxPri.Checked = false;
                        cbxPrd.Checked = false;
                        cbxVerde.Checked = false;
                        cbxPt.Checked = false;
                        cbxNaranja.Checked = false;
                        cbxMorena.Checked = false;
                        cbxIndependiente.Checked = false;
                        txtNombre.Text = "";
                        MessageBox.Show("Realiza de nuevo tu eleccion");
                    }
                }

            }





            conexion.Close();
            

            



        }
                  



        private void txtMunicipio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxIndependiente.Checked == true)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Favor de seleccionar la casilla VOTAR","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
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

        private void txtEntidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            e.KeyChar = char.ToUpper(e.KeyChar);


            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo se pueden ingresar letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; 
                return;
            }
        }

        private void txtDistrito_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
               
                MessageBox.Show("Solo se pueden ingresar números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
    }
}
