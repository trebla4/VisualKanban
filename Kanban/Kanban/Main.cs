using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban
{
    public partial class Main : Form, IForm
    {
        //private bool arrastrando = false;

        public Main()
        {
            InitializeComponent();
        }
        /*
        private void label5_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            arrastrando = false;
        }

        private void label5_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            arrastrando = true;
        }

        private void label5_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Control ctrl = sender as Control;
            if (arrastrando)
            {
                Point p1 = ctrl.PointToScreen(e.Location);
                Point p2 = ctrl.Parent.PointToClient(p1);
                ctrl.Location = p2;
            }
        }
        */    
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            PanelNuevo panel = new PanelNuevo();
            panel.Show(this);
        }

        public void crearLabel(string titulo, int x, int y) 
        {
            Label namelabel = new Label();
            namelabel.Location = new Point(x, y);
            namelabel.Text = titulo;
            this.Controls.Add(namelabel);
            namelabel.AutoSize = true;
        }

    }
}
