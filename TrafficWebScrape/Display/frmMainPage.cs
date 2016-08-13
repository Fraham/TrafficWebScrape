using System;
using System.Windows.Forms;
using TrafficWebScrape.Highway;

namespace TrafficWebScrape.Display
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();

            Road.Load();
            Console.WriteLine(Road.Roads.Count);
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