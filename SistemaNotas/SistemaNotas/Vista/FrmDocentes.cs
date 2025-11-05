using SistemaNotas.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNotas.Vista
{
    public partial class FrmDocentes : Form
    {
        DocenteController lista = new DocenteController();
        public FrmDocentes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = lista.Buscar(tbDatos.Text);
            dgvRegistro.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            lista.Agregar(tbNombre1.Text, tbApellido1.Text);
            Listar();
            LimpiarCampos();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            lista.Eliminar(tbNombre1.Text, tbApellido1.Text);
            Listar();
            LimpiarCampos();
        }
        private void Listar()
        {
            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = lista.GetDocentes();
            dgvRegistro.Refresh();
        }
        private void LimpiarCampos()
        {
            tbNombre1.Text = "";
            tbApellido1.Text = "";
            tbDatos.Text = "";
        }

        private void btnBuscar_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvRegistro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRegistro.Rows[e.RowIndex];
                tbNombre1.Text = fila.Cells["Nombre"].Value.ToString();
                tbApellido1.Text = fila.Cells["Apellido"].Value.ToString();
                tbNombre1.Focus();
                tbApellido1.Focus();
            }
        }

        private void dgvRegistro_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvRegistro.CurrentRow != null)
            {
                DataGridViewRow fila = dgvRegistro.CurrentRow;
                tbNombre1.Text = fila.Cells["Nombre"].Value.ToString();
                tbApellido1.Text = fila.Cells["Apellido"].Value.ToString();
                tbNombre1.Focus();
                tbApellido1.Focus();
            }
        }

        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRegistro.Rows[e.RowIndex];
                tbNombre1.Text = fila.Cells["Nombre"].Value.ToString();
                tbApellido1.Text = fila.Cells["Apellido"].Value.ToString();
                tbNombre1.Focus();
                tbApellido1.Focus();
            }
        }
    }
}
