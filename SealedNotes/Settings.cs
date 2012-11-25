using System;
using System.IO;
using System.Xml;

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
    #region Settings class
    ///<summary>
    /// Settings class describe such external settings of application like Folder paths , File names and etc.
    ///</summary>
    public class Settings
    {
        #region Private Member Variables
        private String _saveToFile;
        private String _saveToFolder;
        #endregion

        #region Constructor
        public Settings(XmlNode settingsNode)
        {
            this.SaveToFile = settingsNode.Attributes["SaveToFile"].Value;
            this.SaveToFolder = settingsNode.Attributes["SaveToFolder"].Value;
        }

        public Settings(String ToFile, String ToFolder)
        {
            this.SaveToFile = ToFile;
            this.SaveToFolder = ToFolder;
        }

        public Settings():
            this("notes.txt", "\\My Documents")
        {
        }
        #endregion

        #region Public Properties
        public String SaveToFile
        {
            private set
            {
                _saveToFile = value;
            }
            get
            {
                return _saveToFile;
            }
        }

        public String SaveToFolder
        {
            private set
            {
                _saveToFolder = value;
            }
            get
            {
                return _saveToFolder;
            }
        }
        #endregion
    }
    #endregion

}
