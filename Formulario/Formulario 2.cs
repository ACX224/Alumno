using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos.Formulario
{
    public partial class Formulario_2 : Form
    {
        public Formulario_2()
        {
            InitializeComponent();
        }

        private void Formulario_2_Load(object sender, EventArgs e)
        {

        }

     

        private void GuardarAlumno_Click_1(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Matricula = txtMatricula.Text;
            
            alumno.Nombre = txtAlumno.Text;

            alumno.Grado = txtGrado.Text;

            alumno.Promedio = txtPromedio.Text;

            alumno.Grupo = txtGrupo.Text;

            List<Alumno>alumnos = new List<Alumno>();
            alumnos.Add(alumno);

        }

        
    }
}
