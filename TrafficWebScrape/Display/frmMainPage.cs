using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficWebScrape.Traffic;


namespace TrafficWebScrape.Display
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            Traffic.Traffic traffic = new Traffic.Traffic();

            traffic.Process();

            foreach (DataGridViewRow dgvr in traffic.GetDataGridViewRows(dgvTraffic))
            {
                //dgvTraffic.Rows.Add(dgvr);
            }            
        }
    }
}
