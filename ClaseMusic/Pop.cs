using OnlineMusicPortal.ClaseleUlterioare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.ClaseMusic
{
    internal class Pop:Music
    {
        private string _namesinger;
        private int _top;
        
        public Pop(string Propietati):base(Propietati)
        {
            string[] cuvinte = Propietati.Split(',');
            this._namesinger = cuvinte[4];
            this._top = int.Parse(cuvinte[5]);  
        }

        public Pop(string type, int _id, int albumId, string Description,string namesinger,int top) : base(type, _id, albumId, Description)
        {
            this._namesinger=namesinger;
            this._top=top;

        }
        public Pop(string namesinger, int top)
        {
            this._namesinger=namesinger;
            this._top=top;
        }

        public string NameSinger
        {
            get { return this._namesinger; }
            set { this._namesinger = value;}
        }
        public int Top
        {
            get { return this._top; }
            set { this._top = value;}
        }


        public override string Descriere()
        {
             string text=" "+base.Descriere();
            text += "Singer Name: " + this.NameSinger + "\n";
            text += "Top:" + this.Top + "\n";
            return text;
        }

        public string DescrierePop()
        {
            string text = " ";
            text += "Singer Name: " + this.NameSinger + "\n";
            text += "Top:" + this.Top + "\n";
            return text;

        }







    }
}
