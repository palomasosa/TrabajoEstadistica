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
            llenadoDGV();
        }
        DataTable DT = new DataTable();
        public void llenadoDGV()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("xi");
            dt.Columns.Add("fi");
            dt.Columns.Add("FAcumulada");
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
        public decimal mediaActual;
        int Fi = 0;
        decimal xfAcumulada = 0;

        double varianza;
        double desviacionMedia;
        double desviacionEstandar;
        double coeficiente;
        public void LlenarDGV()
        {
            if (dgvEstadistica.Rows.Count == 0) 
            {         
                decimal sumaxf = 0;
                
                decimal xf = numeroIngresado * frecuencia;           
                lblMedia.Visible = true;
                Fi = frecuencia;
                xfAcumulada = xf;
                decimal media = sumaxf/Fi;
                //lblMedia.Text = media.ToString();
                DT.Rows.Add(numeroIngresado, frecuencia, Fi,
                Convert.ToDouble(Convert.ToDouble(frecuencia) / Convert.ToDouble(Fi)),
                xf,(numeroIngresado - media),
                (Math.Pow(Convert.ToDouble(numeroIngresado - media),2)),
                (Math.Pow(Convert.ToDouble(numeroIngresado - media), 2))*frecuencia);
                
                dgvEstadistica.DataSource = DT;
                mediaActual = media;

                varianza = ((Math.Pow(Convert.ToDouble(numeroIngresado - media), 2)) * frecuencia) / Fi ;
                desviacionEstandar = Math.Sqrt(varianza);
                coeficiente = desviacionEstandar/Convert.ToDouble(media);
                desviacionMedia = Convert.ToDouble((numeroIngresado - media) / Fi);

                lblMedia.Visible = true;
                lblDesviacionEstandar.Visible = true;
                lblDesviacionTipica.Visible = true;
                lblVarianza.Visible = true;
                lblCoeficiente.Visible = true;

                lblMedia.Text = $"La media es de {media}";
                lblDesviacionEstandar.Text = $"La desviacion estándar es de {desviacionEstandar}";
                lblDesviacionTipica.Text = $"La desviacion media es de {desviacionMedia}";
                lblVarianza.Text = $"La varianza es de {varianza}";
                lblCoeficiente.Text = $"El coeficiente de variación es de {coeficiente}";
            }
            else
            {
                decimal xf = numeroIngresado * frecuencia;
                lblMedia.Visible = true;
                Fi = Fi + frecuencia;
                xfAcumulada = xfAcumulada + xf;
                decimal media = xfAcumulada / Fi;
                lblMedia.Text = media.ToString();

                DT.Rows.Add(numeroIngresado, frecuencia, Fi,
                Convert.ToDouble(Convert.ToDouble(frecuencia) / Convert.ToDouble(Fi)),
                xf, (numeroIngresado - media),
                (Math.Pow(Convert.ToDouble(numeroIngresado - media), 2)),
                (Math.Pow(Convert.ToDouble(numeroIngresado - media), 2)) * frecuencia);

                dgvEstadistica.DataSource = DT;
                mediaActual = media;


                varianza = ((Math.Pow(Convert.ToDouble(numeroIngresado - media), 2)) * frecuencia) / Fi;
                desviacionEstandar = Math.Sqrt(varianza);
                coeficiente = desviacionEstandar / Convert.ToDouble(media);
                desviacionMedia = Convert.ToDouble((numeroIngresado - media) / Fi);

                lblMedia.Text = $"La media es de {media}";
                lblDesviacionEstandar.Text = $"La desviacion estándar es de {desviacionEstandar}";
                lblDesviacionTipica.Text = $"La desviacion media es de {desviacionMedia}";
                lblVarianza.Text = $"La varianza es de {varianza}";
                lblCoeficiente.Text = $"El coeficiente de variación es de {coeficiente}";


                foreach (DataRow row in DT.Rows)
                {
                    decimal xiActual = Convert.ToDecimal(row["xi"]);
                    decimal fiActual = Convert.ToDecimal(row["fi"]);
                    decimal FiActual = Convert.ToDecimal(row["FAcumulada"]);
                    decimal xfActual = Convert.ToDecimal(row["x.f"]);

                    row["xi"] = xiActual;
                    row["fi"] = fiActual;
                    row["FAcumulada"] = FiActual;
                    row["hi"] = (Convert.ToDouble(fiActual) / Convert.ToDouble(Fi));
                    row["x.f"] = xfActual;
                    row["(x-X̄)"] = (xiActual - mediaActual);
                    row["(x-X̄)²"] = (Math.Pow(Convert.ToDouble(xiActual - mediaActual), 2));
                    row["(x-X̄)².f"] = (Convert.ToDecimal(Math.Pow(Convert.ToDouble(xiActual - mediaActual), 2)) * fiActual);
                    dgvEstadistica.DataSource = DT;               
                }
            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            numeroIngresado = nmNroIngresado.Value;
            frecuencia = Convert.ToInt32(nmFrecuencia.Value);
            
            LlenarDGV();
            nmNroIngresado.Value = default;
            nmFrecuencia.Value = default;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DT.Rows.Clear();
            dgvEstadistica.DataSource = DT;
            lblMedia.Visible = false;
            lblDesviacionEstandar.Visible = false;
            lblDesviacionTipica.Visible = false;
            lblVarianza.Visible = false;
            lblCoeficiente.Visible = false;
        }
    }
}
