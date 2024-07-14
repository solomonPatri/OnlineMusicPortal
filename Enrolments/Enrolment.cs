using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.Enrolments
{
    public class Enrolment
    {
        private int _id;
        private int _albumid;
        private int _singerId;
        private int _IdConcerte;

        public Enrolment(int id,int albumid,int singerid,int idConcert) {
            _albumid = albumid;
            _singerId = singerid;
            _id = id;
        }

        public Enrolment(int albumid,int singerid,int idconcert) { 
        _albumid=albumid;
        _singerId=singerid;
        
 
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int AlbumId
        {
            get { return _albumid; }
            set { _albumid = value; }
        }
        public int SingerId
        {
            get { return _singerId; }
            set { _singerId = value; }
        }

        public int IdConcerte
        {    get { return _IdConcerte; }
            set { _IdConcerte = value; }
        }

       
        public string DescriereEnrolment()
        {
            string dexc = " ";
            dexc += "IdEnrolment: " + this.Id + "\n";
            dexc += "AlbumId: " + this.AlbumId + "\n";
            dexc += "SingerId: " + this.SingerId + "\n";
            dexc += "IdConcerte: " + this.IdConcerte + "\n";
            return dexc;
        }







    }
}
