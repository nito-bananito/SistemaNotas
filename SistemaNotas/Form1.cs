using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaNotas.Vista;

namespace SistemaNotas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCarrera().Show();            
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDocentes().Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEstudiantes().Show();
        }
    }
}
