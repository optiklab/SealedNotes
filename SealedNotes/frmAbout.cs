using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//////////////////////////////////////////////////////////
//                  Coded by OptikLab                    /
//                                                       /
//                         **                            /
//                        /()\                           /
//                         /\                            / 
//                        2009                           /
//////////////////////////////////////////////////////////

namespace OptikLaboratory.SealedNotes
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.AppendLine(OptikLaboratory.SealedNotes.Properties.Resources.AboutFirst);
            sb.AppendLine(OptikLaboratory.SealedNotes.Properties.Resources.AboutSecond);
            sb.AppendLine(OptikLaboratory.SealedNotes.Properties.Resources.AboutSite);
            sb.AppendLine(OptikLaboratory.SealedNotes.Properties.Resources.AboutFinish);
            txbMain.Text = sb.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}