using System;

namespace DocumentManagementSystem.Models
{
    public class DocumentVersion
    {
        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    throw new Exception("Document version id must be greater than zero");
                }
            }
        }

        private string fileTitle;

        public string FileTitle
        {
            get { return fileTitle; }
            set
            {
                if (value.Length > 0)
                {
                    throw new Exception("File title length must bt greater than zero symbols");
                }
            }
        }
        public int CurrentUserId { get; set; }
        public User CurrentUser { get; set; }


        public DateTime creationDate { get; set; }

        public int CurrentDocumentId { get; set; }
        public Document CurrentDocument { get; set; }
    }
}
