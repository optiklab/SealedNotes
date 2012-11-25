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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.AppendLine(OptikLaboratory.SealedNotes.Properties.Resources.Intend);
            sb.AppendLine(OptikLaboratory.SealedNotes.Properties.Resources.MainUI);
            sb.AppendLine(OptikLaboratory.SealedNotes.Properties.Resources.MainFunctions);
            sb.AppendLine(OptikLaboratory.SealedNotes.Properties.Resources.Requirements);
            sb.AppendLine(OptikLaboratory.SealedNotes.Properties.Resources.Warning);
            sb.AppendLine(OptikLaboratory.SealedNotes.Properties.Resources.Links);
            txbMain.Text = sb.ToString();
        }
    }
}