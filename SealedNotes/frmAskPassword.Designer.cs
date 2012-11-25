namespace OptikLaboratory.SealedNotes
{
    partial class frmAskPassword
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
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnOK = new OptikLaboratory.SealedNotes.ImageButton();
            this.btnCancel = new OptikLaboratory.SealedNotes.ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPassword.Location = new System.Drawing.Point(13, 37);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(215, 21);
            this.txbPassword.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(0, 66);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 31);
            this.btnOK.TabIndex = 1;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.Image = global::OptikLaboratory.SealedNotes.Properties.Resources.Okie;
            this.btnOK.Image_pushed = global::OptikLaboratory.SealedNotes.Properties.Resources.Okie_pushed;

            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(126, 66);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.Image = global::OptikLaboratory.SealedNotes.Properties.Resources.Cancel;
            this.btnCancel.Image_pushed = global::OptikLaboratory.SealedNotes.Properties.Resources.Cancel_pushed;

            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.Text = "Please, enter your password:";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(14, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 54);
            this.label2.Text = "If you won\'t to see this window again, please change it in Preferences.";
            // 
            // frmAskPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txbPassword);
            this.Menu = this.mainMenu1;
            this.Name = "frmAskPassword";
            this.Text = "Sealed Notes 1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbPassword;
        private OptikLaboratory.SealedNotes.ImageButton btnOK;
        private OptikLaboratory.SealedNotes.ImageButton btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}