using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kanban
{
    public partial class PanelNuevo : Form
    {
        public PanelNuevo()
        {
            InitializeComponent();
            comboBoxEstado.Items.Add("BACKLOG");
            comboBoxEstado.Items.Add("DOING");
            comboBoxEstado.Items.Add("DONE");
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            IForm formInterface = this.Owner as IForm;
            if (formInterface != null)
            {
                if (comboBoxEstado.SelectedItem.ToString() == "BACKLOG")
                    formInterface.crearLabel(textBoxTitulo.Text, 183, 60);

                if (comboBoxEstado.SelectedItem.ToString() == "DOING")
                    formInterface.crearLabel(textBoxTitulo.Text, 319, 60);

                if (comboBoxEstado.SelectedItem.ToString() == "DONE")
                    formInterface.crearLabel(textBoxTitulo.Text, 443, 60);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
