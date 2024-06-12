using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.Enrolments
{
    public class Enrolment
    {
        public int _id;
        public int _albumid;
        public int _singerId;

        public Enrolment(int id,int albumid,int singerid) {
            _albumid = albumid;
            _singerId = singerid;
            _id = id;
        }

        public Enrolment(int albumid,int singerid) { 
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

       
        public string DescriereEnrolment()
        {
            string dexc = " ";
            dexc += "IdEnrolment: " + this.Id + "\n";
            dexc += "AlbumId: " + this.AlbumId + "\n";
            dexc += "SingerId: " + this.SingerId + "\n";
            return dexc;
        }







    }
}
