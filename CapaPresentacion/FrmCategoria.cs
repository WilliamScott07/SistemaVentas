using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            MessageBox.Show(N_Categoria.Insertar("vaca", "Leche,queso,crema"));
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
           
        }
    }
}
