using System;
using System.Windows.Forms;

namespace BSC_CMI_CuadroDeMandoIntegral
{
    public partial class frmEdicionDGVcmi : Form
    {
        DataGridView dgvInicial;

        public frmEdicionDGVcmi(string descripcion, DataGridView dgvDado)
        {
            InitializeComponent();

            textBox0.Text = descripcion;
            dgvInicial = dgvDado;
            dgv.DataSource = dgvInicial.DataSource;
            for (int i = 0; i < dgvInicial.Rows.Count; i++)
            {
                dgv.Rows.Add(i + 1, dgvInicial[1, i].Value);
            }

            dgv.ReadOnly = false;
            dgv.Columns[1].ReadOnly = false;
            dgv.ColumnHeadersVisible = true;
        }

        public frmEdicionDGVcmi(string descripcion, DataGridView dgvDado, int fila)
        {
            InitializeComponent();

            textBox0.Text = descripcion;
            dgvInicial = dgvDado;
            dgv.DataSource = dgvInicial.DataSource;
            for (int i = 0; i < dgvInicial.Rows.Count; i++)
            {
                dgv.Rows.Add(i + 1, dgvInicial[1, i].Value);
            }

            dgv.ReadOnly = false;
            dgv.Columns[1].ReadOnly = false;
            dgv.ColumnHeadersVisible = true;
            dgv.CurrentCell = dgv[1, fila];
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            int fila = 0;
            try
            {
                fila = dgv.CurrentRow.Index;
            }
            catch
            {
                fila = 0;
            }

            if (fila == dgv.Rows.Count)
            {
                dgv.Rows.Add(fila + 1, "");
            }
            else
            {
                fila++;
                dgv.Rows.Insert(fila);
                for (int i = fila; i < dgv.Rows.Count; i++)
                    dgv[0, i].Value = i + 1;
            }

            dgv.CurrentCell = dgv[1, fila];
            dgv.BeginEdit(true);
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            

            dgv.ReadOnly = true;
            dgvInicial.Rows.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgvInicial.Rows.Add(i + 1, dgv[1, i].Value);
            }

            dgvInicial.Columns[0].MinimumWidth = 20;
            dgvInicial.Columns[0].Width = 20;

            this.Close();
        }

        private void btSubir_Click(object sender, EventArgs e)
        {
            int fila = 0;

            try
            {
                fila = dgv.CurrentRow.Index;
            }
            catch
            {
                return;
            }

            if (fila == 0)
                return;

            string swap = dgv[1, fila].Value.ToString();
            dgv[1, fila].Value = dgv[1, fila - 1].Value;
            dgv[1, fila - 1].Value = swap;

            dgv.CurrentCell = dgv[1, fila - 1];
            dgv.BeginEdit(true);
        }

        private void btBajar_Click(object sender, EventArgs e)
        {
            int fila = 0;

            try
            {
                fila = dgv.CurrentRow.Index;
            }
            catch
            {
                return;
            }

            if (fila == dgv.Rows.Count - 1)
                return;

            string swap = dgv[1, fila].Value.ToString();
            dgv[1, fila].Value = dgv[1, fila + 1].Value;
            dgv[1, fila + 1].Value = swap;

            dgv.CurrentCell = dgv[1, fila + 1];
            dgv.BeginEdit(true);
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            int fila = 0;
            try
            {
                fila = dgv.CurrentRow.Index;
            }
            catch
            {
                return;
            }

            dgv.Rows.RemoveAt(fila);

            for (int i = fila; i < dgv.Rows.Count; i++)
                dgv[0, i].Value = i + 1;
        }
    }
}
