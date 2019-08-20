using System;

namespace DocumentManagementSystem.Models
{
    public class Folder
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
                    throw new Exception("Folder id must be greater than zero");
                }
            }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length > 0)
                {
                    title = value;
                }
                else
                {
                    throw new Exception("The length of the group title must be greater than zero characters");
                }
            }
        }
    }
}
