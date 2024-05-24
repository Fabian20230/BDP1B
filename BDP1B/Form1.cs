using BDP1B.DATA.DATAAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDP1B
{
    public partial class Form1 : Form
    {
        private PERSONAJEDB personaje;

        public Form1()
        {
            InitializeComponent();
            personaje = new PERSONAJEDB();
        }

        private void PRUEBA_Click(object sender, EventArgs e)
        {
        
            if (personaje.Probarconexion())
            {
                MessageBox.Show("si se pudo");

            }else
            {
                MessageBox.Show("nel pastel");
            }
        }

        private void carga_Click(object sender, EventArgs e)
        {
            dataGridViewpersonajes.DataSource = personaje.leerpersonajes();
        }

        private void INSERTAR_Click(object sender, EventArgs e)
        {
            string nombre = NOMBRE.Text;
            string raza = RAZA.Text;
            int nivelpoder = (int)NumericUpDownNIVEL_DE_PODER.Value;
            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelpoder);
            if (respuesta > 0) {
                MessageBox.Show("SE CREO CORRECTAMENTE");
                dataGridViewpersonajes.DataSource = personaje.leerpersonajes();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
