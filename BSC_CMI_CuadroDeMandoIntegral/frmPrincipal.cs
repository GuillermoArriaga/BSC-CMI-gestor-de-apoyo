using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;    // MS Access 2002-3 .mdb

namespace BSC_CMI_CuadroDeMandoIntegral
{
    public partial class frmPrincipal : Form
    {
        List<DataGridView> dgvCMI, dgvIT4IT;
        List<TextBox> tbCMI, tbIT4IT;
        List<Button> btCMI, btIT4IT;
        List<GroupBox> gbIT4IT;
        bool elementosCargados;
        string[] encabezadosCMI, encabezadosIT4IT;

        public frmPrincipal()
        {
            elementosCargados = false;
            InitializeComponent();
            elementosCargados = true;

            dgvCMI = new List<DataGridView>();
            dgvCMI.Add(dataGridView0);
            dgvCMI.Add(dataGridView1);
            dgvCMI.Add(dataGridView2);
            dgvCMI.Add(dataGridView3);
            dgvCMI.Add(dataGridView4);
            dgvCMI.Add(dataGridView5);
            dgvCMI.Add(dataGridView6);
            dgvCMI.Add(dataGridView7);
            dgvCMI.Add(dataGridView8);
            dgvCMI.Add(dataGridView9);
            dgvCMI.Add(dataGridView10);
            dgvCMI.Add(dataGridView11);

            dgvIT4IT = new List<DataGridView>();
            dgvIT4IT.Add(dataGridView12);
            dgvIT4IT.Add(dataGridView13);
            dgvIT4IT.Add(dataGridView14);
            dgvIT4IT.Add(dataGridView15);
            dgvIT4IT.Add(dataGridView16);
            dgvIT4IT.Add(dataGridView17);
            dgvIT4IT.Add(dataGridView18);
            dgvIT4IT.Add(dataGridView19);
            dgvIT4IT.Add(dataGridView20);
            dgvIT4IT.Add(dataGridView21);
            dgvIT4IT.Add(dataGridView22);
            dgvIT4IT.Add(dataGridView23);
            dgvIT4IT.Add(dataGridView24);
            dgvIT4IT.Add(dataGridView25);
            dgvIT4IT.Add(dataGridView26);
            dgvIT4IT.Add(dataGridView27);

            tbCMI = new List<TextBox>();
            tbCMI.Add(textBox0);
            tbCMI.Add(textBox1);
            tbCMI.Add(textBox2);
            tbCMI.Add(textBox3);
            tbCMI.Add(textBox4);
            tbCMI.Add(textBox5);
            tbCMI.Add(textBox6);
            tbCMI.Add(textBox7);
            tbCMI.Add(textBox8);
            tbCMI.Add(textBox9);
            tbCMI.Add(textBox10);
            tbCMI.Add(textBox11);

            tbIT4IT = new List<TextBox>();
            tbIT4IT.Add(textBox12);
            tbIT4IT.Add(textBox13);
            tbIT4IT.Add(textBox14);
            tbIT4IT.Add(textBox15);
            tbIT4IT.Add(textBox16);
            tbIT4IT.Add(textBox17);
            tbIT4IT.Add(textBox18);
            tbIT4IT.Add(textBox19);
            tbIT4IT.Add(textBox20);
            tbIT4IT.Add(textBox21);
            tbIT4IT.Add(textBox22);
            tbIT4IT.Add(textBox23);
            tbIT4IT.Add(textBox24);
            tbIT4IT.Add(textBox25);
            tbIT4IT.Add(textBox26);
            tbIT4IT.Add(textBox27);

            btCMI = new List<Button>();
            btCMI.Add(button0);
            btCMI.Add(button1);
            btCMI.Add(button2);
            btCMI.Add(button3);
            btCMI.Add(button4);
            btCMI.Add(button5);
            btCMI.Add(button6);
            btCMI.Add(button7);
            btCMI.Add(button8);
            btCMI.Add(button9);
            btCMI.Add(button10);
            btCMI.Add(button11);

            btIT4IT = new List<Button>();
            btIT4IT.Add(button12);
            btIT4IT.Add(button13);
            btIT4IT.Add(button14);
            btIT4IT.Add(button15);
            btIT4IT.Add(button16);
            btIT4IT.Add(button17);
            btIT4IT.Add(button18);
            btIT4IT.Add(button19);
            btIT4IT.Add(button20);
            btIT4IT.Add(button21);
            btIT4IT.Add(button22);
            btIT4IT.Add(button23);
            btIT4IT.Add(button24);
            btIT4IT.Add(button25);
            btIT4IT.Add(button26);
            btIT4IT.Add(button27);

            gbIT4IT = new List<GroupBox>();
            gbIT4IT.Add(groupBox12);
            gbIT4IT.Add(groupBox13);
            gbIT4IT.Add(groupBox14);
            gbIT4IT.Add(groupBox15);
            gbIT4IT.Add(groupBox16);
            gbIT4IT.Add(groupBox17);
            gbIT4IT.Add(groupBox18);
            gbIT4IT.Add(groupBox19);
            gbIT4IT.Add(groupBox20);
            gbIT4IT.Add(groupBox21);
            gbIT4IT.Add(groupBox22);
            gbIT4IT.Add(groupBox23);
            gbIT4IT.Add(groupBox24);
            gbIT4IT.Add(groupBox25);
            gbIT4IT.Add(groupBox26);
            gbIT4IT.Add(groupBox27);

            foreach (var dgv in dgvCMI)
            {
                dgv.Columns[0].MinimumWidth = 7;
                dgv.Columns[0].Width = 7;
            }

            foreach (var dgv in dgvIT4IT)
            {
                dgv.Columns[0].MinimumWidth = 7;
                dgv.Columns[0].Width = 7;
            }

            encabezadosCMI = new string[]
            {
                "Estrategia Digital",
                "Análisis Estratégico",
                "Evaluación Externa",
                "Innovación Tecnológica",
                "Innovación de Procesos",
                "Aliados",
                "Producto de Valor",
                "Mercado",
                "Evaluación de Procesos",
                "Evaluación Tecnológica",
                "Sistemas de Información",
                "Tecnologías de Información"
            };

            encabezadosIT4IT = new string[] 
            {
                "S2P 1 Estrategia",
                "S2P 2 Cartera de Servicios",
                "S2P 3 Demanda",
                "S2P 4 Selección",
                "R2D 1 Plan y Diseño",
                "R2D 2 Desarrollo",
                "R2D 3 Prueba",
                "R2D 4 Implementación",
                "R2F 1 Publicación",
                "R2F 2 Suscripción",
                "R2F 3 Cumplimiento",
                "R2F 4 Medición",
                "D2C 1 Detección",
                "D2C 2 Diagnóstico",
                "D2C 3 Cambio",
                "D2C 4 Resolución"
            };

            for (int i = 0; i < encabezadosCMI.Length; i++)
            {
                tbCMI[i].Text = encabezadosCMI[i];
            }

            for (int i = 0; i < encabezadosIT4IT.Length; i++)
            {
                tbIT4IT[i].Text = encabezadosIT4IT[i];
            }

            for (int i = 0; i < dgvIT4IT.Count; i++)
            {
                DataGridViewComboBoxColumn dgvCBcol = new DataGridViewComboBoxColumn();
                dgvCBcol.HeaderText = "Relacion con CMI";
                dgvCBcol.Visible = true;
                dgvCBcol.ReadOnly = true;

                dgvCBcol.Items.Add("++ Zonas del CMI sugeridas:");
                switch (i)
                {
                    /*
                    0"Estrategia Digital",
                    1"Análisis Estratégico",
                    2"Evaluación Externa",
                    3"Innovación Tecnologica",
                    4"Innovación de Procesos",
                    5"Aliados",
                    6"Producto de Valor",
                    7"Mercado",
                    8"Evaluación de Procesos",
                    9"Evaluación Tecnológica",
                    10"Sistemas de Información",
                    11"Tecnologías de Información"
                     */
                    case 0: //"S2P 1 Estrategia",
                        dgvCBcol.Items.Add(encabezadosCMI[0]);
                        dgvCBcol.Items.Add(encabezadosCMI[1]);
                        break;
                    case 1: //"S2P 2 Cartera de Servicios",
                        dgvCBcol.Items.Add(encabezadosCMI[0]);
                        break;
                    case 2: //"S2P 3 Demanda",
                        dgvCBcol.Items.Add(encabezadosCMI[1]);
                        break;
                    case 3: //"S2P 4 Seleccion",
                        dgvCBcol.Items.Add(encabezadosCMI[1]);
                        dgvCBcol.Items.Add(encabezadosCMI[4]);
                        break;
                    case 4: //"R2D 1 Plan y Diseño",
                        dgvCBcol.Items.Add(encabezadosCMI[3]);
                        dgvCBcol.Items.Add(encabezadosCMI[4]);
                        break;
                    case 5: //"R2D 2 Desarrollo",
                        dgvCBcol.Items.Add(encabezadosCMI[10]);
                        dgvCBcol.Items.Add(encabezadosCMI[11]);
                        break;
                    case 6: //"R2D 3 Prueba",
                        dgvCBcol.Items.Add(encabezadosCMI[8]);
                        dgvCBcol.Items.Add(encabezadosCMI[9]);
                        break;
                    case 7: //"R2D 4 Implementación",
                        dgvCBcol.Items.Add(encabezadosCMI[10]);
                        dgvCBcol.Items.Add(encabezadosCMI[11]);
                        dgvCBcol.Items.Add(encabezadosCMI[8]);
                        break;
                    case 8: //"R2F 1 Publicación",
                        dgvCBcol.Items.Add(encabezadosCMI[6]);
                        dgvCBcol.Items.Add(encabezadosCMI[5]);
                        dgvCBcol.Items.Add(encabezadosCMI[7]);
                        dgvCBcol.Items.Add(encabezadosCMI[10]);
                        dgvCBcol.Items.Add(encabezadosCMI[11]);
                        break;
                    case 9: //"R2F 2 Suscripción",
                        dgvCBcol.Items.Add(encabezadosCMI[10]);
                        dgvCBcol.Items.Add(encabezadosCMI[11]);
                        break;
                    case 10: //"R2F 3 Cumplimiento",
                        dgvCBcol.Items.Add(encabezadosCMI[10]);
                        dgvCBcol.Items.Add(encabezadosCMI[11]);
                        break;
                    case 11: //"R2F 4 Medición",
                        dgvCBcol.Items.Add(encabezadosCMI[2]);
                        dgvCBcol.Items.Add(encabezadosCMI[8]);
                        dgvCBcol.Items.Add(encabezadosCMI[7]);
                        break;
                    case 12: //"D2C 1 Detección",
                        dgvCBcol.Items.Add(encabezadosCMI[8]);
                        dgvCBcol.Items.Add(encabezadosCMI[9]);
                        break;
                    case 13: //"D2C 2 Diagnóstico",
                        dgvCBcol.Items.Add(encabezadosCMI[8]);
                        dgvCBcol.Items.Add(encabezadosCMI[9]);
                        break;
                    case 14: //"D2C 3 Cambio",
                        dgvCBcol.Items.Add(encabezadosCMI[3]);
                        dgvCBcol.Items.Add(encabezadosCMI[4]);
                        break;
                    case 15: //"D2C 4 Resolución"
                        dgvCBcol.Items.Add(encabezadosCMI[10]);
                        dgvCBcol.Items.Add(encabezadosCMI[11]);
                        dgvCBcol.Items.Add(encabezadosCMI[8]);
                        dgvCBcol.Items.Add(encabezadosCMI[9]);
                        break;
                }

                dgvCBcol.Items.Add("++ Todas las zonas del CMI:");
                dgvCBcol.Items.AddRange(encabezadosCMI);
                dgvIT4IT[i].Columns.Add(dgvCBcol);
            }
            ajustarTamanoCMI();
            ajustarTamanoIT4IT();
        }

