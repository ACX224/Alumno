namespace Alumnos.Formulario
{
    partial class Formulario_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.GuardarAlumno = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtGrado = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(105, 30);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(401, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // GuardarAlumno
            // 
            this.GuardarAlumno.Location = new System.Drawing.Point(276, 335);
            this.GuardarAlumno.Name = "GuardarAlumno";
            this.GuardarAlumno.Size = new System.Drawing.Size(247, 90);
            this.GuardarAlumno.TabIndex = 2;
            this.GuardarAlumno.Text = "Guardar Datos";
            this.GuardarAlumno.UseVisualStyleBackColor = true;
            this.GuardarAlumno.Click += new System.EventHandler(this.GuardarAlumno_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(48, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(44, 13);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Text = "Nombre";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(106, 85);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(399, 20);
            this.txtAlumno.TabIndex = 4;
            // 
            // txtGrado
            // 
            this.txtGrado.AutoSize = true;
            this.txtGrado.Location = new System.Drawing.Point(51, 146);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(36, 13);
            this.txtGrado.TabIndex = 5;
            this.txtGrado.Text = "Grado";
            // 
            // txtPromedio
            // 
            this.txtPromedio.AutoSize = true;
            this.txtPromedio.Location = new System.Drawing.Point(48, 191);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(51, 13);
            this.txtPromedio.TabIndex = 6;
            this.txtPromedio.Text = "Promedio";
            // 
            // txtGrupo
            // 
            this.txtGrupo.AutoSize = true;
            this.txtGrupo.Location = new System.Drawing.Point(51, 236);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(36, 13);
            this.txtGrupo.TabIndex = 7;
            this.txtGrupo.Text = "Grupo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(398, 20);
            this.textBox3.TabIndex = 10;
            // 
            // Formulario_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.GuardarAlumno);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_2";
            this.Text = "Alta de Alumno";
            this.Load += new System.EventHandler(this.Formulario_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button GuardarAlumno;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label txtGrado;
        private System.Windows.Forms.Label txtPromedio;
        private System.Windows.Forms.Label txtGrupo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}