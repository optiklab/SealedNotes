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
    #region Editor Form class
    /// <summary>
    /// This class describe behavior of Editor Form which allow to enter some 
    /// text
    /// </summary>
    public partial class frmEditor : Form
    {
        #region Private Variables
        private String _textArray;
        private String _textName;
        private String _arrayBefore;
        private String _nameBefore;
        private bool _isUpdated;
        private bool _isCanceled;
        #endregion

        #region Public Properties
        public String TextArray
        {
            set
            {
                _textArray = value;
            }
            get
            {
                return _textArray;
            }
        }

        public String ArrayBefore
        {
            set
            {
                _arrayBefore = value;
            }
            get
            {
                return _arrayBefore;
            }
        }

        public String TextName
        {
            set
            {
                _textName = value;
            }
            get
            {
                return _textName;
            }
        }

        public String NameBefore
        {
            set
            {
                _nameBefore = value;
            }
            get
            {
                return _nameBefore;
            }
        }

        public bool IsUpdated
        {
            set
            {
                _isUpdated = value;
            }
            get
            {
                return _isUpdated;
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
        #endregion

        #region Constructors
        public frmEditor()
        {
            InitializeComponent();
            _isUpdated = false;
            _isCanceled = false;
        }
        #endregion

        #region Private Handlers
        private void frmEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            txbMiniWord.Text = _textArray;
            txbName.Text = _textName;
            _nameBefore = _textName;
            _arrayBefore = _textArray;
            txbName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _isCanceled = true;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _textArray = txbMiniWord.Text;
            _textName = txbName.Text;
            if (_textName.Equals(_nameBefore) == false || _textArray.Equals(_arrayBefore) == false)
                _isUpdated = true;
            _isCanceled = false;
            Close();
        }

        private void mnCut_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbMiniWord.SelectedText != String.Empty)
                {
                    Clipboard.SetDataObject(txbMiniWord.SelectedText);
                    txbMiniWord.SelectedText = String.Empty;
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Selection is clear!");
            }
            catch (System.Threading.ThreadStateException)
            {
                MessageBox.Show("Thread error! Restart application!");
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {
                MessageBox.Show("Some external error occur!");
            }
        }

        private void mnCopy_Click(object sender, EventArgs e)
        {
            if (txbMiniWord.SelectedText != String.Empty)
                Clipboard.SetDataObject(txbMiniWord.SelectedText);
        }

        private void mnPaste_Click(object sender, EventArgs e)
        {
            txbMiniWord.SelectedText = String.Empty;
            int Start = txbMiniWord.SelectionStart;
            String sb1 = txbMiniWord.Text;
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.UnicodeText) == true)
            {
                string clipboard = Convert.ToString(iData.GetData(DataFormats.UnicodeText));
                txbMiniWord.Text = sb1.Insert(Start, clipboard);
            }
        }
        #endregion
    }
    #endregion
}