using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ara_raporla
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("PROVIDER = MICROSOFT.JET.OLEDB.4.0; DATA SOURCE = bilgiler1.mdb");
        public string sadi;
        private void frmReport_Load(object sender, EventArgs e)
        {
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            if (bilgi.durum1 == true)
            {
                CrystalReport1 cr = new CrystalReport1();
                string komut = "SELECT * FROM TABLO1 where ADI='" + bilgi.isim + "' AND SOYADI = '" + bilgi.soyadi + "'";

                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(komut, baglanti);
                da.Fill(ds, "TABLO1");
                cr.SetDataSource(ds.Tables["TABLO1"]);
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
            }
            else
            {
                CrystalReport1 cr1 = new CrystalReport1();
                OleDbDataAdapter cmd = new OleDbDataAdapter ("SELECT * FROM TABLO1", baglanti);
                DataSet ds1 = new DataSet ();
                cmd.Fill(ds1,"TABLO1");
                cr1.SetDataSource(ds1.Tables["TABLO1"]);
                crystalReportViewer1.ReportSource = cr1;
                crystalReportViewer1.Refresh();
                
                
            }


        }
    }
}