        public void ajustarTamanoCMI()
        {
            int x = (tabControl1.Size.Width - 8) / 8;
            int y = (tabControl1.Size.Height - 24) / 6;

            // Estrategia Digital
            groupBox0.Location = new Point(0, 0);
            groupBox0.Size = new Size(5 * x, y);
            // Analisis Estrategico
            groupBox1.Location = new Point(5 * x, 0);
            groupBox1.Size = new Size(2 * x, y);
            // Evaluacion Externa
            groupBox2.Location = new Point(7 * x, 0);
            groupBox2.Size = new Size(x, 6 * y);
            // Innovacion Tecnologica
            groupBox3.Location = new Point(0, y);
            groupBox3.Size = new Size(x, 4 * y);
            // Innovacion de Procesos
            groupBox4.Location = new Point(x, y);
            groupBox4.Size = new Size(x, 3 * y);
            // Aliados
            groupBox5.Location = new Point(2 * x, y);
            groupBox5.Size = new Size(x, 3 * y);
            // Producto de Valor
            groupBox6.Location = new Point(3 * x, y);
            groupBox6.Size = new Size(x, 3 * y);
            // Mercado
            groupBox7.Location = new Point(4 * x, y);
            groupBox7.Size = new Size(x, 3 * y);
            // Evaluacion de Procesos
            groupBox8.Location = new Point(5 * x, y);
            groupBox8.Size = new Size(x, 3 * y);
            // Evaluacion Tecnologica
            groupBox9.Location = new Point(6 * x, y);
            groupBox9.Size = new Size(x, 4 * y);
            // Sistemas de Informacion
            groupBox10.Location = new Point(x, 4 * y);
            groupBox10.Size = new Size(5 * x, y);
            // Tecnologias de Informacion
            groupBox11.Location = new Point(0, 5 * y);
            groupBox11.Size = new Size(7 * x, y);

            foreach (var dgv in dgvCMI)
            {
                dgv.Columns[0].MinimumWidth = 20;
                dgv.Columns[0].Width = 20;
                dgv.AllowUserToResizeColumns = true;
            }

            foreach (var dgv in dgvIT4IT)
            {
                dgv.Columns[0].MinimumWidth = 20;
                dgv.Columns[0].Width = 20;
                dgv.AllowUserToResizeColumns = true;
            }
        }

