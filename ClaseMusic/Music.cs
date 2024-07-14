using OnlineMusicPortal.album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.ClaseMusic
{
    public class Music
    {
        private string _type;
        private int _id;
        private int _albumId;
        private string _namesong;
      


       public Music(string Propietati)
        {
            string[] cuvinte = Propietati.Split(',');
            this._type = cuvinte[0];
            this._id = int.Parse(cuvinte[1]);
            this._albumId = int.Parse(cuvinte[2]);
            this._namesong = cuvinte[3];
        }
        public Music(string type,int _id,int albumId,string namesong)
        {
            this._type = type;
            this._id = _id;
            this._albumId = albumId;
            this._namesong=namesong;

        }
        public Music()
        {

        }
        public int Id {
            get { return _id; }
            set { _id = value; }
        
        }
        public int AlbumId
        {
            get { return _albumId; }
            set { _albumId = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Namesong
        {
            get { return _namesong; }
            set { _namesong = value; }
        }


        public virtual string Descriere()
        {
            string text = " ";
            text += "Type: " + this.Type + "\n";
            text += "Name Song: " + this.Namesong + "\n";
            return text;
        }

        










    }
}
