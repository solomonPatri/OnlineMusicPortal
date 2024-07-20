using OnlineMusicPortal.ClaseMusic;
using OnlineMusicPortal.Enrolments;
using OnlineMusicPortal.Service;
using OnlineMusicPortal.Utilizatori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.EnrolmentFollower
{
    internal class ServiceEnrolmentFollower
    {
        private List<EnrolFollower> _fenrolment;

        public ServiceEnrolmentFollower() { 
        
        _fenrolment = new List<EnrolFollower>();
            load();
        }

        public void load()
        {
            EnrolFollower ef1 = new EnrolFollower(GenerateIdUnique(),50,12,30);
            EnrolFollower ef3 = new EnrolFollower(GenerateIdUnique(), 51,24, 45);
            EnrolFollower ef4 = new EnrolFollower(GenerateIdUnique(), 50,22, 40);
            EnrolFollower ef5 = new EnrolFollower(GenerateIdUnique(),52, 26, 31);
            EnrolFollower ef6 = new EnrolFollower(GenerateIdUnique(),50,28, 305);
            EnrolFollower ef7 = new EnrolFollower(GenerateIdUnique(), 58,19, 40);

            _fenrolment.Add(ef1);
            _fenrolment.Add(ef3);
            _fenrolment.Add(ef4);
            _fenrolment.Add(ef5);
            _fenrolment.Add(ef6);
            _fenrolment.Add(ef7);



        }
        public EnrolFollower GetEnrolmentFollById(int id)
        {
            EnrolFollower enrol = new EnrolFollower();
           for(int i=0;i<_fenrolment.Count;i++)
            {
                if (_fenrolment[i].IdEnrol.Equals(id))
                {
                    enrol = _fenrolment[i];
                    return enrol;


                }

            }
           return null;
        }
        public EnrolFollower GetEnrolmentFollByIdSinger(int id)
        {
            EnrolFollower enrol = new EnrolFollower();
            for (int i = 0; i < _fenrolment.Count; i++)
            {
                if (_fenrolment[i].SingerId.Equals(id))
                {
                    enrol = _fenrolment[i];
                    return enrol;


                }

            }
            return null;
        }
        public EnrolFollower GetEnrolmentFollByIdSong(int id)
        {
            EnrolFollower enrol = new EnrolFollower();
            for (int i = 0; i < _fenrolment.Count; i++)
            {
                if (_fenrolment[i].SongId.Equals(id))
                {
                    enrol = _fenrolment[i];
                    return enrol;


                }

            }
            return null;
        }
        public int GenerateIdUnique()
        {
            Random rand = new Random();
            int random = rand.Next(10, 10000);

            while (GetEnrolmentFollById(random) != null)
            {
                random = rand.Next(10, 10000);
            }
            return random;


        }
        public int GenerateIdUniqueSinger()
        {
            Random random = new Random();
            int randoms = random.Next(10, 100);
            while(GetEnrolmentFollByIdSinger(randoms)!= null)
            {
                randoms = random.Next(10, 100);

            }
            return randoms;



        }
        public int GenerateIdUniqueSong()
        {
            Random random = new Random();
            int randoms = random.Next(30, 100);
            while (GetEnrolmentFollByIdSong(randoms) != null)
            {
                randoms = random.Next(30, 100);

            }
            return randoms;



        }

        public List<int> GetSingerIdByFollId(int idFollo)
        {
            List<int> singers = new List<int>();
            for(int i = 0; i < _fenrolment.Count; i++)
            {
                if (_fenrolment[i].IdFollower == idFollo)
                {
                    singers.Add(_fenrolment[i].SingerId);

                }

            }
            return singers; 




        }

        public List<int> GetSongsByFollId(int idFoll)
        {
            
            List<int> songs = new List<int>();
            for(int i = 0; i < _fenrolment.Count; i++)
            {
                if (_fenrolment[i].IdFollower.Equals(idFoll))
                {
                    songs.Add(_fenrolment[i].SongId);

                }


            }
            return songs;




        }
 
        public void DeleteSongById( int idFollower,int idsong)
        {

            for(int i = 0; i < _fenrolment.Count; i++)
            {

                if (_fenrolment[i].IdFollower == idFollower && _fenrolment[i].SongId == idsong)
                {

                    _fenrolment.Remove(_fenrolment[i]);
                   
                }
            }
            

        }
        public bool VerficareDeleteSong(int idfollower,int SongId)
        {
            for (int i = 0; i < _fenrolment.Count; i++)
            {

                if (_fenrolment[i].IdFollower == idfollower && _fenrolment[i].SongId == SongId)
                {
                    return true;
                    
                    
                }
            }
            return false;
        }

        public void AdaugareEnrolmentFoll(EnrolFollower newenrol)
        {
            newenrol.IdEnrol = GenerateIdUnique();
            this._fenrolment.Add(newenrol);
                
                
        }

        public bool VerificareDeleteSinger(int idfollo,int SingerId)
        {
            for(int i = 0; i < _fenrolment.Count; i++)
            {
                if (_fenrolment[i].IdFollower == idfollo && _fenrolment[i].SingerId == SingerId)
                {
                    return true;


                }

            }

            return false;
        }
        public void DeleteSingerById(int idfoll, int SingerId)
        {
            for (int i = 0; i < _fenrolment.Count; i++)
            {
                if (_fenrolment[i].IdFollower == idfoll && _fenrolment[i].SingerId == SingerId)
                {
                    _fenrolment.Remove(_fenrolment[i]);


                }

            }
        }       






    }
}
