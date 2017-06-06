using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace WpfHost1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Reports.ReportViewer reportViewer = new Reports.ReportViewer();
            reportViewer.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var wpfwindow = new WpfApp.MainWindow();
            //wpfwindow.bla = new Reports.XtraReport1();
            ElementHost.EnableModelessKeyboardInterop(wpfwindow);
            wpfwindow.Show();
        }
    }
}
