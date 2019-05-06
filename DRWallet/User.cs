using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRWallet
{
    class User
    {

        public User(int id, string user, string fname, string lname, string email) {
            puID = id;
            puUser = user;
            puFName = fname;
            puLName = lname;
            puEmail = email;
        }

        private int puID;
        private string puUser;
        private string puFName;
        private string puLName;
        private string puEmail;

        public int uID
        {
            get
            {
                return puID;
            }
        }

        public string uUser {
            get
            {
                return puUser;
            }
            set
            {
                puUser = value;
            }
        }

        public string uFName {
            get
            {
                return puFName;
            }
            set
            {
                puFName = value;
            }
        }

        public string uLName
        {
            get
            {
                return puLName;
            }
            set
            {
                puLName = value;
            }
        }

        public string uEmail
        {
            get
            {
                return puEmail;
            }
            set
            {
                puEmail = value;
            }
        }
    }
}
