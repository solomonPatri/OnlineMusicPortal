using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMusicPortal.album;
using OnlineMusicPortal.Utilizatori;

namespace OnlineMusicPortal.Utilizatori
{
    internal class Follower:User
    {
        private int _id;
        private string _name;
        private int _followYear;
        
        public Follower(string Propietati): base(Propietati)
        {
            string[] cuvinte = Propietati.Split(",");
            _id = int.Parse(cuvinte[4]);
            _name = cuvinte[5];
            _followYear = int.Parse(cuvinte[6]);

        }
        public Follower (int idUser, string email,string pass,string type,int idFoll, string name, int followYear) : base(idUser, email, pass, "Follower")
        {
            this._id = idFoll;
            this._name = name;
            this._followYear = followYear;

        }

        public Follower()
        {

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
        public int FollowYear
        {
            get { return _followYear; }
            set { _followYear = value; }
        }


        public override string Descriere()
        {
            string text = " " + base.Descriere();
            text += "Follower name: " + Name + "\n";
            text += "Follow Year: " + FollowYear + "\n";
            return text;
        }

        public  string DescriereFollower()
        {
            string text = " " ;
            text += "Id: " + "\n" ;
            text += "Follower name: " + Name + "\n";
            text += "Follow Year: " + FollowYear + "\n";
            return text;
        }




    }
}
