using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoEstadistica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //dgvEstadistica.ColumnCount = 8;
            //dgvEstadistica.Columns[0].HeaderText = "xi";
            //dgvEstadistica.Columns[1].HeaderText = "fi";
            //dgvEstadistica.Columns[2].HeaderText = "Fi";
            //dgvEstadistica.Columns[3].HeaderText = "hi";
            //dgvEstadistica.Columns[4].HeaderText = "x.f";
            //dgvEstadistica.Columns[5].HeaderText = "(x-X̄)";
            //dgvEstadistica.Columns[6].HeaderText = "(x-X̄)²";
            //dgvEstadistica.Columns[7].HeaderText = "(x-X̄)².f";            
            llenadoDGV();
        }
        DataTable DT = new DataTable();
        public void llenadoDGV()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("xi");
            dt.Columns.Add("fi");
            dt.Columns.Add("Fi");
            dt.Columns.Add("hi");
            dt.Columns.Add("x.f");
            dt.Columns.Add("(x-X̄)");
            dt.Columns.Add("(x-X̄)²");
            dt.Columns.Add("(x-X̄)².f");
            dgvEstadistica.DataSource = dt;
            DT = dt;
        }
        
        decimal numeroIngresado;
        int frecuencia;
        public List<int> FiLista = new List<int>();
        public List<decimal> xfLista = new List<decimal>();
        public decimal mediaActual;
        int Fi = 0;
        public void LlenarDGV()
        {
            //DataTable dt = new DataTable();
            if (dgvEstadistica.Rows.Count == 0) 
            {         
                //dt.Columns.Add("xi");
                //dt.Columns.Add("fi");
                //dt.Columns.Add("Fi");
                //dt.Columns.Add("hi");
                //dt.Columns.Add("x.f");
                //dt.Columns.Add("(x-X̄)");
                //dt.Columns.Add("(x-X̄)²");
                //dt.Columns.Add("(x-X̄)².f");
                //dgvEstadistica.DataSource = dt;
                decimal sumaxf = 0;
                
                decimal xf = numeroIngresado * frecuencia;           
                lblMedia.Visible = true;
                xfLista.Add(xf);
                //foreach (var item in FiLista)
                //{
                //    Fi = Fi + item;
                //}
                Fi = frecuencia;
                foreach (var item in xfLista)
                {
                    sumaxf = sumaxf + item;
                }
                decimal media = sumaxf/Fi;
                lblMedia.Text = media.ToString();
                DT.Rows.Add(numeroIngresado, frecuencia, Fi,
                Convert.ToDouble(Convert.ToDouble(frecuencia) / Convert.ToDouble(Fi)),
                xf,(numeroIngresado - media),
                (Math.Pow(Convert.ToDouble(numeroIngresado - media),2)),
                (Math.Pow(Convert.ToDouble(numeroIngresado - media), 2))*frecuencia);

                dgvEstadistica.DataSource = DT;
                mediaActual = media;
            }
            else
            {
                decimal sumaxf = 0;
                decimal xf = numeroIngresado * frecuencia;
                lblMedia.Visible = true;
                xfLista.Add(xf);
                //foreach (var item in FiLista)
                //{
                //    Fi = Fi + item;
                //}
                Fi = Fi + frecuencia;
                foreach (var item in xfLista)
                {
                    sumaxf = sumaxf + item;
                }
                decimal media = sumaxf / Fi;
                lblMedia.Text = media.ToString();

                DT.Rows.Add(numeroIngresado, frecuencia, Fi,
                Convert.ToDouble(Convert.ToDouble(frecuencia) / Convert.ToDouble(Fi)),
                xf, (numeroIngresado - media),
                (Math.Pow(Convert.ToDouble(numeroIngresado - media), 2)),
                (Math.Pow(Convert.ToDouble(numeroIngresado - media), 2)) * frecuencia);

                dgvEstadistica.DataSource = DT;
                mediaActual = media;

                foreach (DataRow row in DT.Rows)
                {
                    //DataGridViewRow currentRow = dgvEstadistica.CurrentRow;
                    //int filaActual = dgvEstadistica.CurrentRow.Index;
                    //decimal xiActual = Convert.ToDecimal(dgvEstadistica.Rows[filaActual].Cells[0].Value);
                    //decimal fiActual = Convert.ToDecimal(dgvEstadistica.Rows[filaActual].Cells[1].Value);
                    //decimal FiActual = Convert.ToDecimal(dgvEstadistica.Rows[filaActual].Cells[2].Value);
                    //decimal xfActual = Convert.ToDecimal(dgvEstadistica.Rows[filaActual].Cells[4].Value);


                    decimal xiActual = Convert.ToDecimal(row["xi"]);
                    decimal fiActual = Convert.ToDecimal(row["fi"]);
                    decimal FiActual = Convert.ToDecimal(row["Fi"]);
                    decimal xfActual = Convert.ToDecimal(row["x.f"]);

                    row["xi"] = xiActual;
                    row["fi"] = fiActual;
                    row["Fi"] = FiActual;
                    row["hi"] = (Convert.ToDouble(fiActual) / Convert.ToDouble(Fi));
                    row["x.f"] = xfActual;
                    row["(x-X̄)"] = (xiActual - mediaActual);
                    row["(x-X̄)²"] = (Math.Pow(Convert.ToDouble(xiActual - mediaActual), 2));
                    row["(x-X̄)².f"] = (Convert.ToDecimal(Math.Pow(Convert.ToDouble(xiActual - mediaActual), 2)) * fiActual);
                    dgvEstadistica.DataSource = DT;
                    //ds = dgvEstadistica.Rows.Add(xiActual, fiActual, FiActual,
                    //(Convert.ToDouble(fiActual) / Convert.ToDouble(FiActual)), xfActual,
                    //(xiActual - mediaActual),
                    //(Math.Pow(Convert.ToDouble(xiActual - mediaActual), 2),
                    //(Convert.ToDecimal(Math.Pow(Convert.ToDouble(xiActual - mediaActual), 2)) * fiActual)));                    
                }
            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            numeroIngresado = nmNroIngresado.Value;
            frecuencia = Convert.ToInt32(nmFrecuencia.Value);
            FiLista.Add(frecuencia);
            
            LlenarDGV();
        }
    }
}
