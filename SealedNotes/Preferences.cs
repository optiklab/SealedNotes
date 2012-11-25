using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

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
    #region Preferences class contain information about Algorithm, Key and Vector
    ///<summary>
    /// It's read, write, save data about encryption method which is using by Encryptor to read/write DATA
    ///</summary>
    public class Preferences
    {
        #region Private Member Variables
        private String _key;
        private String _password;
        private EncryptionType _algorithm;
        private String _defaultPath;
        private bool _AskPassword;
        #endregion

        #region Private Methods
        private StringBuilder GetData()
        {
            StringBuilder strData = new StringBuilder(100);
            try
            {
                strData.AppendLine(_password.ToString());
                strData.AppendLine(_key.ToString());
                strData.AppendLine(GetAlgoByType(_algorithm));
                strData.AppendLine(_AskPassword.ToString());
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Memory error occur: " + ex.Message + "Try to restart application!");
            }
            return strData;
        }

        //Method get data about algorithm, key and vector from read string array
        private void ParseData(string strData)
        {
            String Field1 = "", Field2 = "", Field3 = "";
            EncryptionType Algorithm = EncryptionType.TripleDES;
            try
            {
                StringReader str = new StringReader(strData);
                Field1 = str.ReadLine();
                Field2 = str.ReadLine();
                Algorithm = GetAlgoByName(str.ReadLine());
                Field3 = str.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("Settings error occur, will use defaults!");
            }
            _password = Field1;
            _key = Field2;
            _algorithm = Algorithm;
            _AskPassword = Convert.ToBoolean(Field3.ToString());
        }

        //
        private EncryptionType GetAlgoByName(string AlgoName)
        {
            switch (AlgoName)
            {
                case "TripleDES":
                    return EncryptionType.TripleDES;
                case "RC2":
                    return EncryptionType.RC2;
                case "Rijndael":
                    return EncryptionType.Rijndael;
                default:
                    return EncryptionType.TripleDES;
            }
        }

        //
        private String GetAlgoByType(EncryptionType Type)
        {
            switch (Type)
            {
                case EncryptionType.TripleDES:
                    return "TripleDES";
                case EncryptionType.RC2:
                    return "RC2";
                case EncryptionType.Rijndael:
                    return "Rijndael";
                default:
                    return "TripleDES";
            }
        }
        #endregion

        #region Constructor
        public Preferences()
        {
            _algorithm = EncryptionType.TripleDES;
            _password = "abcdefgi";
            _key = "abcdefghijklmnopqrstuvwx";
            _defaultPath = "\\Windows\\SNOP";
            _AskPassword = true;
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

        public bool AskPassword
        {
            set
            {
                _AskPassword = value;
            }
            get
            {
                return _AskPassword;
            }
        }
        #endregion

        #region Public methods
        //Write properties method
        public void InfoWrite()
        {
            DataEncrypter MyEncrypter = new DataEncrypter();
            StringBuilder strData = GetData();
            MyEncrypter.WriteData(_defaultPath, strData);
        }

        //Read properties method
        public bool InfoRead()
        {
            DataEncrypter MyEncrypter = new DataEncrypter();
            string strData;
            if (MyEncrypter.ReadData(_defaultPath) == true)
            {
                strData = MyEncrypter.Data;
                ParseData(strData);
                return true;
            }
            return false;
        }
        #endregion
    }
    #endregion
}
