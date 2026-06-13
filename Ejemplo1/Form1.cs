using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string mail = txtMail.Text;
            string fecha = dateTime.Value.ToShortDateString();
            string estadoCivil;
            if (rbCasado.Checked)
            {
                estadoCivil = "Casado";
            }
            else if (rbSeparado.Checked)
            {
                estadoCivil = "Separado";
            }
            else estadoCivil = "Soltero";

            //bool vehiculo = checkVehiculo.Checked;
            //Aca podemos probar con un operador ternario
            string vehiculo = checkVehiculo.Checked == true ? "Tiene vehiculo" : "No tiene vehiculo";
            
            string zona = cbZona.SelectedItem.ToString();


            MessageBox.Show("Nombre : " + nombre + ", " + "Apellido : " + apellido + " ," + "Mail : " + mail + " ," + "Fecha de naciemiento : " + fecha + " , " + vehiculo + " , " + "Estado civil :" +  estadoCivil + " , " + "Vive en zona : "  + zona);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string agregarObjetos = txtObjetos.Text;
            listObjetos.Items.Add(agregarObjetos);
            if (txtObjetos.Text == agregarObjetos )
            {
                txtObjetos.Text = "";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtObjetos.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listObjetos.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbZona.Items.Add("Zona este");
            cbZona.Items.Add("Zona oeste");
            cbZona.Items.Add("Zona norte");
            cbZona.Items.Add("Zona sur");
        }
    }
}
