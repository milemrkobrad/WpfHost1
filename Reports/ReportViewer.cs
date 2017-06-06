using DevExpress.XtraPrinting.Preview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            var viewer = new DocumentViewer(); //using DevExpress.XtraPrinting.Preview
            viewer.Dock = DockStyle.Fill;
            panel2.Controls.Add(viewer);

            var report = new XtraReport1();
            viewer.DocumentSource = report;
            report.CreateDocument();
        }
    }
}