        public void ajustarTamanoIT4IT()
        {
            int x = (tabControl1.Size.Width - 8) / 4;
            int y = (tabControl1.Size.Height - 24) / 4;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    gbIT4IT[i * 4 + j].Location = new Point(x * j, y * i);
                    gbIT4IT[i * 4 + j].Size = new Size(x, y);
                }
            }
        }

        private void tabControl1_Resize(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                ajustarTamanoCMI();
            }

            if (tabControl1.SelectedIndex == 4)
            {
                ajustarTamanoIT4IT();
            }
        }

        private void groupBox_Resize(object sender, EventArgs e)
        {
            if (!elementosCargados)
            {
                return;
            }

            GroupBox gb = (GroupBox)sender;
            int id = Convert.ToInt32(gb.Tag);
            int medida = tbCMI[id].Height;
            btCMI[id].Size = new Size(medida, medida);
            btCMI[id].Location = new Point(gb.Size.Width - medida, 0);
            tbCMI[id].Location = new Point(0, 0);
            tbCMI[id].Width = gb.Size.Width - btCMI[id].Width;
            dgvCMI[id].Location = new Point(0, medida);
            dgvCMI[id].Size = new Size(gb.Size.Width , gb.Size.Height - medida);
        }

        private void groupBoxIT4IT_Resize(object sender, EventArgs e)
        {
            if (!elementosCargados)
            {
                return;
            }

            GroupBox gb = (GroupBox)sender;
            int id = Convert.ToInt32(gb.Tag);
            int medida = tbIT4IT[id].Height;
            btIT4IT[id].Size = new Size(medida, medida);
            btIT4IT[id].Location = new Point(gb.Size.Width - medida, 0);
            tbIT4IT[id].Location = new Point(0, 0);
            tbIT4IT[id].Width = gb.Size.Width - btIT4IT[id].Width;
            dgvIT4IT[id].Location = new Point(0, medida);
            dgvIT4IT[id].Size = new Size(gb.Size.Width, gb.Size.Height - medida);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            ajustarTamanoCMI();
            ajustarTamanoIT4IT();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCMI.Count; i++)
            {
                dgvCMI[i].Rows.Clear();
            }

            for (int i = 0; i < dgvIT4IT.Count; i++)
            {
                dgvIT4IT[i].Rows.Clear();
            }

            tabControl1.SelectedIndex = 1;
            ajustarTamanoCMI();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos de MS Access (.mdb)|*.mdb";
            saveFileDialog1.FileName = "CMI_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            saveFileDialog1.DefaultExt = ".mdb";
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.File.WriteAllBytes(saveFileDialog1.FileName, Properties.Resources.bdtemporal);
            string cc = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data source = " + saveFileDialog1.FileName;
            OleDbConnection cn = new OleDbConnection(cc);
            
            cn.Open();
            int k = 0, i = 0;
            try
            {
                for (k = 0; k < encabezadosCMI.Length; k++)
                {
                    for (i = 0; i < dgvCMI[k].Rows.Count; i++)
                    {
                        string objetivo = "";
                        if (dgvCMI[k][1, i].Value != null)
                        {
                            objetivo = dgvCMI[k][1, i].Value.ToString();
                        }

                        string sql = string.Format("INSERT INTO CMI (tabla, objetivo) values('{0}', '{1}')", encabezadosCMI[k], objetivo);
                        OleDbCommand comando = new OleDbCommand(sql, cn);
                        int renglones = comando.ExecuteNonQuery();
                        /*
                        if (renglones > 0)
                            MessageBox.Show(" Datos almacenados");
                        else
                            MessageBox.Show(" Los datos no han sido almacenados ");
                        */
                    }
                }
                cn.Close();
            }
            catch(Exception ex)
            {
                string objetivo = "";
                if (dgvCMI[k][1, i].Value != null)
                {
                    objetivo = dgvCMI[k][1, i].Value.ToString();
                }

                MessageBox.Show("Hay un caracter inválido en el objetivo " + (i + 1) + " : " + objetivo + "  que está en la zona: " + encabezadosCMI[k] + "\n\n" + ex.Message, "No se ha guardado",MessageBoxButtons.OK);
                cn.Close();

                if (System.IO.File.Exists(saveFileDialog1.FileName))
                {
                    System.IO.File.Delete(saveFileDialog1.FileName);
                }
            }
        }
        private void btAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de MS Access (.mdb)|*.mdb";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string cc = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data source = " + saveFileDialog1.FileName;
                OleDbConnection cn = new OleDbConnection(cc);

                for (int k = 0; k < encabezadosCMI.Length; k++)
                {
                    cn.Open();
                    string sql = "SELECT objetivo FROM CMI WHERE tabla = '" + encabezadosCMI[k] + "'";
                    OleDbDataAdapter comando = new OleDbDataAdapter(sql, cn);
                    DataTable datos = new DataTable();
                    comando.Fill(datos);
                    cn.Close();

                    dgvCMI[k].Rows.Clear();
                    for (int i = 0; i < datos.Rows.Count; i++)
                    {
                        dgvCMI[k].Rows.Add(i + 1, datos.Rows[i]["objetivo"]);
                    }
                }

                tabControl1.SelectedIndex = 1;
                ajustarTamanoCMI();
            }
            catch
            {
                MessageBox.Show("La base de datos elegida no sigue el formato esperado.\n\nGenerela o modifiquela por medio de este programa para garantizar su funcionalidad.");
            }
        }

        private void buttonCMI_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((Button) sender).Tag);
            (new frmEdicionDGVcmi(encabezadosCMI[id], dgvCMI[id])).Show();
        }

        private void buttonIT4IT_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((Button)sender).Tag);
            (new frmEdicionDGVit4it(encabezadosIT4IT[id], dgvIT4IT[id])).Show();
        }

        private void dgvCMI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(((DataGridView)sender).Tag);
            (new frmEdicionDGVcmi(encabezadosCMI[id], dgvCMI[id], e.RowIndex)).Show();
        }

        private void dgvIT4IT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(((DataGridView)sender).Tag);
            (new frmEdicionDGVit4it(encabezadosIT4IT[id], dgvIT4IT[id], e.RowIndex)).Show();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            rtbImpresion.Text = "   ===   Cuadro de Mando Integral   ===   \n\n   " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + "\n\n";
            for (int k = 0; k < encabezadosCMI.Length; k++)
            {
                rtbImpresion.AppendText("\n" + encabezadosCMI[k] + "\n");
                for (int i = 0; i < dgvCMI[k].Rows.Count; i++)
                {
                    rtbImpresion.AppendText("   " + (i+1) + ".- " + dgvCMI[k][1, i].Value + "\n");
                }
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            string archivo = Application.StartupPath + "\\impresion.rtf";
            try
            {
                if (System.IO.File.Exists(archivo))
                {
                    System.IO.File.Delete(archivo);
                }
                rtbImpresion.SaveFile(archivo);
                System.Diagnostics.Process.Start(archivo);
            }
            catch
            {
                MessageBox.Show("Cierre el archivo:\n\n" + archivo + "\n\npara poder guardarlo con otro nombre o imprimirlo.");
            }
        }

        private void gbS2P_Enter(object sender, EventArgs e)
        {
            rtbDesFlujo.Text = "Strategy to (Service) Portfolio" + "\n\n" +
                "Conduce la cartera de servicios a la innovación del negocio." + "\n" +
                "Indica la estrategia para equilibrar y negociar su cartera de servicios." + "\n" +
                "Brinda un punto de vista unificado a través de la gestión de proyectos(PMO), arquitectura empresarial y la cartera de servicios" + "\n" +
                "Mejora la calidad de los datos para la toma de decisiones." + "\n" +
                "Proporciona indicadores clave de rendimiento (KPIs) y mapas para mejorar la comunicación empresarial.";
        }

        private void gbR2D_Enter(object sender, EventArgs e)
        {
            rtbDesFlujo.Text = "Requirement to Deploy (Activities)" + "\n\n" +
                "Construye lo que el negocio requiere y cuando lo requiere." + "\n" +
                "Proporciona un marco para crear, modificar o contratar un servicio." + "\n" +
                "Permite visibilidad de la calidad, la utilidad, el cronograma y el costo de los servicios que presta." + "\n" +
                "Apoya metodologías de desarrollo ágil y tradicional." + "\n" +
                "Define puntos de control de integración y despliegue continuo.";
        }

        private void gbR2F_Enter(object sender, EventArgs e)
        {
            rtbDesFlujo.Text = "Requirement to Fulfill (Activities)" + "\n\n" +
                "Cataloga, completa y gestiona el uso de servicios." + "\n" +
                "Gestiona y mide los cumplimientos a través de múltiples proveedores." + "\n" +
                "Gestiona eficientemente las suscripciones y el costo total del servicio." + "\n" +
                "Presenta un único catálogo con artículos de múltiples catálogos de proveedores." + "\n" +
                "Ayuda a la transición de su organización de TI a un modelo de agente de servicios.";
        }

        private void gbD2C_Enter(object sender, EventArgs e)
        {
            rtbDesFlujo.Text = "" + "\n\n" +
                "Anticipa y resuelve problemas de producción." + "\n" +
                "Reúne las operaciones de servicios de TI para mejorar los resultados y la eficiencia." + "\n" +
                "Permite la visibilidad de extremo a extremo utilizando un modelo de configuración compartido." + "\n" +
                "Identifica los problemas antes de que afecten a los usuarios." + "\n" +
                "Reduce el tiempo medio de reparación.";
        }

        private void gbS2P_Leave(object sender, EventArgs e)
        {
            rtbDesFlujo.Text = "";
        }

        private void btS2P01Estrategia_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "S2P 1 Estrategia" + "\n\n" +
                "Definición de objetivos." + "\n" +
                "Alineación entre mapas de conectividad de TI y el negocio." + "\n" +
                "Preparación de estándares y políticas." + "\n";
        }

        private void btS2P02Cartera_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "S2P 2 Cartera de Servicios" + "\n\n" +
                "Relación con la arquitectura empresarial." + "\n" +
                "Reconversión de la cartera de servicios." + "\n" +
                "Creación del proyecto original y del mapa de conectividad de TI." + "\n";
        }

        private void btS2P03Demanda_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "S2P 3 Demanda" + "\n\n" +
                "Consolidación de la demanda." + "\n" +
                "Análisis de prioridad, urgencia e impacto." + "\n" +
                "Creación de nueva demanda o etiquetación de la existente." + "\n";
        }

        private void btS2P04Seleccion_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "S2P 4 Selección" + "\n\n" +
                "Según el valor para el negocio, riesgos, costos, beneficios y recursos." + "\n" +
                "Análisis de posibilidades o cambios de escenarios." + "\n" +
                "Aseguramiento del gobierno." + "\n";
        }

        private void btR2D01PlanDiseno_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "R2D 1 Plan y Diseño" + "\n\n" +
                "Plan de proyecto de TI." + "\n" +
                "Modelo lógico del servicio." + "\n" +
                "Requerimientos funcionales y técnicos" + "\n" +
                "Estándares y políticas" + "\n";
        }

        private void btR2D02Desarrollo_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "R2D 2 Desarrollo" + "\n\n" +
                "Desarrollo ágil, iterativo, en cascada." + "\n" +
                "Fuente y configuración del entorno." + "\n" +
                "Control de las versiones" + "\n" +
                "Pruebas parciales durante el desarrollo." + "\n";
        }

        private void btR2D03Prueba_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "R2D 3 Prueba" + "\n\n" +
                "Funcionalidad para PDAs, escritorio o web." + "\n" +
                "Desempeño para PDAs, escritorio o web." + "\n" +
                "Seguridad estática o dinámica." + "\n";
        }

        private void btR2D04Implementacion_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "R2D 4 Implementación" + "\n\n" +
                "Lanzamiento del plan." + "\n" +
                "Cambio y configuración de procesos." + "\n" +
                "Gestión del conocimiento." + "\n" +
                "Monitoreo de aplicaciones y seguridad." + "\n";
        }

        private void btR2F01Publicacion_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "R2F 1 Publicación" + "\n\n" +
                "Correlación entre catálogo y motores de cumplimiento." + "\n" +
                "Fijar precio, opciones y acuerdos con cliente (SLA)s." + "\n" +
                "Publicar servicios." + "\n";
        }

        private void btR2F02Suscripcion_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "R2F 2 Suscripción" + "\n\n" +
                "Gestión del portal de compromiso." + "\n" +
                "Personalización de experiencia." + "\n" +
                "Opción de autoservicio." + "\n" +
                "Gestión de subscripciones." + "\n";
        }

        private void btR2F03Cumplimiento_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "R2F 3 Cumplimiento" + "\n\n" +
                "Ruta de cumplimiento." + "\n" +
                "Automatización de la implementación." + "\n" +
                "Uso de proveedores internos y externos." + "\n" +
                "Integración a cambios, activos y configuración de sistemas." + "\n";
        }

        private void btR2F04Medicion_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "R2F 4 Medición" + "\n\n" +
                "Medición del uso de servicio." + "\n" +
                "Medición de devoluciones." + "\n" +
                "Transparencia de costo." + "\n" +
                "Encuestas y puntajes." + "\n";
        }

        private void btAgregarIT4ITaCMI_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvIT4IT.Count; i++)
            {
                for (int j = 0; j < dgvIT4IT[i].Rows.Count; j++)
                {
                    if (dgvIT4IT[i][2, j].Value == null)
                    {
                        continue;
                    }
                    for (int k = 0; k < encabezadosCMI.Length; k++)
                    {
                        if (encabezadosCMI[k] == dgvIT4IT[i][2, j].Value.ToString())
                        {
                            if (dgvIT4IT[i][1, j].Value is null)
                            {
                                dgvIT4IT[i][1, j].Value = "";
                            }

                            string objetivo = dgvIT4IT[i][1, j].Value.ToString();
                            bool repetido = false;
                            // Evitar repetidos
                            for (int l = 0; l < dgvCMI[k].Rows.Count; l++)
                            {
                                if (dgvCMI[k][1, l].Value is null)
                                {
                                    continue;
                                }

                                if (objetivo == dgvCMI[k][1, l].Value.ToString())
                                {
                                    repetido = true;
                                }
                            }
                            if (!repetido)
                            {
                                dgvCMI[k].Rows.Add(dgvCMI[k].Rows.Count + 1, objetivo);
                            }
                            break;
                        }
                    }
                }
            }

            tabControl1.SelectedIndex = 1;
            ajustarTamanoCMI();
        }

        private void btD2C01Deteccion_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "D2C 1 Detección" + "\n\n" +
                "Ver eventos, alarmas y métricas a través de la infraestructura completa." + "\n" +
                "Comprender problemas del usuario." + "\n" +
                "Trazar la relación entre eventos." + "\n";
        }

        private void btD2C02Diagnostico_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "D2C 2 Diagnóstico" + "\n\n" +
                "Factores agravantes." + "\n" +
                "Causa raíz." + "\n" +
                "Severidad e impacto en el negocio." + "\n" +
                "Definición de ruta de escalación." + "\n" +
                "Solución automática a problemas similares." + "\n";
        }

        private void btD2C03Cambio_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "D2C 3 Cambio" + "\n\n" +
                "Definición de la solicitud de cambio." + "\n" +
                "Representación del problema y su análisis." + "\n" +
                "Aprobación." + "\n";
        }

        private void btD2C04Resolucion_Click(object sender, EventArgs e)
        {
            rtbDesIntegrante.Text = "D2C 4 Resolución" + "\n\n" +
                "Implementación de cambio." + "\n" +
                "Apoyarse en libros sobre solución de contingencias en infraestructura tecnológica." + "\n" +
                "Verificar recuperación." + "\n" +
                "Registrar." + "\n";
        }
    }
}
