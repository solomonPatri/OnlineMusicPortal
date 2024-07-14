using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.Utilizatori
{
    public class User
    {
        private int _id;
        private string _type;
        private string _email;
        private string _password;

        public User(string Propietati)
        {
            string[] cuvinte = Propietati.Split(',');
            _type = cuvinte[0];
            _id = int.Parse(cuvinte[1]);
            _email = cuvinte[2];
            _password = cuvinte[3];
        }
        public User(int id,string email,string password,string type)
        {
            this._id = id;
            this._email= email;
            this._password= password;
            this._type = type;

        }

        public User()
        {

        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public virtual string Descriere()
        {
            string text = " ";
            text += "Email: " + Email + "\n";
            text += "Password: " + Password + "\n";
            text += "Type: " + Type + "\n";
            return text;

        }

        public  string DescriereUser()
        {
            string text = " ";
            text += "Email: " + Email + "\n";
            text += "Password: " + Password + "\n";
            text += "Type: " + Type + "\n";
            return text;

        }












    }
}
