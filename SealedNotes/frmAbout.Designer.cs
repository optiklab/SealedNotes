namespace OptikLaboratory.SealedNotes
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbMain = new System.Windows.Forms.TextBox();
            this.btnClose = new OptikLaboratory.SealedNotes.ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeveloper.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDeveloper.Location = new System.Drawing.Point(0, 222);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(188, 20);
            this.lblDeveloper.Text = "OptikLab © 2009";
            this.lblDeveloper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblName.Location = new System.Drawing.Point(3, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(234, 20);
            this.lblName.Text = "Sealed Notes v. 1.0";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbMain
            // 
            this.txbMain.AcceptsReturn = true;
            this.txbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMain.BackColor = System.Drawing.SystemColors.GrayText;
            this.txbMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txbMain.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txbMain.Location = new System.Drawing.Point(3, 32);
            this.txbMain.Multiline = true;
            this.txbMain.Name = "txbMain";
            this.txbMain.ReadOnly = true;
            this.txbMain.Size = new System.Drawing.Size(234, 182);
            this.txbMain.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(188, 220);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.Image = global::OptikLaboratory.SealedNotes.Properties.Resources.home;
            this.btnClose.Image_pushed = global::OptikLaboratory.SealedNotes.Properties.Resources.home_pushed;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(3, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.Text = "All rights reserved.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txbMain);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDeveloper);
            this.Menu = this.mainMenu1;
            this.Name = "frmAbout";
            this.Text = "About SealedNotes";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbMain;
        private OptikLaboratory.SealedNotes.ImageButton btnClose;
        private System.Windows.Forms.Label label1;
    }
}