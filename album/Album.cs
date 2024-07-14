using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMusicPortal.ClaseMusic;

namespace OnlineMusicPortal.album
{
    public  class Album
    {
        private int _albumId;
        private string _name;
        private string _dataiesire;



        public Album(int idalbum, string name, string Dataiesire)
        {
            _albumId = idalbum;
            _name = name;
            _dataiesire = Dataiesire;

        }


        public int AlbumId
        {
            get { return _albumId; }
            set { _albumId = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Dataiesire
        {
            get { return _dataiesire; }
            set { _dataiesire = value; }
        }

        public string DescriereAlbum()
        {
            string text = " ";
            text += "Album name: " + Name + "\n";
            text += "Release date: " + Dataiesire + "\n";
            return text;
        }



















    }
}
