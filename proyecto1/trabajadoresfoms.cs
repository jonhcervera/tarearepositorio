using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class trabajadoresfoms : Form
    {
        public trabajadoresfoms()
        {
            InitializeComponent();
        }

        private void trabajadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trabajadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basedatos1DataSet);

        }

        private void trabajadoresfoms_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basedatos1DataSet.trabajadores' Puede moverla o quitarla según sea necesario.
            this.trabajadoresTableAdapter.Fill(this.basedatos1DataSet.trabajadores);

        }
    }
}
