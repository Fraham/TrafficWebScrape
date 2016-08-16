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
            this.clmRoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAreaAffected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartClear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndClear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLanesClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelayedMinutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbRoadSelection = new System.Windows.Forms.ComboBox();
            this.btnFilterRoad = new System.Windows.Forms.Button();
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
            this.dgvTraffic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraffic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraffic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRoad,
            this.clmDirection,
            this.clmAreaAffected,
            this.clmStatus,
            this.clmStartClear,
            this.clmEndClear,
            this.clmStartNormal,
            this.clmEndNormal,
            this.clmLanesClosed,
            this.clmReason,
            this.clmDelayedMinutes});
            this.dgvTraffic.Location = new System.Drawing.Point(27, 45);
            this.dgvTraffic.Name = "dgvTraffic";
            this.dgvTraffic.ReadOnly = true;
            this.dgvTraffic.Size = new System.Drawing.Size(954, 500);
            this.dgvTraffic.TabIndex = 1;
            // 
            // clmRoad
            // 
            this.clmRoad.HeaderText = "Road";
            this.clmRoad.Name = "clmRoad";
            this.clmRoad.ReadOnly = true;
            // 
            // clmDirection
            // 
            this.clmDirection.HeaderText = "Direction";
            this.clmDirection.Name = "clmDirection";
            this.clmDirection.ReadOnly = true;
            // 
            // clmAreaAffected
            // 
            this.clmAreaAffected.HeaderText = "Area Affected";
            this.clmAreaAffected.Name = "clmAreaAffected";
            this.clmAreaAffected.ReadOnly = true;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
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
            // clmDelayedMinutes
            // 
            this.clmDelayedMinutes.HeaderText = "Delay (Minutes)";
            this.clmDelayedMinutes.Name = "clmDelayedMinutes";
            this.clmDelayedMinutes.ReadOnly = true;
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
            // cmbRoadSelection
            // 
            this.cmbRoadSelection.FormattingEnabled = true;
            this.cmbRoadSelection.Location = new System.Drawing.Point(27, 14);
            this.cmbRoadSelection.Name = "cmbRoadSelection";
            this.cmbRoadSelection.Size = new System.Drawing.Size(121, 21);
            this.cmbRoadSelection.TabIndex = 3;
            // 
            // btnFilterRoad
            // 
            this.btnFilterRoad.Location = new System.Drawing.Point(154, 12);
            this.btnFilterRoad.Name = "btnFilterRoad";
            this.btnFilterRoad.Size = new System.Drawing.Size(75, 23);
            this.btnFilterRoad.TabIndex = 4;
            this.btnFilterRoad.Text = "Filter";
            this.btnFilterRoad.UseVisualStyleBackColor = true;
            this.btnFilterRoad.Click += new System.EventHandler(this.btnFilterRoad_Click);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 557);
            this.Controls.Add(this.btnFilterRoad);
            this.Controls.Add(this.cmbRoadSelection);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAreaAffected;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEndClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEndNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLanesClosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDelayedMinutes;
        private System.Windows.Forms.ComboBox cmbRoadSelection;
        private System.Windows.Forms.Button btnFilterRoad;
    }
}

