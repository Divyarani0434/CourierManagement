using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagement.Entities
{
    internal class User
    {
        private int userID;
        private string userName;
        private string email;
        private string password;
        private long contactNumber;
        private string address;

      
      
        public User() { }

        public User(int userID, string userName, string email, string password, long contactNumber, string address)
        {
            this.userID = userID;
            this.userName = userName;
            this.email = email;
            this.password = password;
            this.contactNumber = contactNumber;
            this.address = address;
        }

        public int UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public long ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Address { get => address; set => address = value; }

        public override string ToString()
        {
            return $"User{{userID={userID}, userName='{userName}', email='{email}', password='{password}', contactNumber={contactNumber}, address='{address}'}}";
        }
    }
}
    

