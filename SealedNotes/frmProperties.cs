using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

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
    #region frmProperties class - view form of Properties class
    ///<summary>
    /// It's shows information about actual Properties and allow to edit it
    ///</summary>
    public partial class frmProperties : Form
    {
        #region Private Variables        
        private String _key;
        private String _password;
        private EncryptionType _algorithm;
        private bool _isCanceled;
        private bool _askPassword;
        #endregion

        #region Private Handlers
        private void frmProperties_Load(object sender, EventArgs e)
        {
            txtPassword.Text = _password;
            txtKey.Text = _key;
            switch (_algorithm)
            {
                case EncryptionType.TripleDES:
                    ComboAlgo.SelectedIndex = 0;
                    break;
                case EncryptionType.RC2:
                    ComboAlgo.SelectedIndex = 1;
                    break;
                case EncryptionType.Rijndael:
                    ComboAlgo.SelectedIndex = 2;
                    break;
                default:
                    ComboAlgo.SelectedIndex = 0;
                    break;
            }
            cbxPasswordStyle_Click(sender, e);
            if (_askPassword == true)
                cbxAskPassword.Checked = true;
            else
                cbxAskPassword.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _isCanceled = true;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _isCanceled = false;
            _key = txtKey.Text;
            _password = txtPassword.Text;
            Close();
        }

        private void QuestionAlgo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(OptikLaboratory.SealedNotes.Properties.Resources.HelpAlgorithm);
        }

        private void QuestionPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show(OptikLaboratory.SealedNotes.Properties.Resources.HelpPass);
        }

        private void QuestionKey_Click(object sender, EventArgs e)
        {
            MessageBox.Show(OptikLaboratory.SealedNotes.Properties.Resources.HelpKey);
        }

        //Selected antoher algorithm
        private void ComboAlgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboAlgo.SelectedIndex)
            {
                case 0:
                    _algorithm = EncryptionType.TripleDES;
                    break;
                case 1:
                    _algorithm = EncryptionType.RC2;
                    break;
                case 2:
                    _algorithm = EncryptionType.Rijndael;
                    break;
                default:
                    _algorithm = EncryptionType.TripleDES;
                    break;
            }
            txtPassword_TextChanged(sender, e);
            txtKey_TextChanged(sender, e);
        }

        //Entered new password
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (ComboAlgo.SelectedIndex == 0)
            {
                if (txtPassword.Text.Length < 8)
                    txtPassword.BackColor = Color.Red;
                else
                    txtPassword.BackColor = Color.GreenYellow;
            }
            if (ComboAlgo.SelectedIndex == 1)
            {
                if (txtPassword.Text.Length < 8)
                    txtPassword.BackColor = Color.Red;
                else
                    txtPassword.BackColor = Color.GreenYellow;
            }
            if (ComboAlgo.SelectedIndex == 2)
            {
                if (txtPassword.Text.Length < 16)
                    txtPassword.BackColor = Color.Red;
                else
                    txtPassword.BackColor = Color.GreenYellow;
            }
        }

        //Entered new key
        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            if (ComboAlgo.SelectedIndex == 0)
            {
                if (txtKey.Text.Length < 24)
                    txtKey.BackColor = Color.Red;
                else
                    txtKey.BackColor = Color.GreenYellow;
            }
            if (ComboAlgo.SelectedIndex == 1)
            {
                if (txtKey.Text.Length < 16)
                    txtKey.BackColor = Color.Red;
                else
                    txtKey.BackColor = Color.GreenYellow;
            }
            if (ComboAlgo.SelectedIndex == 2)
            {
                if (txtKey.Text.Length < 32)
                    txtKey.BackColor = Color.Red;
                else
                    txtKey.BackColor = Color.GreenYellow;
            }
        }

        //Generate New key
        private void button1_Click(object sender, EventArgs e)
        {
            if (_algorithm == EncryptionType.TripleDES)
            {
                txtKey.Text = GenerateKey(24);
            }
            else if (_algorithm == EncryptionType.RC2)
            {
                txtKey.Text = GenerateKey(16);
            }
            else if (_algorithm == EncryptionType.Rijndael)
            {
                txtKey.Text = GenerateKey(32);
            }
        }

        private void cbxPasswordStyle_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void cbxPasswordStyle_Click(object sender, EventArgs e)
        {
            if (cbxPasswordStyle.Checked == true)
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void cbxAskPassword_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbxAskPassword.Checked == true)
                _askPassword = true;
            else
                _askPassword = false;
        }
        #endregion

        #region Constructor
        public frmProperties(EncryptionType Type, String sPassword, String sKey, bool AskPass)
        {
            InitializeComponent();
            _algorithm = Type;
            _isCanceled = true;
            _password = sPassword;       
            _key = sKey;
            _askPassword = AskPass;
        }
        #endregion

        #region Public Properties
        public String Key
        {
            set
            {
                _key = value;
            }
            get
            {
                return _key;
            }
        }

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

        public EncryptionType Algorithm
        {
            set
            {
                _algorithm = value;
            }
            get
            {
                return _algorithm;
            }
        }

        public bool IsCanceled
        {
            set
            {
                _isCanceled = value;
            }
            get
            {
                return _isCanceled;
            }
        }

        public bool AskPassword
        {
            set
            {
                _askPassword = value;
            }
            get
            {
                return _askPassword;
            }
        }
        #endregion

        #region Private Methods
        private string GenerateKey(int KeyLength)
        {
            StringBuilder Key = new StringBuilder(KeyLength);
            bool isNumber = true;
            Random rn = new Random();
            int N = 97;
            for (int i = 0; i < KeyLength; i++)
            {
                if (isNumber == false)
                {
                    N = rn.Next(97, 122);
                    Key.Append((char)N);
                    isNumber = true;
                }
                else
                {
                    N = rn.Next(48, 57);
                    Key.Append((char)N);
                    isNumber = false;
                }
            }
            return Key.ToString();
        }
        #endregion
    }
    #endregion
}