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
    public partial class FrmEstudiantes : Form
    {
        EstudianteController Listas = new EstudianteController();
        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = Listas.GetEstudiantes();
            dgvEstudiantes.Refresh();
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Listas.Agregar1(tbNombreE.Text, tbApellidoE.Text, tbCodigoE.Text);
            Listar();
            tbNombreE.Clear();
            tbCodigoE.Clear();
            tbApellidoE.Clear();
            tbNombreE.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Listas.Eliminar1(tbCodigoE.Text, tbNombreE.Text, tbApellidoE.Text);
            Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = Listas.GetEstudiantes(tbDatoE.Text);
            dgvEstudiantes.Refresh();
        }


        private void tbDatoE_Click(object sender, EventArgs e)
        {

        }

        private void dgvEstudiantes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow != null)
            {
                DataGridViewRow fila = dgvEstudiantes.CurrentRow;
                tbNombreE.Text = fila.Cells[0].Value?.ToString();
                tbApellidoE.Text = fila.Cells[1].Value?.ToString();
                tbCodigoE.Text = fila.Cells[2].Value?.ToString();
            }
        }
    }
}
