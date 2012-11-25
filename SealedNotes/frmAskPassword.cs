using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OptikLaboratory.SealedNotes
{
    public partial class frmAskPassword : Form
    {
        #region Private Member Variables
        private String _password;
        #endregion

        #region Standard constructor
        public frmAskPassword()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Handlers
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == _password)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Access denied!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Public Properties
        public String Password
        {
            set
            {
                _password = value;
            }
            get
            {
                return _password;
            }
        }
        #endregion
    }
}