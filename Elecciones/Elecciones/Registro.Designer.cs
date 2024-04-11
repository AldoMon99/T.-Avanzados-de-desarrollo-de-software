namespace Elecciones
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDia = new System.Windows.Forms.ComboBox();
            this.cbxMes = new System.Windows.Forms.ComboBox();
            this.txtCURP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxAño = new System.Windows.Forms.ComboBox();
            this.gpbGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(554, 530);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(126, 46);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(422, 530);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 46);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(290, 530);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 46);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gpbGenero
            // 
            this.gpbGenero.Controls.Add(this.rdbMasculino);
            this.gpbGenero.Controls.Add(this.rdbFemenino);
            this.gpbGenero.Location = new System.Drawing.Point(487, 208);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Size = new System.Drawing.Size(151, 105);
            this.gpbGenero.TabIndex = 39;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "Genero";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(6, 43);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(105, 24);
            this.rdbMasculino.TabIndex = 15;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(6, 70);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(105, 24);
            this.rdbFemenino.TabIndex = 16;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Aguascalientes ",
            "Baja California ",
            "Baja California Sur ",
            "Campeche ",
            "Chiapas ",
            "Chihuahua ",
            "Ciudad de México ",
            "Coahuila ",
            "Colima ",
            "Durango ",
            "Estado de México ",
            "Guanajuato ",
            "Guerrero ",
            "Hidalgo ",
            "Jalisco ",
            "Michoacán ",
            "Morelos ",
            "Nayarit ",
            "Nuevo León ",
            "Oaxaca ",
            "Puebla ",
            "Querétaro ",
            "Quintana Roo ",
            "San Luis Potosí ",
            "Sinaloa ",
            "Sonora ",
            "Tabasco ",
            "Tamaulipas ",
            "Tlaxcala ",
            "Veracruz ",
            "Yucatán ",
            "Zacatecas "});
            this.cbxEstado.Location = new System.Drawing.Point(486, 174);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(296, 28);
            this.cbxEstado.TabIndex = 34;
            this.cbxEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxEstado_KeyPress);
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(86, 247);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.ShortcutsEnabled = false;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(296, 26);
            this.txtApellidoPaterno.TabIndex = 32;
            this.txtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPaterno_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 174);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(296, 26);
            this.txtNombre.TabIndex = 31;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Registro ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 59);
            this.label1.TabIndex = 25;
            this.label1.Text = "Instituto Nacional Electoral";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(86, 316);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.ShortcutsEnabled = false;
            this.txtApellidoMaterno.Size = new System.Drawing.Size(296, 26);
            this.txtApellidoMaterno.TabIndex = 45;
            this.txtApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoMaterno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Apellido Materno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 46;
            this.label7.Text = "Estado";
            // 
            // cbxDia
            // 
            this.cbxDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxDia.Location = new System.Drawing.Point(86, 390);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(55, 28);
            this.cbxDia.TabIndex = 47;
            this.cbxDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxDia_KeyPress);
            // 
            // cbxMes
            // 
            this.cbxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMes.FormattingEnabled = true;
            this.cbxMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbxMes.Location = new System.Drawing.Point(147, 390);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(129, 28);
            this.cbxMes.TabIndex = 48;
            // 
            // txtCURP
            // 
            this.txtCURP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCURP.Location = new System.Drawing.Point(486, 345);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(296, 26);
            this.txtCURP.TabIndex = 51;
            this.txtCURP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCURP_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(482, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 22);
            this.label8.TabIndex = 50;
            this.label8.Text = "CURP";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(605, 389);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(177, 26);
            this.txtContraseña.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(483, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 22);
            this.label9.TabIndex = 52;
            this.label9.Text = "Contraseña:";
            // 
            // cbxAño
            // 
            this.cbxAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAño.FormattingEnabled = true;
            this.cbxAño.Items.AddRange(new object[] {
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922"});
            this.cbxAño.Location = new System.Drawing.Point(282, 390);
            this.cbxAño.Name = "cbxAño";
            this.cbxAño.Size = new System.Drawing.Size(100, 28);
            this.cbxAño.TabIndex = 54;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 588);
            this.Controls.Add(this.cbxAño);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCURP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxMes);
            this.Controls.Add(this.cbxDia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gpbGenero);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro";
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gpbGenero;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxDia;
        private System.Windows.Forms.ComboBox cbxMes;
        private System.Windows.Forms.TextBox txtCURP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxAño;
    }
}