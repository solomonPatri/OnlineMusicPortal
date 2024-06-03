using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.ClaseMusic
{
    internal class Singer:Music
    {
        private int _id;
        private string _name;
        private string _mobile;
        private string _email;
        private string _adress;
       
        public Singer(string Propietati) : base(Propietati)
        {
            string[] cuvinte = Propietati.Split(',');
            this._id = int.Parse(cuvinte[4]);
            this._name= cuvinte[5];
            this._email = cuvinte[6];
            this._adress = cuvinte[7];
            this._mobile = cuvinte[8];
        }

        public Singer(int id, string name, string mobile, string email, string adress):base () { 

            Id = id;
            Name = name;
            Mobile = mobile;
            Email = email;
            Adress = adress;
           
        }

        public int Id { 
            get { return _id; }
            set { _id = value; } 
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }


        public override string Descriere()
        {
            string text = " "+base.Descriere();
            text+= "Singer Name: " + this.Name + "\n";
            text += "Email:" + this.Email + "\n";
            text += "Mobile: " + this.Mobile + "\n";
            text += "Adress: " + this.Adress + "\n";
            return text;

        }
        public  string DescriereSinger()
        {
            string text = " ";
          text += "Singer Name: " + this.Name + "\n";
            text += "Email:" + this.Email + "\n";
            text += "Mobile: " + this.Mobile + "\n";
            text += "Adress: " + this.Adress + "\n";
            return text;

        }













    }
}
