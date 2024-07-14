using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMusicPortal.ClaseMusic;

namespace OnlineMusicPortal.Utilizatori
{
    internal class Singer:User
    {
        private int _id;
        private string _name;
        private string _mobile;
        private string _adress;
        private int _age;

        public Singer(string Propietati) : base(Propietati)
        {
            string[] cuvinte = Propietati.Split(',');
            _id = int.Parse(cuvinte[4]);
            _name = cuvinte[5];
            _mobile = cuvinte[6];
            _adress = cuvinte[7];
            _age = int.Parse(cuvinte[8]);

        }
        public Singer(int idUser,string email,string pass,string type,int idSinger,string name,string mobile,string adress,int age) : base(idUser,email,pass,"Singer")
        {

            Id = idSinger;
            Name = name;
            Mobile = mobile;
            Email = email;
            Adress = adress;

        }

        public int Id
        {
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

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }
        public int Age
        {
            get { return Age;}
            set { Age = value; }
        }

        public override string Descriere()
        {
            string text = " " + base.Descriere();
            text += "Singer Name: " + Name + "\n";
            text += "Mobile: " + Mobile + "\n";
            text += "Adress: " + Adress + "\n";
            text += "Age: " + Age + "\n";
            return text;

        }
        public  string DescriereSinger()
        {
            string text = " ";
            text += "IdSinger: " + "\n";
            text += "Singer Name: " + Name + "\n";
            text += "Mobile: " + Mobile + "\n";
            text += "Adress: " + Adress + "\n";
            text += "Age: " + Age + "\n";
            return text;

        }













    }
}
