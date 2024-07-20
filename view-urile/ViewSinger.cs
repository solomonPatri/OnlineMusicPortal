using OnlineMusicPortal.Enrolments;
using OnlineMusicPortal.Utilizatori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMusicPortal.album;
using OnlineMusicPortal.Service;
using System.Runtime.CompilerServices;
using OnlineMusicPortal.concerte;
using OnlineMusicPortal.ClaseMusic;

namespace OnlineMusicPortal.view_urile
{
    internal class ViewSinger
    {
        private ServiceEnrolment _serviceEnrolment;
        private Singer _singer;
        private ServiceALbum _servicealbum;
        private ServiceMusic _servicemusic;
        private ServiceConcert _serviceConcert;


        public ViewSinger(Singer Singer)
        {
            _servicemusic = new ServiceMusic();
            _serviceEnrolment = new ServiceEnrolment();
            _servicealbum = new ServiceALbum();
            _serviceConcert = new ServiceConcert();
            _singer = Singer;
            play();


        }

        public void meniu()
        {
            Console.WriteLine("Introduceti ce doriti:" + "\n");
            Console.WriteLine("1->Afisare Albumele create:");
            Console.WriteLine("2->Melodiile La Album ales");
            Console.WriteLine("3->Afisare concertele de efectuat.");
            Console.WriteLine("4->Adaugare Album");
            Console.WriteLine("5->Adaugare Concert");
            Console.WriteLine("6->Modificare Album");
            Console.WriteLine("7->Stergere Melodie");
            Console.WriteLine("8->Deconectare");



        }
        public void play()
        {
            meniu();
            bool run = true;
            while (run)
            {
                int nrales = int.Parse(Console.ReadLine());
                switch (nrales)
                {
                    case 1:
                        AfisareAlbumeSinger();
                        break;
                    case 2:
                        AfisareMelodiiAlbum();
                        break;

                    case 3:
                        AfisareConcerte();
                        break;
                    case 4:
                        AdaugareAlbum();
                        break;
                    case 5:
                        AdaugareConcerte();
                        break;
                    case 6:
                        ModificareAlbum();
                        break;
                    case 7:
                        StergereMelodii();
                        break;
                    case 8:
                        run = false;
                        break;

                }




            }


        }

        public void AfisareAlbumeSinger()
        {
            Console.WriteLine("Albumele dumneavoastra sunt:" + "\n");
            List<int> list = _serviceEnrolment.GetAllEnrolBySingerId(_singer.Id);
            List<Album> listAlbum = _servicealbum.GetAllAlbumById(list);

            for (int i = 0; i < listAlbum.Count; i++)
            {
                Console.WriteLine(listAlbum[i].DescriereAlbum());

            }





        }

        public void AfisareMelodiiAlbum()
        {
            Console.WriteLine("Introduceti Numele albumului pentru melodii:" + "\n");

            string namealbum = Console.ReadLine();

            Album album = _servicealbum.GetALbumByName(namealbum);

            List<Music> songs = _servicemusic.ListaMusic(album.AlbumId);

            for (int i = 0; i < songs.Count ; i++)
            {
                Console.WriteLine(songs[i].Descriere());
            }



        }

        public void AfisareConcerte()
        {
            Console.WriteLine("Concertele sunt:" + "\n");
            List<int> list = _serviceEnrolment.GetAllConcerteEnrolBySingerId(_singer.Id);
            List<Concerte> concerts = _serviceConcert.GetAllConcertById(list);
            for (int i = 0; i < concerts.Count; i++)
            {
                Console.WriteLine(concerts[i].DescriereConcert());
            }

        } 
        public void AdaugareAlbum()
        {

            Console.WriteLine("Introduceti datele albumului");
            Console.WriteLine("Numele: ");
            string newname = Console.ReadLine();
            Console.WriteLine("Data de lansare:");
            string date = Console.ReadLine();

            Album newalbum = new Album(_servicealbum.GenerateRandomId(), newname, date);

            bool verificare = _servicealbum.VerificarAlbum(newname);

            if( verificare )
            {
                Console.WriteLine("Deja exista acest album");
                
            }
            else
            {
                Console.WriteLine("Sa adaugat cu succes!");
                _servicealbum.afisareAlbume();
            }







        }

        public void AdaugareConcerte()
        {
            Console.WriteLine("Introduceti datele noi");
            Console.WriteLine("Name Concert: ");
            string newname = Console.ReadLine();
            Console.WriteLine("Tara: ");
            string Tara = Console.ReadLine();
            Console.WriteLine("Oras: ");
            string Oras = Console.ReadLine();
            Console.WriteLine("Data: ");
            string date = Console.ReadLine();
            Console.WriteLine("Nr de invitati: ");
            int nrInv = int.Parse(Console.ReadLine());

            Concerte concerts = new Concerte (_serviceConcert.GenerateRandomId(),newname,Tara,Oras,date,nrInv);

            bool verificare = _serviceConcert.VerificareConcerte(newname);


            if(verificare )
            {
                Console.WriteLine("Deja exista acel concert");

            }
            else
            {
                Console.WriteLine("Sa adaugat cu succes");
                _serviceConcert.Afisare();
            }


        }

        public void ModificareAlbum()
        {
            Console.WriteLine("Introduceti titlul albumului care doriti sa modificati: "+"\n");
            string name= Console.ReadLine();
            Album modAlbum = _servicealbum.GetALbumByName(name);
            Console.WriteLine("Introduceti Noiile date:"+"\n");
            Console.WriteLine("name");
            string namemod = Console.ReadLine();
            modAlbum.Name = namemod;
            Console.WriteLine("Data Lansare:");
            string Datamod = Console.ReadLine();
            modAlbum.Dataiesire = Datamod;

            Console.WriteLine("Sa modificat cu succes, albumule sunt acum:");
            _servicealbum.afisareAlbume();
           




        }

        public void StergereMelodii()
        {
            
            string name= Console.ReadLine();
            List<int> albume = _serviceEnrolment.GetALbumBySingerId(_singer.Id);
            List<Music> melodiile = _servicemusic.GetAllMelodyByIdAlbums(albume);
            Console.WriteLine("Melodiile sunt: " + "\n");
            for(int i=0;i<melodiile.Count;i++)
            {
                Console.WriteLine(melodiile[i].Descriere());

            }
            Console.WriteLine("Introduceti melodia care doriti sa stergeti:");

            bool verificare = _servicemusic.VerificareSong(name);

            if(verificare)
            {
                Music melodii = _servicemusic.GetSongByName(name);
                _servicemusic.deleteMusic(name, melodii.AlbumId);
                Console.WriteLine("Sa sters cu succes");
                Console.WriteLine("Acuma melodiile sunt:");
                _servicemusic.Afisare();
            }
            else
            {
                Console.WriteLine("A fost o problema posibil sa nue existe melodiia.");
            }




        }
       








    }
}
