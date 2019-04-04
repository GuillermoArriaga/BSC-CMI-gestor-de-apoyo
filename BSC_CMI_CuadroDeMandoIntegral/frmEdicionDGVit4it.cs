using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BSC_CMI_CuadroDeMandoIntegral
{
    public partial class frmEdicionDGVit4it : Form
    {
        DataGridView dgvInicial;

        public frmEdicionDGVit4it(string descripcion, DataGridView dgvDado)
        {
            InitializeComponent();

            textBox0.Text = descripcion;
            dgvInicial = dgvDado;

            DataGridViewComboBoxColumn dgvCBcol = new DataGridViewComboBoxColumn();
            dgvCBcol.HeaderText = "Relacion con CMI";
            dgvCBcol.Items.AddRange(((DataGridViewComboBoxColumn)dgvInicial.Columns[2]).Items);
            dgvCBcol.DropDownWidth = 200;

            dgv.Columns.Add(dgvCBcol);

            for (int i = 0; i < dgvInicial.Rows.Count; i++)
            {
                dgv.Rows.Add(i + 1, dgvInicial[1, i].Value, dgvInicial[2, i].Value);
            }

            dgv.ReadOnly = false;
            dgv.Columns[1].ReadOnly = false;
            dgv.Columns[2].ReadOnly = false;
            dgv.ColumnHeadersVisible = true;

            // Eventos de cambio en ComboBox
            dgv.CellValueChanged += new DataGridViewCellEventHandler(dgv_CellValueChanged);
            dgv.CurrentCellDirtyStateChanged += new EventHandler(dgv_CurrentCellDirtyStateChanged);
        }

        public frmEdicionDGVit4it(string descripcion, DataGridView dgvDado, int fila)
        {
            InitializeComponent();

            textBox0.Text = descripcion;
            dgvInicial = dgvDado;

            DataGridViewComboBoxColumn dgvCBcol = new DataGridViewComboBoxColumn();
            dgvCBcol.HeaderText = "Relacion con CMI";
            dgvCBcol.Items.AddRange(((DataGridViewComboBoxColumn)dgvInicial.Columns[2]).Items);
            dgvCBcol.DropDownWidth = 200;

            dgv.Columns.Add(dgvCBcol);

            for (int i = 0; i < dgvInicial.Rows.Count; i++)
            {
                dgv.Rows.Add(i + 1, dgvInicial[1, i].Value, dgvInicial[2, i].Value);
            }

            dgv.ReadOnly = false;
            dgv.Columns[1].ReadOnly = false;
            dgv.Columns[2].ReadOnly = false;
            dgv.ColumnHeadersVisible = true;

            // Eventos de cambio en ComboBox
            dgv.CellValueChanged += new DataGridViewCellEventHandler(dgv_CellValueChanged);
            dgv.CurrentCellDirtyStateChanged += new EventHandler(dgv_CurrentCellDirtyStateChanged);

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
            // Revision de objetivos sin relacion a CMI
            List<int> filas = new List<int>();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv[2, i].Value is null)
                {
                    filas.Add(i + 1);
                }
                else if (dgv[2, i].Value.ToString() == "")
                {
                    filas.Add(i + 1);
                }
                else if (dgv[2, i].Value.ToString().Substring(0, 2) == "++")
                {
                    filas.Add(i + 1);
                }
            }

            if (filas.Count > 0)
            {
                string mensaje = "¿Desea elegir una relación con el CMI en\n";

                for (int i = 0; i < filas.Count; i++)
                {
                    mensaje += "\n\tobjetivo " + filas[i];
                }
                mensaje += "\n\npara que pueda(n) ser agregado(s) al CMI?";

                if (DialogResult.Yes == MessageBox.Show(mensaje, "Objetivo(s) sin relación con CMI", MessageBoxButtons.YesNo))
                {
                    return;
                }
            }

            // Paso a la plantilla de IT4IT
            dgv.ReadOnly = true;
            dgvInicial.Rows.Clear();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgvInicial.Rows.Add(i + 1, dgv[1, i].Value, dgv[2, i].Value);
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

        // Este manejador de evento provoca manualmente el evento dgv_CellValueChanged llamando al metodo CommitEdit. 
        void dgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv.IsCurrentCellDirty)
            {
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2)
                return;

            DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dgv.Rows[e.RowIndex].Cells[2];

            if (cb.Value == null)
            {
                MessageBox.Show("Seleccione una relación con el CMI en el\n\n\tobjetivo" + (e.RowIndex + 1) + "\n\npara que pueda ser agregado al CMI.");
            }
            else if (cb.Value.ToString() == "")
            {
                MessageBox.Show("Seleccione una relación con el CMI en el\n\n\tobjetivo" + (e.RowIndex + 1) + "\n\npara que pueda ser agregado al CMI.");
            }
            else if (cb.Value.ToString().Substring(0, 2) == "++")
            {
                dgv[2, e.RowIndex].Value = "";
                dgv.Invalidate();
                dgv.Update();
            }
        }
    }
}
