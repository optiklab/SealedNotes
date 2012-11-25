namespace OptikLaboratory.SealedNotes
{
    partial class frmProperties
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnOK = new OptikLaboratory.SealedNotes.ImageButton();
            this.btnCancel = new OptikLaboratory.SealedNotes.ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboAlgo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuestionAlgo = new System.Windows.Forms.Button();
            this.QuestionPass = new System.Windows.Forms.Button();
            this.QuestionKey = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxPasswordStyle = new System.Windows.Forms.CheckBox();
            this.cbxAskPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(0, 232);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 31);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.Image = global::OptikLaboratory.SealedNotes.Properties.Resources.Okie;
            this.btnOK.Image_pushed = global::OptikLaboratory.SealedNotes.Properties.Resources.Okie_pushed;

            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(126, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.Image = global::OptikLaboratory.SealedNotes.Properties.Resources.Cancel;
            this.btnCancel.Image_pushed = global::OptikLaboratory.SealedNotes.Properties.Resources.Cancel_pushed;

            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.Text = "Choose algorithm:";
            // 
            // ComboAlgo
            // 
            this.ComboAlgo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboAlgo.Items.Add("TripleDES");
            this.ComboAlgo.Items.Add("RC2");
            this.ComboAlgo.Items.Add("Rijndael");
            this.ComboAlgo.Location = new System.Drawing.Point(3, 29);
            this.ComboAlgo.Name = "ComboAlgo";
            this.ComboAlgo.Size = new System.Drawing.Size(234, 22);
            this.ComboAlgo.TabIndex = 1;
            this.ComboAlgo.SelectedIndexChanged += new System.EventHandler(this.ComboAlgo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(3, 77);
            this.txtPassword.MaxLength = 16;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(234, 21);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(3, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.Text = "Key:";
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.Location = new System.Drawing.Point(3, 162);
            this.txtKey.MaxLength = 32;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(234, 21);
            this.txtKey.TabIndex = 6;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataSource = typeof(object);
            // 
            // QuestionAlgo
            // 
            this.QuestionAlgo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionAlgo.BackColor = System.Drawing.Color.Black;
            this.QuestionAlgo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.QuestionAlgo.Location = new System.Drawing.Point(213, 6);
            this.QuestionAlgo.Name = "QuestionAlgo";
            this.QuestionAlgo.Size = new System.Drawing.Size(24, 20);
            this.QuestionAlgo.TabIndex = 7;
            this.QuestionAlgo.Text = " ?";
            this.QuestionAlgo.Click += new System.EventHandler(this.QuestionAlgo_Click);
            // 
            // QuestionPass
            // 
            this.QuestionPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionPass.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.QuestionPass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.QuestionPass.Location = new System.Drawing.Point(213, 55);
            this.QuestionPass.Name = "QuestionPass";
            this.QuestionPass.Size = new System.Drawing.Size(24, 20);
            this.QuestionPass.TabIndex = 8;
            this.QuestionPass.Text = " ?";
            this.QuestionPass.Click += new System.EventHandler(this.QuestionPass_Click);
            // 
            // QuestionKey
            // 
            this.QuestionKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionKey.BackColor = System.Drawing.Color.Black;
            this.QuestionKey.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.QuestionKey.Location = new System.Drawing.Point(213, 140);
            this.QuestionKey.Name = "QuestionKey";
            this.QuestionKey.Size = new System.Drawing.Size(24, 20);
            this.QuestionKey.TabIndex = 9;
            this.QuestionKey.Text = " ?";
            this.QuestionKey.Click += new System.EventHandler(this.QuestionKey_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generate";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxPasswordStyle
            // 
            this.cbxPasswordStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPasswordStyle.Checked = true;
            this.cbxPasswordStyle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxPasswordStyle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbxPasswordStyle.Location = new System.Drawing.Point(3, 101);
            this.cbxPasswordStyle.Name = "cbxPasswordStyle";
            this.cbxPasswordStyle.Size = new System.Drawing.Size(204, 20);
            this.cbxPasswordStyle.TabIndex = 14;
            this.cbxPasswordStyle.Text = "Hide password";
            this.cbxPasswordStyle.CheckStateChanged += new System.EventHandler(this.cbxPasswordStyle_CheckStateChanged);
            this.cbxPasswordStyle.Click += new System.EventHandler(this.cbxPasswordStyle_Click);
            // 
            // cbxAskPassword
            // 
            this.cbxAskPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAskPassword.Checked = true;
            this.cbxAskPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAskPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbxAskPassword.Location = new System.Drawing.Point(3, 121);
            this.cbxAskPassword.Name = "cbxAskPassword";
            this.cbxAskPassword.Size = new System.Drawing.Size(234, 20);
            this.cbxAskPassword.TabIndex = 18;
            this.cbxAskPassword.Text = "Ask password every start";
            this.cbxAskPassword.CheckStateChanged += new System.EventHandler(this.cbxAskPassword_CheckStateChanged);
            // 
            // frmProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.cbxAskPassword);
            this.Controls.Add(this.cbxPasswordStyle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuestionKey);
            this.Controls.Add(this.QuestionPass);
            this.Controls.Add(this.QuestionAlgo);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboAlgo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmProperties";
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.frmProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button btnOK;
        //private System.Windows.Forms.Button btnCancel;
        private OptikLaboratory.SealedNotes.ImageButton btnOK;
        private OptikLaboratory.SealedNotes.ImageButton btnCancel; //
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboAlgo;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button QuestionAlgo;
        private System.Windows.Forms.Button QuestionPass;
        private System.Windows.Forms.Button QuestionKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbxPasswordStyle;
        private System.Windows.Forms.CheckBox cbxAskPassword;
    }
}