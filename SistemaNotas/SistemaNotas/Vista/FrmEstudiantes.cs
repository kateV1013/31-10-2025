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
    public partial class FrmEstudiantes : Form
    {
        EstudiantesController lista = new EstudiantesController();
        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            lista.Agregar(tbNombre1.Text, tbCodigo1.Text);
            Listar();
            LimpiarCampos();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            lista.Eliminar(tbNombre1.Text, tbCodigo1.Text);
            Listar();
            LimpiarCampos();
        }
        private void Listar()
        {
            dgvRegistro2.DataSource = null;
            dgvRegistro2.DataSource = lista.GetEstudiantes();
            dgvRegistro2.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvRegistro2.DataSource = null;
            dgvRegistro2.DataSource = lista.Buscar(tbDatos2.Text);
            dgvRegistro2.Refresh();
        }
        private void LimpiarCampos()
        {
            tbNombre1.Text = "";
            tbCodigo1.Text = "";
            tbDatos2.Text = "";
        }

        private void dgvRegistro2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                DataGridViewRow fila = dgvRegistro2.Rows[e.RowIndex];
                tbCodigo1.Text = fila.Cells["Codigo"].Value.ToString();
                tbNombre1.Text = fila.Cells["Nombre"].Value.ToString();
                tbCodigo1.Focus();
                tbNombre1.Focus();
            }
        }

        private void dgvRegistro2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow fila = dgvRegistro2.Rows[e.RowIndex];
                tbCodigo1.Text = fila.Cells["Codigo"].Value.ToString();
                tbNombre1.Text = fila.Cells["Nombre"].Value.ToString();
                tbCodigo1.Focus();
                tbNombre1.Focus();
            }
        }
    }
}
