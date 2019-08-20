using System;

namespace DocumentManagementSystem.Models
{
    public class User
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
                    throw new Exception("User id must be greater than zero");
                }
            }
        }

        private string login;

        public string Login
        {
            get { return login; }
            set
            {
                if (value.Length > 0)
                {
                    login = value;
                }
                else
                {
                    throw new Exception("The length of the user login must be greater than zero characters");
                }
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length > 0)
                {
                    login = value;
                }
                else
                {
                    throw new Exception("The length of the user password must be greater than zero characters");
                }
            }
        }

        public int CurrentUserGroupId { get; set; }
        public UserGroup CurrentUserGroup { get; set; }
    }
}
