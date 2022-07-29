using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace letras
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
                int alto = 100;
                int ancho = 65;

            for (byte fila = 0; fila < 5; fila++)
            {
                Label letras = new Label();
                letras.Height = alto;
                letras.Width = ancho;
                letras.BackColor = Color.Blue;
                letras.ForeColor = Color.AntiqueWhite;
                letras.Font = new Font("Arial", 60);
                letras.TextAlign = ContentAlignment.MiddleCenter;
                letras.BorderStyle = BorderStyle.FixedSingle;
                letras.Left = 200 + (ancho + 20) * fila;
                letras.Top = 60;
                letras.Text = null;
                letras.MouseMove += new MouseEventHandler(this.letras_MouseMove);
                this.Controls.Add(letras);
            }
        }
        private void letras_MouseMove(object sender, MouseEventArgs e)
        {
            Label letra = (Label)sender;
            if(MouseButtons == MouseButtons.Left)
            {
                Debug.WriteLine(e.Location);
                letra.Location = new Point(letra.Location.X + e.Location.X, letra.Location.Y + e.Location.Y);
            }
        }
    }
}
