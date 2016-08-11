using System;
using System.Windows.Forms;

namespace TrafficWebScrape.Display
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadTrafficData();
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            loadTrafficData();
        }
        private void loadTrafficData()
        {
            dgvTraffic.Rows.Clear();
            Traffic.Traffic traffic = new Traffic.Traffic();

            traffic.Process();

            traffic.GetDataGridViewRows(dgvTraffic);
        }
    }
}