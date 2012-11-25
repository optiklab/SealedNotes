using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;

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

    #region Global enums
    public enum EncryptionType
    {
        TripleDES,
        RC2,
        Rijndael
    };
    #endregion

    #region Class Note
    ///<summary>
    /// Class describe one Note for SealedNotes application
    ///</summary>
    public class Note : IComparable
    {
        #region Private Member Variables
        private DateTime _dateOfCreation;
        private DateTime _dateOfLastAccess;
        private DateTime _dateOfUpdate;
        private String _noteName;
        private String _noteText;
        #endregion

        #region Public Properties
        public String Text
        {
            set
            {
                _noteText = value;
            }
            get
            {
                return _noteText;
            }
        }

        public String Name
        {
            set
            {
                _noteName = value;
            }
            get
            {
                return _noteName;
            }
        }

        public DateTime DateOfCreation
        {
            set
            {
                _dateOfCreation = value;
            }
            get
            {
                return _dateOfCreation;
            }
        }

        public DateTime DateOfLastAccess
        {
            set
            {
                _dateOfLastAccess = value;
            }
            get
            {
                return _dateOfLastAccess;
            }
        }

        public DateTime DateOfUpdate
        {
            set
            {
                _dateOfUpdate = value;
            }
            get
            {
                return _dateOfUpdate;
            }
        }
        #endregion

        #region Constructors
        public Note(String Name, String Text, DateTime CreationDate, DateTime UpdateDate, DateTime LastAccessDate)
        {
            _noteName = Name;
            _noteText = Text;
            _dateOfCreation = CreationDate;
            _dateOfLastAccess = LastAccessDate;
            _dateOfUpdate = UpdateDate;
        }

        public Note(String Name, String Text)
        {
            _noteName = Name;
            _noteText = Text;
            DateTime dt = DateTime.Now;
            _dateOfCreation = dt;
            _dateOfLastAccess = dt;
            _dateOfUpdate = dt;
        }

        public Note(String Name)
            : this(Name, String.Empty)
        {}
        #endregion

        #region Public Methods
        int IComparable.CompareTo(object Obj)
        {
            Note temp = (Note)Obj;
            if (this._noteName.CompareTo(temp._noteName) == 1)
                return 1;
            if (this._noteName.CompareTo(temp._noteName) == -1)
                return -1;
            else
                return 0;
        }
        #endregion
    }
    #endregion

    #region Class SealedNote
    ///<summary>
    /// Class contain collection of Notes and describe access methods to collection
    ///</summary>
    public class SealedNote
    {
        #region Private Member Variables
        private List<Note> NotesArray;
        #endregion
        
        #region Constructors
        public SealedNote()
        {
            NotesArray = new List<Note>();
        }
        #endregion

        #region Public Methods
        public void AddNote(Note NewNote)
        {
            NotesArray.Add(NewNote);
        }

        public void RemoveNoteAt(int Index)
        {
            NotesArray.RemoveAt(Index);
        }

        public String GetNoteText(int Index)
        {
            return NotesArray[Index].Text;
        }

        public String GetNoteName(int Index)
        {
            return NotesArray[Index].Name;
        }

        public DateTime GetNoteAccessDate(int Index)
        {
            return NotesArray[Index].DateOfLastAccess;
        }

        public DateTime GetNoteUpdateDate(int Index)
        {
            return NotesArray[Index].DateOfUpdate;
        }

        public DateTime GetNoteCreateDate(int Index)
        {
            return NotesArray[Index].DateOfCreation;
        }

        public int GetNoteCount()
        {
            return NotesArray.Count;
        }

        public void SetNoteText(int Index, String Text)
        {
            NotesArray[Index].Text = Text;
        }

        public void SetNoteName(int Index, String Name)
        {
            NotesArray[Index].Name = Name;
        }

        public void SetNoteAccessDate(int Index, DateTime Access)
        {
            NotesArray[Index].DateOfLastAccess = Access;
        }

        public void SetNoteUpdateDate(int Index, DateTime Update)
        {
            NotesArray[Index].DateOfUpdate = Update;
        }

        public void Sort()
        {
            try
            {
                NotesArray.Sort();
            }
            catch (InvalidOperationException)
            {
            }
        }
        #endregion
    }
    #endregion

}