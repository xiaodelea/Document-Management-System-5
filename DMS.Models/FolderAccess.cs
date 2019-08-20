using System;

namespace DocumentManagementSystem.Models
{
    public class FolderAccess
    {
        public Folder Folder { get; set; }

        private string accessLevel;

        public string AccessLevel
        {
            get { return accessLevel; }
            set
            {
                if (value.Length > 0)
                {
                    accessLevel = value;
                }
                else
                {
                    throw new Exception("Access level title length must bt greater than zero symbols");
                }
            }
        }


        public UserGroup CurrentUserGroup { get; set; }
        public int CurrentUserGroupId { get; set; }

        public User CurrentUser { get; set; }
        public int CurrentUserId { get; set; }
    }
}
