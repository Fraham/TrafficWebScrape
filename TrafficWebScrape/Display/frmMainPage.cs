using System;
using System.Windows.Forms;
using TrafficWebScrape.Highway;

namespace TrafficWebScrape.Display
{
    public partial class frmMainPage : Form
    {
        private Traffic.Traffic traffic;
        public frmMainPage()
        {
            InitializeComponent();

            Road.Load();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadTrafficData();
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            loadTrafficData();

            foreach(Road road in traffic.ProblemRoads)
            {
                cmbRoadSelection.Items.Add(road.Name);
            }
        }
        private void loadTrafficData()
        {
            dgvTraffic.Rows.Clear();
            traffic = new Traffic.Traffic();

            traffic.Process();

            traffic.GetDataGridViewRows(dgvTraffic);
        }

        private void btnFilterRoad_Click(object sender, EventArgs e)
        {
            dgvTraffic.Rows.Clear();
            traffic = new Traffic.Traffic();

            traffic.Process();

            if (cmbRoadSelection.SelectedItem == null)// || cmbRoadSelection.SelectedValue.Equals(""))
            {
                traffic.GetDataGridViewRows(dgvTraffic);
            }
            else
            {
                traffic.GetDataGridViewRows(dgvTraffic, Road.GetRoad(cmbRoadSelection.SelectedItem.ToString()));
            }
        }
    }
}