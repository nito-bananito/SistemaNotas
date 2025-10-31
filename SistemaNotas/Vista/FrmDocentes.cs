using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaNotas.Controlador;

namespace SistemaNotas.Vista
{
    public partial class FrmDocentes : Form
    {
        DocenteController Lista = new DocenteController();
        public FrmDocentes()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            dgvRegistroD.DataSource = null;
            dgvRegistroD.DataSource = Lista.GetDocentes();
            dgvRegistroD.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRegistroD.Rows[e.RowIndex];
                tbNombreD.Text = fila.Cells[0].Value.ToString();
                tbApellidoD.Text = fila.Cells[1].Value.ToString();
                tbCodigoD.Text = fila.Cells[2].Value.ToString();
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            Lista.Eliminar1(tbCodigoD.Text, tbNombreD.Text, tbApellidoD.Text);
            Listar();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            dgvRegistroD.DataSource = null;
            dgvRegistroD.DataSource = Lista.GetDocentes(tbDato2.Text);
            dgvRegistroD.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Lista.Agregar1(tbNombreD.Text, tbApellidoD.Text, tbCodigoD.Text);
            Listar();
            tbNombreD.Clear();
            tbCodigoD.Clear();
            tbApellidoD.Clear();
            tbNombreD.Focus();
        }
    }
}
