using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.ClaseMusic
{
    internal class Opera:Music
    {
        
        private int _persconcert;
        private string _dataconcert;

        public Opera(string Propietati) : base(Propietati)
        {
            string[] cuvinte = Propietati.Split(',');
            
            this._persconcert = int.Parse(cuvinte[4]);
            this._dataconcert = cuvinte[5];

        }
        public Opera (string Type,int id,int albumid,string namesong,string namepiesa,int nrpers,string dataconcert):base(Type,id,albumid,namesong)
        {
            this._persconcert = nrpers;
            this._dataconcert = dataconcert;
        }
        public Opera()
        {


        }
        
        public int Persconcert
        {
            get { return _persconcert; }
            set { _persconcert = value; }
        }
        public string Dataconcert
        {
            get { return _dataconcert; }
            set { _dataconcert = value; }
        }

        public override string Descriere()
        {
            string text = " " + base.Descriere();
            text += "Nr de pers: " + Persconcert + "\n";
            text += "Data Concert: " + Dataconcert + "\n";
            return text;

        }

        public  string DescriereOpera()
        {
            string text = " ";
            text += "Nr de pers: " + Persconcert + "\n";
            text += "Data Concert: " + Dataconcert + "\n";
            return text;

        }









    }
}
