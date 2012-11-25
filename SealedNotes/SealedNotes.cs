using System;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;

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
    #region Class Main Form
    /// <summary>
    /// Class describe behavior of Main Form in application
    /// Include handlers of all the buttons on the form
    /// </summary>
    public partial class SealedNotes : Form
    {
        #region Private Member Variables
        private SealedNote EncryptedData;
        private Settings ActualSettings;
        private Preferences ActualPreferences;
        private bool _isSettingsError;
        #endregion

        #region Standard constructor
        public SealedNotes()
        {
            InitializeComponent();
            EncryptedData = new SealedNote();
            ActualSettings = null;
            ActualPreferences = new Preferences();
            _isSettingsError = false;
        }
        #endregion

        #region Private handlers
        //Before loading of application form we read and parse settings
        private void SealedNotes_Load(object sender, EventArgs e)
        {
           //Read preferences
            ActualSettings = new Settings();
            if (ActualPreferences.InfoRead() == true)
            {
                _isSettingsError = false;
                if (ActualPreferences.AskPassword == true)
                {
                    frmAskPassword ap = new frmAskPassword();
                    ap.Password = ActualPreferences.Password;
                    ap.ShowDialog();
                    FileReader();
                }
                else
                {
                    FileReader(); //Read notes
                }
            }
            else
            {
                FileInfo fi = new FileInfo(GetPathToStorage());
                if (fi.Exists == true)
                {
                    MessageBox.Show("Can't read settings file! To open data, please select right preferences and restart application!");
                    _isSettingsError = true;
                    ActualPreferences.AskPassword = false;
                }
            }
            
        }

        //Button Add click handler
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckUpCount() == true)
            {
                try
                {
                    //show Editor dialog
                    frmEditor EditorForm = new frmEditor();
                    EditorForm.ShowDialog();
                    //add new data to data-collection
                    if (EditorForm.IsCanceled == false)
                    {
                        Note NewNote = new Note(EditorForm.TextName, EditorForm.TextArray);
                        EncryptedData.AddNote(NewNote);
                    }
                }
                catch (OutOfMemoryException Exc)
                {
                    MessageBox.Show(Exc.ToString());
                }
                catch (ArgumentException Exc)
                {
                    MessageBox.Show(Exc.ToString());
                }
                //add new record to grid
                UpdateGrid();
            }
        }

        //Button Edit click handler
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView.SelectedIndices.Count > 0)
            {
                int SelectedCell = listView.SelectedIndices[0];
                if (SelectedCell >= 0 && SelectedCell < EncryptedData.GetNoteCount())
                {
                    try
                    {
                        //show Editor dialog
                        frmEditor EditorForm = new frmEditor();
                        EditorForm.TextArray = EncryptedData.GetNoteText(SelectedCell);
                        EditorForm.TextName = EncryptedData.GetNoteName(SelectedCell);
                        EditorForm.ShowDialog();
                        //update data
                        EncryptedData.SetNoteAccessDate(SelectedCell, DateTime.Now);
                        if (EditorForm.IsCanceled == false)
                        {
                            if (EditorForm.IsUpdated == true)
                                EncryptedData.SetNoteUpdateDate(SelectedCell, DateTime.Now);
                            EncryptedData.SetNoteText(SelectedCell, EditorForm.TextArray);
                            EncryptedData.SetNoteName(SelectedCell, EditorForm.TextName);                            
                        }
                    }
                    catch (OutOfMemoryException Exc)
                    {
                        MessageBox.Show(Exc.ToString());
                    }
                    catch (ArgumentException Exc)
                    {
                        MessageBox.Show(Exc.ToString());
                    }
                    //add new record to grid
                    UpdateGrid();
                }
            }
        }

        //Button Delete click handler
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedIndices.Count > 0)
            {
                int SelectedCell = listView.SelectedIndices[0];
                if (SelectedCell >= 0 && SelectedCell < EncryptedData.GetNoteCount())
                {
                    try
                    {
                        //remove selected item from collection
                        EncryptedData.RemoveNoteAt(SelectedCell);
                    }
                    catch (ArgumentOutOfRangeException Exc)
                    {
                        MessageBox.Show(Exc.ToString());
                    }
                    //add new record to grid
                    UpdateGrid();
                }
            }
        }

        //Button Quit click handler
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Write preferences
            ActualPreferences.InfoWrite();
            //Write data
            if (_isSettingsError == false) //if was error during start application and read settings file
                //it is needs to protect user from loosing of all data after system error/file replacing/etc.
                FileWriter();
            //exit
            Application.Exit();
        }

        //Link Properties click handler
        private void lnkProperties_Click(object sender, EventArgs e)
        {
            frmProperties Properties = new frmProperties(ActualPreferences.Algorithm, ActualPreferences.Password, ActualPreferences.Key, ActualPreferences.AskPassword);
            Properties.ShowDialog();
            if (Properties.IsCanceled == false)
            {
                ActualPreferences.Algorithm = Properties.Algorithm;
                ActualPreferences.Key = Properties.Key;
                ActualPreferences.Password = Properties.Password;
                ActualPreferences.AskPassword = Properties.AskPassword;
            }
        }

        //Link About click handler
        private void lnkAbout_Click(object sender, EventArgs e)
        {
            frmAbout Fa = new frmAbout();
            Fa.Show();
        }

        //Menu Delete click handler
        private void mnDelete_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        //Menu Quit click handler
        private void mnQuit_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }

        //Menu Properties click handler
        private void mnProperties_Click(object sender, EventArgs e)
        {
            lnkProperties_Click(sender, e);
        }

        //Menu Add click handler
        private void mnAdd_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e); 
        }

        //Menu Edit click handler
        private void mnEdit_Click(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }


        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            String sFind = txbSearch.Text;
            if (sFind != String.Empty)
            {
                for (int i = 0; i < EncryptedData.GetNoteCount(); i++)
                {
                    if (EncryptedData.GetNoteName(i).StartsWith(sFind) == true)
                    {
                        listView.Items[i].Selected = true;
                        listView.EnsureVisible(i);
                    }
                    else
                        listView.Items[i].Selected = false;                   
                }
            }
        }

        private void mnSaveToFile_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void lnkSaveToFile_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void mnAbout_Click(object sender, EventArgs e)
        {
            frmAbout Fa = new frmAbout();
            Fa.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp Fh = new frmHelp();
            Fh.Show();
        }


        private void mnHelp_Click(object sender, EventArgs e)
        {
            btnHelp_Click(sender, e);
        }
        #endregion

        #region My Private functions
        //Check Up count of record
        private bool CheckUpCount()
        {
            if (EncryptedData.GetNoteCount() >= 0 && EncryptedData.GetNoteCount() < 499)
                return true;
            return false;
        }


        //Updates TableGrid by new data
        private void UpdateGrid()
        {
            listView.Items.Clear();
            EncryptedData.Sort();
            for (int i = 0; i < EncryptedData.GetNoteCount(); i++)
            {
                string[] Array = { EncryptedData.GetNoteName(i),
                                     EncryptedData.GetNoteCreateDate(i).ToString(),                                     
                                     EncryptedData.GetNoteAccessDate(i).ToString(),
                                     EncryptedData.GetNoteUpdateDate(i).ToString() };
                ListViewItem LVI = new ListViewItem(Array);
                listView.Items.Add(LVI);
            }
        }

        //
        private void FileReader()
        {

            DataEncrypter MyEncrypter = new DataEncrypter(ActualPreferences.Algorithm, 
                                                            ActualPreferences.Key, 
                                                            ActualPreferences.Password);
            string strData;
            String Path = GetPathToStorage();
            if (MyEncrypter.ReadData(Path) == true)
            {
                strData = MyEncrypter.Data;
                ReadDataString(strData);
            }
            else
                strData = "";
        }

        //
        private StringBuilder GetDataString()
        {
            StringBuilder strData = new StringBuilder(1000); //dynamic calc
            try
            {                
                strData.AppendLine(EncryptedData.GetNoteCount().ToString());//количество записей
                for (int i = 0; i < EncryptedData.GetNoteCount(); i++)
                {
                    strData.AppendLine(EncryptedData.GetNoteName(i));
                    int Lines = 0;
                    for (int j = 0; j < EncryptedData.GetNoteText(i).Length; j++)
                        if (EncryptedData.GetNoteText(i)[j].ToString() == "\n")
                            Lines += 1;
                    strData.AppendLine(Lines.ToString());
                    strData.AppendLine(EncryptedData.GetNoteText(i).ToString());
                    strData.AppendLine(EncryptedData.GetNoteCreateDate(i).ToString());
                    strData.AppendLine(EncryptedData.GetNoteUpdateDate(i).ToString());
                    strData.AppendLine(EncryptedData.GetNoteAccessDate(i).ToString());
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Memory error occur: " + ex.Message + "Try to restart application!");
            }
            return strData;
        }

        //
        private void ReadDataString(string strData)
        {
            try
            {
                StringReader str = new StringReader(strData);
                string sNotesCount = str.ReadLine();
                int NotesCount = Convert.ToInt32(sNotesCount);
                if (NotesCount >= 0 && NotesCount < 500)
                {
                    for (int i = 0; i < NotesCount; i++)
                    {
                        string sName = str.ReadLine();
                        string SCount = str.ReadLine();
                        int LinesCount = Convert.ToInt32(SCount);
                        StringBuilder sText = new StringBuilder(1000);
                        for (int j = 0; j < LinesCount + 1; j++)
                           if(j == LinesCount)
                               sText.Append(str.ReadLine());
                           else
                               sText.AppendLine(str.ReadLine());
                        Note NewNote = new Note(sName, sText.ToString(), Convert.ToDateTime(str.ReadLine()), Convert.ToDateTime(str.ReadLine()), Convert.ToDateTime(str.ReadLine()));
                        EncryptedData.AddNote(NewNote);
                    }
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Error occur during parse!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Converter error or wrong count of notes!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Data overflow error!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateGrid(); 
        }

        //
        private bool FileWriter()
        {
            DataEncrypter MyEncrypter = new DataEncrypter(ActualPreferences.Algorithm, 
                                                            ActualPreferences.Key, 
                                                            ActualPreferences.Password);
            String Path = GetPathToStorage();
            StringBuilder strData = GetDataString();
            if (MyEncrypter.WriteData(Path, strData) == true)
                return true;
            else
                return false;
        }

        //
        private String GetPathToStorage()
        {
            String FullPath;
            DirectoryInfo info = new DirectoryInfo(ActualSettings.SaveToFolder);            
            if (info.Exists == true)
                FullPath = ActualSettings.SaveToFolder + "\\" + ActualSettings.SaveToFile;
            else
                FullPath = ActualSettings.SaveToFile;
            return FullPath;
        }

        private void SaveToFile()
        {
            if (listView.SelectedIndices.Count > 0)
            {
                int SelectedRow = listView.SelectedIndices[0];
                if (SelectedRow >= 0 && SelectedRow < EncryptedData.GetNoteCount())
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Text files (*.txt)|*.txt|All files|*.*";
                    DialogResult res = sfd.ShowDialog();
                    if (res == DialogResult.Cancel)
                    {
                        return;
                    }
                    String FileName = sfd.FileName;
                    try
                    {
                        StreamWriter sw = new StreamWriter(FileName, false, System.Text.Encoding.GetEncoding("Windows-1251"));
                        sw.WriteLine(EncryptedData.GetNoteName(SelectedRow));
                        sw.WriteLine(EncryptedData.GetNoteText(SelectedRow));
                        sw.Flush();
                        sw.Close();
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("IO error occur, can't write file!");
                    }
                    catch (ObjectDisposedException)
                    {
                        MessageBox.Show("Some error occur, can't write file!");
                    }
                }
            }
        }
        #endregion

    }
    #endregion
}