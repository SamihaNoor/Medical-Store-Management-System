using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Credential
    {
        private int id, userId, type;
        private string password;

        public Credential() { }

        public Credential(int id, int userId, string password, int type)
        {
            this.id = id;
            this.userId = userId;
            this.password = password;
            this.type = type;
        }
        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public int UserId
        {
            set { this.userId = value; }
            get { return this.userId; }
        }
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }
        public int Type
        {
            set { this.type = value; }
            get { return this.type; }
        }
    }
}
