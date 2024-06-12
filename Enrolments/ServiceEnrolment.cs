﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.Enrolments
{
    public class ServiceEnrolment
    {
        private List<Enrolment> _enrolments;

        public ServiceEnrolment() { 
        
           _enrolments = new List<Enrolment>();
            load();
        
        
        
        }

        public void load()
        {

            Enrolment e1 = new Enrolment(GenerateIdUnique(), 17945, 1);
            Enrolment e2 = new Enrolment(GenerateIdUnique(), 90, 2);
            Enrolment e3 = new Enrolment(GenerateIdUnique(), 88, 3);
            Enrolment e4 = new Enrolment(GenerateIdUnique(), 86, 5);
            Enrolment e5 = new Enrolment(GenerateIdUnique(), 92, 4);
            Enrolment e6 = new Enrolment(GenerateIdUnique(), 210, 6);
            Enrolment e7 = new Enrolment(GenerateIdUnique(), 195, 2);

            _enrolments.Add(e1);
            _enrolments.Add(e2);
            _enrolments.Add(e3);
            _enrolments.Add(e4);
            _enrolments.Add(e5);
            _enrolments.Add(e6);
            _enrolments.Add(e7);

        }
        public void AfisareEnrolments()
        {
            for(int i = 0; i < _enrolments.Count; i++)
            {
                Console.WriteLine(_enrolments[i].DescriereEnrolment());

            }


        }

        public Enrolment GetEnrolmentById(int id)
        {
            List<Enrolment> enrol = _enrolments;
            for (int i = 0; i < enrol.Count; i++)
            {
                if (enrol[i].Id == id)
                {
                    return enrol[i];

                }
            }
            return null;
        }
        public int GenerateIdUnique()
        {
            Random rand = new Random();
            int random = rand.Next(10, 10000);

            while (GetEnrolmentById(random) != null)
            {
                random = rand.Next(10, 10000);
            }
            return random;


        }
        public void adaugareEnrol(Enrolment enrolnew)
        {
            enrolnew.Id = this.GenerateIdUnique();
            this._enrolments.Add(enrolnew);

        }

        public bool DeleteEnrolById(int idEnr)
        {
            List<Enrolment> enrolment = _enrolments;
            for (int i = 0; i < enrolment.Count; i++)
            {
                if (idEnr.Equals(enrolment[i].Id))
                {
                    this._enrolments.Remove(enrolment[i]);
                    return true;
                }


            }
            return false;


        }

        public List<int> GetAllEnrolBySingerId(int SingerId)
        {
            List<int> enrol = new List<int>();
            for (int i = 0; i < _enrolments.Count; i++)
            {
                if (SingerId == _enrolments[i].SingerId)
                {
                    enrol.Add(_enrolments[i].AlbumId);

                }


            }
            return enrol;

        }
        public List<int> GetALlAlbumsBySinegrId(List<int> SingerId)
        {

            List<int> IdALbum = new List<int>();
            for (int i = 0; i < _enrolments.Count; i++)
            {

                if (SingerId.Contains(_enrolments[i].SingerId))
                {

                    IdALbum.Add(_enrolments[i].AlbumId);
                }

            }
            return IdALbum;
        }

        public Enrolment GetEnrolmentByALbumId(int AlbumId)
        {
            for (int i = 0; i < _enrolments.Count; i++)
            {
                if (_enrolments[i].AlbumId.Equals(AlbumId))
                {
                    return _enrolments[i];
                }



            }
            return null;

        }






























    }
}
