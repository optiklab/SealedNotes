namespace OptikLaboratory.SealedNotes
{
    partial class frmEditor
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
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.txbMiniWord = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnCancel = new OptikLaboratory.SealedNotes.ImageButton();
            this.btnOK = new OptikLaboratory.SealedNotes.ImageButton();
            this.lblNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.Text = "Editing";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Cut";
            this.menuItem2.Click += new System.EventHandler(this.mnCut_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Copy";
            this.menuItem3.Click += new System.EventHandler(this.mnCopy_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Paste";
            this.menuItem4.Click += new System.EventHandler(this.mnPaste_Click);
            // 
            // txbMiniWord
            // 
            this.txbMiniWord.AcceptsReturn = true;
            this.txbMiniWord.AcceptsTab = true;
            this.txbMiniWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMiniWord.HideSelection = false;
            this.txbMiniWord.Location = new System.Drawing.Point(3, 50);
            this.txbMiniWord.MaxLength = 10000;
            this.txbMiniWord.Multiline = true;
            this.txbMiniWord.Name = "txbMiniWord";
            this.txbMiniWord.Size = new System.Drawing.Size(234, 155);
            this.txbMiniWord.TabIndex = 0;
            this.txbMiniWord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // txbName
            // 
            this.txbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbName.Location = new System.Drawing.Point(51, 5);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(186, 21);
            this.txbName.TabIndex = 1;
            // 
            // lblText
            // 
            this.lblText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblText.Location = new System.Drawing.Point(3, 8);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(42, 21);
            this.lblText.Text = "Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(126, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.Image = global::OptikLaboratory.SealedNotes.Properties.Resources.Cancel;
            this.btnCancel.Image_pushed = global::OptikLaboratory.SealedNotes.Properties.Resources.Cancel_pushed;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(0, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 31);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.Image = global::OptikLaboratory.SealedNotes.Properties.Resources.Okie;
            this.btnOK.Image_pushed = global::OptikLaboratory.SealedNotes.Properties.Resources.Okie_pushed;
            // 
            // lblNote
            // 
            this.lblNote.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNote.Location = new System.Drawing.Point(3, 32);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(100, 16);
            this.lblNote.Text = "Input your note:";
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbMiniWord);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmEditor";
            this.Text = "Notes Editor";
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEditor_KeyDown);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TextBox txbMiniWord;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblText;
        private OptikLaboratory.SealedNotes.ImageButton btnCancel;
        private OptikLaboratory.SealedNotes.ImageButton btnOK;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;

    }
}