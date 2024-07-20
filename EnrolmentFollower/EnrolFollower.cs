using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace OnlineMusicPortal.EnrolmentFollower
{
    internal class EnrolFollower
    {
        private int _idenrol;
        private int _idFollower;
        private int _singerid;
        private int _songid;

        public EnrolFollower(int idenrol,int idFollower,int SingerId,int songId)
        {
            this._idenrol = idenrol;
            this._singerid = SingerId;
            this._songid = songId;
            this._idFollower = idFollower;

        }

        public EnrolFollower()
        {

        }


        public int IdEnrol
        {
            get { return _idenrol; }
            set { _idenrol = value; }
        }
        public int SingerId
        {
            get { return _singerid; }
            set { _singerid = value; }
        }

        public int SongId
        {
            get { return _songid; }
            set { _songid = value; }
        }

        public int IdFollower
        {
            get { return _idFollower; }
            set { _idFollower = value; }
        }
        public string DescriereEnrolment()
        {
            string text = " ";
            text+= "idenrol:";
            text += "SingerId: ";
            text += "SongId: ";
            return text;


        }


















    }
}
