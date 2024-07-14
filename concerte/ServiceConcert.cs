using OnlineMusicPortal.album;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.concerte
{
    internal class ServiceConcert
    {
        private List<Concerte> _concerts;

        public ServiceConcert()
        {
            _concerts = new List<Concerte>();
            this.load();


        }
        public void load()
        {
            Concerte c1 = new Concerte(20,"Butterfly Tour","Spain","Madrid","2010-12-10",14231);
            Concerte c2 = new Concerte(21, "Rock On", "USA", "Los Angeles", "2011-06-15", 20000);
            Concerte c3 = new Concerte(22, "Classical Evenings", "Germany", "Berlin", "2012-09-23", 15000);
            Concerte c4 = new Concerte(23, "Jazz Nights", "France", "Paris", "2013-05-12", 18000);
            Concerte c5 = new Concerte(24, "Pop Extravaganza", "UK", "London", "2014-11-30", 25000);
            Concerte c6 = new Concerte(25, "Metal Mayhem", "Sweden", "Stockholm", "2015-08-20", 13000);
            Concerte c7 = new Concerte(26, "Indie Fest", "Canada", "Toronto", "2016-07-18", 17000);
            Concerte c8 = new Concerte(27, "Electronic Beats", "Netherlands", "Amsterdam", "2017-04-05", 22000);
            Concerte c9 = new Concerte(28, "Hip-Hop Hooray", "USA", "New York", "2018-10-22", 21000);
            Concerte c10 = new Concerte(29, "Country Roads", "Australia", "Sydney", "2019-03-11", 16000);
            Concerte c11 = new Concerte(30, "Reggae Vibes", "Jamaica", "Kingston", "2020-02-25", 14000);
            Concerte c12 = new Concerte(31, "Blues Bash", "USA", "Chicago", "2021-11-17", 19000);
            Concerte c13 = new Concerte(32, "Folk Fiesta", "Ireland", "Dublin", "2022-09-30", 12000);

            _concerts.Add(c1);
            _concerts.Add(c2);
            _concerts.Add(c3);  
            _concerts.Add(c4);
            _concerts.Add(c5);
            _concerts.Add(c6);
            _concerts.Add(c7);
            _concerts.Add(c8);
            _concerts.Add(c9);
            _concerts.Add(c10);
            _concerts.Add(c11);
            _concerts.Add(c12);
            _concerts.Add(c13);

        }

        public void Afisare()
        {
            for(int i = 0; i < _concerts.Count; i++)
            {
                Console.WriteLine(_concerts[i].DescriereConcert());
            }
        }
        public Concerte GetConcertById(int idConc)
        {
            for (int i = 0; i < _concerts.Count; i++)
            {
                if (_concerts[i].IdConcert.Equals(idConc))
                {
                    return _concerts[i];
                }


            }
            return null;


        }
        public void AfisareConcertById(int id)
        {
            for(int i=0; i < _concerts.Count; i++)
            {
                if (_concerts[i].IdConcert.Equals(id))
                {
                    Console.WriteLine(_concerts[i].DescriereConcert());
                }
            }
        }
        public int GenerateRandomId()
        {
            Random random = new Random();
            int nrrandom = random.Next(10, 100);
            while (GetConcertById(nrrandom) != null)
            {

                nrrandom = random.Next(10, 100);

            }


            return nrrandom;


        }

        public void adaugareConcert(Concerte concert)
        {
            concert.IdConcert = GenerateRandomId();
            this._concerts.Add(concert);


        }

        public List<Concerte> GetAllConcertById(List<int> ids)
        {
            List<Concerte> concerte = new List<Concerte>();
            for(int i =0;i<_concerts.Count;i++)
            {
                if (ids.Contains(_concerts[i].IdConcert))
                {
                    concerte.Add(_concerts[i]);

                }

            }
            return concerte;




        }

        public bool VerificareConcerte(string name)
        {
            for(int i =0; i < _concerts.Count; i++)
            {
                if (_concerts[i].NameConcert.Equals(name))
                {

                    return true;

                }



            }
            return false;




        }








    }
}
