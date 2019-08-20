using System;

namespace DocumentManagementSystem.Models
{
    public class Document : Folder
    {
        private string documentType;

        public string DocumentType
        {
            get { return documentType; }
            set
            {
                if (value.Length > 0)
                {
                    documentType = value;
                }
                else
                {
                    throw new Exception("The length of the document type must be greater than zero characters");
                }
            }
        }

        private DateTime creationDate;

        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
    }
}
