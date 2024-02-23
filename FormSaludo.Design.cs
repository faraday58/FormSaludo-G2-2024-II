using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormSaludo_G2_2024_II
{
    internal partial class FormSaludo:Form
    {
        private Label lbEtiqueta;
        private TextBox txtNombre;
        private Button btnAceptar;
        private Button btnCancelar;

        public void InitializeComponent()
        {
            this.Text = "Formulario Saludo";
            this.Size = new Size(700, 500);


            lbEtiqueta = new Label();
            lbEtiqueta.Text = "Escribe tu nombre";
            lbEtiqueta.Location = new Point(200,100);
            lbEtiqueta.Size = new Size(200, 50);

            txtNombre = new TextBox();
            txtNombre.Text = "Ingresa nombre";
            txtNombre.Location = new Point(200, 150);
            txtNombre.Size = new Size(250, 50);

            btnAceptar = new Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(200, 190);
            btnAceptar.Size = new Size(90, 50);
            btnAceptar.Click += new EventHandler(Click_Saludo);



            this.Controls.Add(lbEtiqueta);
            this.Controls.Add(txtNombre);
            this.Controls.Add(btnAceptar);


        }

    }
}
