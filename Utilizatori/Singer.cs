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
        private string _name;
        private string _mobile;
        private string _adress;
        private int _age;

        public Singer(string Propietati) : base(Propietati)
        {
            string[] cuvinte = Propietati.Split(',');
            _name = cuvinte[4];
            _mobile = cuvinte[5];
            _adress = cuvinte[6];
            _age = int.Parse(cuvinte[7]);

        }
        public Singer(string type, int idSinger, string email, string pass, string name, string mobile, string adress, int age) : base("Singer", idSinger, email, pass)
        {
            _name = name;
            _mobile = mobile;
            _adress = adress;
            _age = age;

        }
        public Singer(string name,string mobile,string adress,int age)
        {
            this._name = name;
            this._mobile = mobile;
            this._adress = adress;
            this._age = age;
        }
        public Singer()
        {


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
            get { return _age;}
            set { _age = value; }
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
            text += "Singer Name: " + Name + "\n";
            text += "Mobile: " + Mobile + "\n";
            text += "Adress: " + Adress + "\n";
            text += "Age: " + Age + "\n";
            return text;

        }













    }
}
