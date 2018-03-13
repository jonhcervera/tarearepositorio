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
    public partial class categoriasForm : Form
    {
        public categoriasForm()
        {
            InitializeComponent();
        }

        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basedatos1DataSet);

        }

        private void categoriasForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basedatos1DataSet.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.basedatos1DataSet.categorias);

        }
    }
}
