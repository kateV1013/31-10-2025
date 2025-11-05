using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void carreraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Vista.FrmCarrera().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Vista.FrmDocentes().Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Vista.FrmEstudiantes().Show();
        }
    }
}
