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
    public partial class entradaForm : Form
    {
        public entradaForm()
        {
            InitializeComponent();
        }

        private void entradasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.entradasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basedatos1DataSet);

        }

        private void entradaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basedatos1DataSet.entradas' Puede moverla o quitarla según sea necesario.
            this.entradasTableAdapter.Fill(this.basedatos1DataSet.entradas);

        }
    }
}
