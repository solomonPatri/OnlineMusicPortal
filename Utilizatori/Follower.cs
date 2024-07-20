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
       
        private string _name;
        private int _followYear;

        
        public Follower(string Propietati): base(Propietati)
        {
            string[] cuvinte = Propietati.Split(",");
            
            _name = cuvinte[4];
            _followYear = int.Parse(cuvinte[5]);

        }
        public Follower (string type,int idUser, string email,string pass, string name, int followYear) : base("Follower",idUser,email,pass)
        {
          
            this._name = name;
            this._followYear = followYear;

        }

        public Follower(int Id,string name,int yearFoll):base(Id)
        {
          
            this._name = name;
            this._followYear = yearFoll;


        }
        public Follower()
        {


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
            
            text += "Follower name: " + Name + "\n";
            text += "Follow Year: " + FollowYear + "\n";
            return text;
        }




    }
}
