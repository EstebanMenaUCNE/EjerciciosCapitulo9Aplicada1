using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosCapitulo9
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CodigoTarea1Label.Text = "public struct Producto\n{\n\tpublic static int numeroIdActual = 1;\n\tpublic \tint productoId;\n\tpublic string descripcion;\n\tpublic float precio;\n\tpublic int cantidadExistencia;\n\n\tpublic Producto(string descripcion, float precio, int cantidadExistencia)\n{\n\tproductoId = numeroIdActual++;\n\tthis.descripcion = descripcion;\n\tthis.precio = precio;\n\tthis.cantidadExistencia = cantidadExistencia;\n}\n}";
            CodigoTarea2Label.Text = "public struct CuentaBancaria\n{\npublic static int numeroIdActual = 1;\npublic int cuentaBancariaId;\npublic string nombre;\npublic float balance;\n\npublic CuentaBancaria(string nombre, float balance)\n{\ncuentaBancariaId = numeroIdActual++;\nthis.nombre = nombre;\nthis.balance = balance;\n}\n}";
            CodigoTarea3Label.Text = "public struct Mascota\n{\npublic string nombre;\npublic string especie;\npublic string raza;\npublic string color;\n}\n\npublic struct DueñoMascota\n{\npublic string nombre;\npublic string apellido;\npublic Mascota mascota;\n}";
            CodigoTarea4Label.Text = "enum Neumatico { DeBicicleta, DeMotocicleta, DeCarro, DeGuagua, DeJeepeta, DeCarretilla, DeCamion }";
            CodigoTarea5Label.Text = "enum Estrella { Proestrella, Tauri, DeSecuenciaPrincipal, GiganteRoja, EnanaBlanca, EnanaRoja, SuperGigante }";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
