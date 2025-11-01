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
    public partial class FrmCarrera : Form
    {
        CarreraController lista = new CarreraController();
        public FrmCarrera()
        {
            InitializeComponent();
        }

        private void Carrera_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            lista.Agregar(tbNombre.Text, tbCodigo.Text);
            Listar();
            LimpiarCampos();
        }

        private void Listar()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = lista.GetCarreras();
            dgvRegistros.Refresh();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            lista.Eliminar(tbNombre.Text, tbCodigo.Text);
            Listar();
            LimpiarCampos();
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            { 
                DataGridViewRow fila = dgvRegistros.Rows[e.RowIndex];
                tbCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                tbNombre.Text = fila.Cells["Nombre"].Value.ToString();
                tbCodigo.Focus();
                tbNombre.Focus();

            }

        }
        //Los datos de la lista con un doble click pasarlo a los textbox
        private void dgvRegistros_DoubleClick(object sender, EventArgs e)
        {
            
        }
        private void LimpiarCampos()
        {
            tbNombre.Clear();
            tbCodigo.Clear();
            tbNombre.Focus();
            tbCodigo.Focus();
        }

        private void dgvRegistros_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow fila = dgvRegistros.Rows[e.RowIndex];
                tbCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                tbNombre.Text = fila.Cells["Nombre"].Value.ToString();
                tbCodigo.Focus();
                tbNombre.Focus();

            }
        }

        private void tbDatos_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = lista.GetCarreras(tbDatos.Text);
            dgvRegistros.Refresh();
        }
    }
}
