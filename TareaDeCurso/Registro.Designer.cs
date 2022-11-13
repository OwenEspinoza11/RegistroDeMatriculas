namespace TareaDeCurso
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
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gpbDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(23, 52);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(147, 32);
            this.txtNombre1.TabIndex = 0;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(23, 123);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(147, 32);
            this.txtApellido1.TabIndex = 1;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(217, 123);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(147, 32);
            this.txtApellido2.TabIndex = 2;
            this.txtApellido2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(217, 52);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(147, 32);
            this.txtNombre2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primer nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Primer Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(217, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Segundo nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Segundo apellido";
            // 
            // gpbDatosPersonales
            // 
            this.gpbDatosPersonales.Controls.Add(this.label8);
            this.gpbDatosPersonales.Controls.Add(this.txtNacionalidad);
            this.gpbDatosPersonales.Controls.Add(this.label7);
            this.gpbDatosPersonales.Controls.Add(this.dtpFechaNacimiento);
            this.gpbDatosPersonales.Controls.Add(this.label6);
            this.gpbDatosPersonales.Controls.Add(this.cboEstadoCivil);
            this.gpbDatosPersonales.Controls.Add(this.label5);
            this.gpbDatosPersonales.Controls.Add(this.cboSexo);
            this.gpbDatosPersonales.Controls.Add(this.txtNombre1);
            this.gpbDatosPersonales.Controls.Add(this.label3);
            this.gpbDatosPersonales.Controls.Add(this.label4);
            this.gpbDatosPersonales.Controls.Add(this.txtApellido1);
            this.gpbDatosPersonales.Controls.Add(this.txtApellido2);
            this.gpbDatosPersonales.Controls.Add(this.label2);
            this.gpbDatosPersonales.Controls.Add(this.txtNombre2);
            this.gpbDatosPersonales.Controls.Add(this.label1);
            this.gpbDatosPersonales.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbDatosPersonales.ForeColor = System.Drawing.Color.White;
            this.gpbDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosPersonales.Name = "gpbDatosPersonales";
            this.gpbDatosPersonales.Size = new System.Drawing.Size(776, 311);
            this.gpbDatosPersonales.TabIndex = 8;
            this.gpbDatosPersonales.TabStop = false;
            this.gpbDatosPersonales.Text = "Datos personales";
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(410, 53);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(147, 31);
            this.cboSexo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(410, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sexo";
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(410, 124);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(147, 31);
            this.cboEstadoCivil.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(410, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado civil";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(594, 53);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(147, 32);
            this.dtpFechaNacimiento.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(594, 124);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(147, 32);
            this.txtNacionalidad.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nacionalidad";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbDatosPersonales);
            this.Name = "Registro";
            this.Text = "Registro";
            this.gpbDatosPersonales.ResumeLayout(false);
            this.gpbDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtNombre1;
        private TextBox txtApellido1;
        private TextBox txtApellido2;
        private TextBox txtNombre2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox gpbDatosPersonales;
        private Label label8;
        private TextBox txtNacionalidad;
        private Label label7;
        private DateTimePicker dtpFechaNacimiento;
        private Label label6;
        private ComboBox cboEstadoCivil;
        private Label label5;
        private ComboBox cboSexo;
    }
}