using System;
using System.Windows.Forms;

namespace FormSaludo_G2_2024_II
{
    internal partial class FormSaludo
    {
        public FormSaludo()
        {
            InitializeComponent();
        }

        private void Click_Saludo(object sender, EventArgs e )
        {
            MessageBox.Show("Hola " + txtNombre.Text );
        }
    }
}
