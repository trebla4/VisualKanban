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
    public partial class PanelNuevo : Form
    {
        public PanelNuevo()
        {
            InitializeComponent();
            comboBoxEstado.Items.Add("BACKLOG");
            comboBoxEstado.Items.Add("DOING");
            comboBoxEstado.Items.Add("DONE");
        }


    }
}
