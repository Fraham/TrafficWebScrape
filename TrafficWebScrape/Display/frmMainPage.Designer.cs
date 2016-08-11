namespace TrafficWebScrape.Display
{
    partial class frmMainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTraffic = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.clmRoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTimeToClear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartClear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndClear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReturnToNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLanesClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelayedMinutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraffic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTraffic
            // 
            this.dgvTraffic.AllowUserToAddRows = false;
            this.dgvTraffic.AllowUserToDeleteRows = false;
            this.dgvTraffic.AllowUserToOrderColumns = true;
            this.dgvTraffic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTraffic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraffic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRoad,
            this.clmLocation,
            this.clmStatus,
            this.clmTimeToClear,
            this.clmStartClear,
            this.clmEndClear,
            this.clmReturnToNormal,
            this.clmStartNormal,
            this.clmEndNormal,
            this.clmLanesClosed,
            this.clmReason,
            this.clmDelay,
            this.clmDelayedMinutes});
            this.dgvTraffic.Location = new System.Drawing.Point(27, 45);
            this.dgvTraffic.Name = "dgvTraffic";
            this.dgvTraffic.ReadOnly = true;
            this.dgvTraffic.Size = new System.Drawing.Size(954, 500);
            this.dgvTraffic.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(906, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // clmRoad
            // 
            this.clmRoad.HeaderText = "Road";
            this.clmRoad.Name = "clmRoad";
            this.clmRoad.ReadOnly = true;
            // 
            // clmLocation
            // 
            this.clmLocation.HeaderText = "Location";
            this.clmLocation.Name = "clmLocation";
            this.clmLocation.ReadOnly = true;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            // 
            // clmTimeToClear
            // 
            this.clmTimeToClear.HeaderText = "Time To Clear";
            this.clmTimeToClear.Name = "clmTimeToClear";
            this.clmTimeToClear.ReadOnly = true;
            // 
            // clmStartClear
            // 
            this.clmStartClear.HeaderText = "Start Clear";
            this.clmStartClear.Name = "clmStartClear";
            this.clmStartClear.ReadOnly = true;
            // 
            // clmEndClear
            // 
            this.clmEndClear.HeaderText = "End Clear";
            this.clmEndClear.Name = "clmEndClear";
            this.clmEndClear.ReadOnly = true;
            // 
            // clmReturnToNormal
            // 
            this.clmReturnToNormal.HeaderText = "Return To Normal";
            this.clmReturnToNormal.Name = "clmReturnToNormal";
            this.clmReturnToNormal.ReadOnly = true;
            // 
            // clmStartNormal
            // 
            this.clmStartNormal.HeaderText = "Start Normal";
            this.clmStartNormal.Name = "clmStartNormal";
            this.clmStartNormal.ReadOnly = true;
            // 
            // clmEndNormal
            // 
            this.clmEndNormal.HeaderText = "End Normal";
            this.clmEndNormal.Name = "clmEndNormal";
            this.clmEndNormal.ReadOnly = true;
            // 
            // clmLanesClosed
            // 
            this.clmLanesClosed.HeaderText = "Lanes Closed";
            this.clmLanesClosed.Name = "clmLanesClosed";
            this.clmLanesClosed.ReadOnly = true;
            // 
            // clmReason
            // 
            this.clmReason.HeaderText = "Reason";
            this.clmReason.Name = "clmReason";
            this.clmReason.ReadOnly = true;
            // 
            // clmDelay
            // 
            this.clmDelay.HeaderText = "Delay";
            this.clmDelay.Name = "clmDelay";
            this.clmDelay.ReadOnly = true;
            // 
            // clmDelayedMinutes
            // 
            this.clmDelayedMinutes.HeaderText = "Delay (Minutes)";
            this.clmDelayedMinutes.Name = "clmDelayedMinutes";
            this.clmDelayedMinutes.ReadOnly = true;
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 557);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvTraffic);
            this.Name = "frmMainPage";
            this.Text = "Traffic Analysis";
            this.Load += new System.EventHandler(this.frmMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraffic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTraffic;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeToClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEndClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReturnToNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEndNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLanesClosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDelayedMinutes;
    }
}

