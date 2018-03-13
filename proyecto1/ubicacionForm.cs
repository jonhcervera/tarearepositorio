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
    public partial class ubicacionForm : Form
    {
        public ubicacionForm()
        {
            InitializeComponent();
        }

        private void ubicacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ubicacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basedatos1DataSet);

        }

        private void ubicacionForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basedatos1DataSet.ubicaciones' Puede moverla o quitarla según sea necesario.
            this.ubicacionesTableAdapter.Fill(this.basedatos1DataSet.ubicaciones);

        }
    }
}
