using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Drawing;
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
    #region Class for encrypting Data by different algorithms
    ///<summary>
    /// It manage by the keys and vectors, encryption service proveiders and etc.
    ///</summary>
    public class DataEncrypter
    {
        #region Private Member Variables
        private EncryptionType _encryptionAlgorithm;
        private String _key;
        private String _vector;
        private String _data;
        #endregion

        #region Private Methods
        //
        private void CheckUpPass()
        {
            switch (_encryptionAlgorithm)
            {
                case EncryptionType.TripleDES:
                    if (_vector.Length < 4) //8)
                        while (_vector.Length < 4) //8)
                        {
                            _vector += "a";
                        }
                    else
                        _vector = _vector.Substring(0, 4);//8);
                    break;
                case EncryptionType.RC2:
                    if (_vector.Length < 4) //8)
                        while (_vector.Length < 4) //8)
                        {
                            _vector += "b";
                        }
                    else
                        _vector = _vector.Substring(0, 4);//8);
                    break;
                case EncryptionType.Rijndael:
                    if (_vector.Length < 8) //16)
                        while (_vector.Length < 8) //16)
                        {
                            _vector += "c";
                        }
                    else
                        _vector = _vector.Substring(0, 8); //16);
                    break;
                default:
                    break;
            }
        }

        //
        private void CheckUpKey()
        {
            switch (_encryptionAlgorithm)
            {
                case EncryptionType.TripleDES:
                    if (_key.Length < 12) //24)
                        while (_key.Length < 12) //24)
                        {
                            _key += "d";
                        }
                    else
                        _key = _key.Substring(0, 12); //24);
                    break;
                case EncryptionType.RC2:
                    if (_key.Length < 8) //16)
                        while (_key.Length < 8) //16)
                        {
                            _key += "e";
                        }
                    else
                        _key = _key.Substring(0, 8); //16);
                    break;
                case EncryptionType.Rijndael:
                    if (_key.Length < 16) //32)
                        while (_key.Length < 16) //32)
                        {
                            _key += "f";
                        }
                    else
                        _key = _key.Substring(0, 16); //32);
                    break;
                default:
                    break;
            }
        }

        //
        private SymmetricAlgorithm GetSymmetricAlgorithm()
        {
            SymmetricAlgorithm Temp = null;
            switch (_encryptionAlgorithm)
            {
                case EncryptionType.TripleDES:
                    Temp = new TripleDESCryptoServiceProvider();
                    break;
                case EncryptionType.RC2:
                    Temp = new RC2CryptoServiceProvider();
                    break;
                case EncryptionType.Rijndael:
                    Temp = new RijndaelManaged();
                    break;
                default:
                    Temp = new TripleDESCryptoServiceProvider();
                    break;
            }
            return Temp;
        }
        #endregion

        #region Constructor
        public DataEncrypter(EncryptionType Algo, String Key, String Vector)
        {
            _encryptionAlgorithm = Algo;
            _key = Key;
            _vector = Vector;
            _data = "";
        }

        public DataEncrypter(EncryptionType Algo, String Key)
            : this(Algo, Key, "abcdefgi")
        {}

        public DataEncrypter(EncryptionType Algo)
            : this(Algo, "Zg56j;821ghjKW34FD76AS87OP99", "JFV3016G")
        {}

        public DataEncrypter()
            : this(EncryptionType.TripleDES, "Zg56j;821ghjKW34FD76AS87OP99", "JFV3016G")
        {}
        #endregion

        #region Public Properties
        public String Data
        {
            set
            {
                _data = value;
            }
            get
            {
                return _data;
            }
        }
        #endregion

        #region Public methods
        //
        public bool WriteData(string FilePath, StringBuilder strData)
        {
            CheckUpKey();
            CheckUpPass();
            try
            {
                FileInfo info = new FileInfo(FilePath);
                if (info.Exists == true)
                {
                    info.Delete();
                }
                Stream Fout = null;
                CryptoStream CryptoFout = null;
                try
                {
                    SymmetricAlgorithm SA = GetSymmetricAlgorithm();
                    Fout = new FileStream(FilePath, FileMode.CreateNew, FileAccess.Write);
                    ICryptoTransform SAEncrypt = SA.CreateEncryptor(Encoding.Unicode.GetBytes(_key),//Encoding.ASCII.GetBytes(_key),
                                                                    Encoding.Unicode.GetBytes(_vector));//Encoding.ASCII.GetBytes(_vector));
                    CryptoFout = new CryptoStream(Fout, SAEncrypt, CryptoStreamMode.Write);
                    byte[] notesData = Encoding.Unicode.GetBytes(strData.ToString());
                    try
                    {
                        CryptoFout.Write(notesData, 0, notesData.Length);
                    }
                    catch (NotSupportedException)
                    {
                        MessageBox.Show("Can't check data path!");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Can't check data path!");
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Can't check data path!");
                    }
                    finally
                    {
                        CryptoFout.Close();
                        Fout.Close();
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("IO error occur!");
                    return false;
                }
                catch (CryptographicException)
                {
                    MessageBox.Show("Cryptographic error occur during writing!");
                    return false;
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Can't check data path!");
            }
            catch (System.Security.SecurityException)
            {
                MessageBox.Show("Can't check data path because of security settings!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Can't check data path!");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Unauthorized access!");
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("Path to data file is too long!");
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Can't check data path!");
            }
            return true;
        }

        //
        public bool ReadData(string FilePath)
        {
            CheckUpKey();
            CheckUpPass();
            try
            {
                FileInfo info = new FileInfo(FilePath);
                if (info.Exists == true)
                {
                    Stream Fin = null;
                    CryptoStream CryptoFin = null;
                    try
                    {
                        Fin = new FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite);
                        SymmetricAlgorithm SB = GetSymmetricAlgorithm();
                        ICryptoTransform SBDecrypt = SB.CreateDecryptor(Encoding.Unicode.GetBytes(_key), //Encoding.ASCII.GetBytes(_key),
                                                                        Encoding.Unicode.GetBytes(_vector));// Encoding.ASCII.GetBytes(_vector));
                        CryptoFin = new CryptoStream(Fin, SBDecrypt, CryptoStreamMode.Read);
                        int length = (int)Fin.Length;
                        byte[] btReData = new byte[length];      
                        try
                        {
                            CryptoFin.Read(btReData, 0, length);
                            _data = Encoding.Unicode.GetString(btReData, 0, btReData.Length);
                        }
                        catch (NotSupportedException)
                        {
                            MessageBox.Show("Can't check data path!");
                        }
                        catch(ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("Can't check data path!");
                        }
                        catch(ArgumentException)
                        {
                            MessageBox.Show("Can't check data path!");
                        }
                        finally
                        {
                            CryptoFin.Close();
                            Fin.Close();
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("IO error occur during reading!");
                        return false;
                    }
                    catch (CryptographicException)
                    {
                        MessageBox.Show("Cryptographic error! Check up your key and password!");
                        return false;
                    }
                    return true;
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Can't check data path!");
            }
            catch (System.Security.SecurityException)
            {
                MessageBox.Show("Can't check data path because of security settings!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Can't check data path!");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Unauthorized access!");
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("Path to data file is too long!");
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Can't check data path!");
            }
            return false;
        }
        #endregion
    }
    #endregion
}
