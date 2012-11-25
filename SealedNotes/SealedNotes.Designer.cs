

namespace OptikLaboratory.SealedNotes
{
    partial class SealedNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SealedNotes));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mnLeftMenu = new System.Windows.Forms.MenuItem();
            this.mnAdd = new System.Windows.Forms.MenuItem();
            this.mnEdit = new System.Windows.Forms.MenuItem();
            this.mnDelete = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.mnSaveToFile = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnProperties = new System.Windows.Forms.MenuItem();
            this.mnHelp = new System.Windows.Forms.MenuItem();
            this.mnAbout = new System.Windows.Forms.MenuItem();
            this.mnQuit = new System.Windows.Forms.MenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.NameColumn = new System.Windows.Forms.ColumnHeader();
            this.CreatedDateColumn = new System.Windows.Forms.ColumnHeader();
            this.LastAccessDateColumn = new System.Windows.Forms.ColumnHeader();
            this.UpdateDateColumn = new System.Windows.Forms.ColumnHeader();
            //this.btnAdd = new System.Windows.Forms.Button();
            //this.btnDelete = new System.Windows.Forms.Button();
            //this.btnExit = new System.Windows.Forms.Button();
            //this.btnEdit = new System.Windows.Forms.Button();
            //this.btnHelp = new System.Windows.Forms.Button();
            this.btnAdd = new OptikLaboratory.SealedNotes.ImageButton();
            this.btnDelete = new OptikLaboratory.SealedNotes.ImageButton();
            this.btnExit = new OptikLaboratory.SealedNotes.ImageButton();
            this.btnEdit = new OptikLaboratory.SealedNotes.ImageButton();
            this.btnHelp = new OptikLaboratory.SealedNotes.ImageButton();
            this.imageList = new System.Windows.Forms.ImageList();
            this.lnkProperties = new System.Windows.Forms.LinkLabel();
            this.lnkSaveToFile = new System.Windows.Forms.LinkLabel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mnLeftMenu);
            // 
            // mnLeftMenu
            // 
            this.mnLeftMenu.MenuItems.Add(this.mnAdd);
            this.mnLeftMenu.MenuItems.Add(this.mnEdit);
            this.mnLeftMenu.MenuItems.Add(this.mnDelete);
            this.mnLeftMenu.MenuItems.Add(this.menuItem7);
            this.mnLeftMenu.MenuItems.Add(this.mnSaveToFile);
            this.mnLeftMenu.MenuItems.Add(this.menuItem2);
            this.mnLeftMenu.MenuItems.Add(this.mnProperties);
            this.mnLeftMenu.MenuItems.Add(this.mnHelp);
            this.mnLeftMenu.MenuItems.Add(this.mnAbout);
            this.mnLeftMenu.MenuItems.Add(this.mnQuit);
            this.mnLeftMenu.Text = "Menu";
            // 
            // mnAdd
            // 
            this.mnAdd.Text = "Add new...";
            this.mnAdd.Click += new System.EventHandler(this.mnAdd_Click);
            // 
            // mnEdit
            // 
            this.mnEdit.Text = "Edit selected...";
            this.mnEdit.Click += new System.EventHandler(this.mnEdit_Click);
            // 
            // mnDelete
            // 
            this.mnDelete.Text = "Delete selected";
            this.mnDelete.Click += new System.EventHandler(this.mnDelete_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Text = "-";
            // 
            // mnSaveToFile
            // 
            this.mnSaveToFile.Text = "Save to file...";
            this.mnSaveToFile.Click += new System.EventHandler(this.mnSaveToFile_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "-";
            // 
            // mnProperties
            // 
            this.mnProperties.Text = "Preferences...";
            this.mnProperties.Click += new System.EventHandler(this.mnProperties_Click);
            // 
            // mnHelp
            // 
            this.mnHelp.Text = "Help...";
            this.mnHelp.Click += new System.EventHandler(this.mnHelp_Click);
            // 
            // mnAbout
            // 
            this.mnAbout.Text = "About...";
            this.mnAbout.Click += new System.EventHandler(this.mnAbout_Click);
            // 
            // mnQuit
            // 
            this.mnQuit.Text = "Quit";
            this.mnQuit.Click += new System.EventHandler(this.mnQuit_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.Add(this.NameColumn);
            this.listView.Columns.Add(this.CreatedDateColumn);
            this.listView.Columns.Add(this.LastAccessDateColumn);
            this.listView.Columns.Add(this.UpdateDateColumn);
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(3, 46);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(234, 175);
            this.listView.TabIndex = 0;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 150;
            // 
            // CreatedDateColumn
            // 
            this.CreatedDateColumn.Text = "Created Date";
            this.CreatedDateColumn.Width = 150;
            // 
            // LastAccessDateColumn
            // 
            this.LastAccessDateColumn.Text = "Last Access Date";
            this.LastAccessDateColumn.Width = 150;
            // 
            // UpdateDateColumn
            // 
            this.UpdateDateColumn.Text = "Update Date";
            this.UpdateDateColumn.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(3, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.Image = global::OptikLaboratory.SealedNotes.Properties.Resources.add;
            this.btnAdd.Image_pushed = global::OptikLaboratory.SealedNotes.Properties.Resources.add_pushed;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(49, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Del";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.Image = global::OptikLaboratory.SealedNotes.Properties.Resources.del;
            this.btnDelete.Image_pushed = global::OptikLaboratory.SealedNotes.Properties.Resources.del_pushed;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(197, 224);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Quit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.Image = global::OptikLaboratory.SealedNotes.Properties.Resources.home;
            this.btnExit.Image_pushed = global::OptikLaboratory.SealedNotes.Properties.Resources.home_pushed;
            this.btnExit.BackColor = System.Drawing.Color.White;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(96, 224);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::OptikLaboratory.SealedNotes.Properties.Resources.edit;
            this.btnEdit.Image_pushed = global::OptikLaboratory.SealedNotes.Properties.Resources.edit_pushed;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Location = new System.Drawing.Point(151, 224);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(40, 40);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "?";
            this.btnHelp.BackColor = System.Drawing.Color.White;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.Image = global::OptikLaboratory.SealedNotes.Properties.Resources.faq;
            this.btnHelp.Image_pushed = global::OptikLaboratory.SealedNotes.Properties.Resources.faq_pushed;
            // 
            // imageList
            // 
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.Images.Clear();
            this.imageList.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource"))));
            this.imageList.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource1"))));
            this.imageList.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource2"))));
            this.imageList.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource3"))));
            // 
            // lnkProperties
            // 
            this.lnkProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkProperties.Location = new System.Drawing.Point(160, 26);
            this.lnkProperties.Name = "lnkProperties";
            this.lnkProperties.Size = new System.Drawing.Size(77, 20);
            this.lnkProperties.TabIndex = 6;
            this.lnkProperties.Text = "Preferences";
            this.lnkProperties.Click += new System.EventHandler(this.lnkProperties_Click);
            this.lnkProperties.ForeColor = System.Drawing.Color.White;
            // 
            // lnkSaveToFile
            // 
            this.lnkSaveToFile.Location = new System.Drawing.Point(151, 7);
            this.lnkSaveToFile.Name = "lnkSaveToFile";
            this.lnkSaveToFile.Size = new System.Drawing.Size(83, 20);
            this.lnkSaveToFile.TabIndex = 9;
            this.lnkSaveToFile.Text = "Save to file...";
            this.lnkSaveToFile.Click += new System.EventHandler(this.lnkSaveToFile_Click);
            this.lnkSaveToFile.ForeColor = System.Drawing.Color.White;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(3, 23);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(133, 21);
            this.txbSearch.TabIndex = 11;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(3, 7);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 13);
            this.lblSearch.Text = "Search:";
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            // 
            // SealedNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.lnkSaveToFile);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lnkProperties);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "SealedNotes";
            this.Text = "Sealed Notes 1.0";
            this.Load += new System.EventHandler(this.SealedNotes_Load);
            this.ResumeLayout(false);
            this.BackColor = System.Drawing.Color.Black;
        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader CreatedDateColumn;
        private System.Windows.Forms.ColumnHeader LastAccessDateColumn;
        private System.Windows.Forms.ColumnHeader UpdateDateColumn;
        //private System.Windows.Forms.Button btnAdd;
        //private System.Windows.Forms.Button btnDelete;
        //private System.Windows.Forms.Button btnExit;
        //private System.Windows.Forms.Button btnEdit;
        //private System.Windows.Forms.Button btnHelp;
        private OptikLaboratory.SealedNotes.ImageButton btnExit;
        private OptikLaboratory.SealedNotes.ImageButton btnEdit;
        private OptikLaboratory.SealedNotes.ImageButton btnHelp;
        private OptikLaboratory.SealedNotes.ImageButton btnDelete;
        private OptikLaboratory.SealedNotes.ImageButton btnAdd;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.LinkLabel lnkProperties;
        private System.Windows.Forms.LinkLabel lnkSaveToFile;
        private System.Windows.Forms.MenuItem mnLeftMenu;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem mnProperties;
        private System.Windows.Forms.MenuItem mnAdd;
        private System.Windows.Forms.MenuItem mnEdit;
        private System.Windows.Forms.MenuItem mnDelete;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem mnSaveToFile;
        private System.Windows.Forms.MenuItem mnQuit;
        private System.Windows.Forms.MenuItem mnAbout;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.MenuItem mnHelp;

    }
}

