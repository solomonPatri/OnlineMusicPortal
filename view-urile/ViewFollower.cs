using OnlineMusicPortal.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMusicPortal.Utilizatori;
using System.Diagnostics;
using OnlineMusicPortal.Enrolments;
using OnlineMusicPortal.EnrolmentFollower;
using OnlineMusicPortal.ClaseMusic;
namespace OnlineMusicPortal.view_urile
{
    internal class ViewFollower
    {
        private ServiceEnrolmentFollower _serviceenrolments;
        private ServiceUser _serviceuser;
        private Follower _follower;
        private ServiceMusic _serviceMusic;

            public ViewFollower(Follower follower)
        {
            _serviceenrolments = new ServiceEnrolmentFollower();
            _serviceuser = new ServiceUser();
            _serviceMusic = new ServiceMusic(); 
            _follower = follower;
            play();

        }

        public void meniu()
        {
            Console.WriteLine("1->Afisare Cantareti care Urmareste");
            Console.WriteLine("2->Afisare melodii care ii place.");
            Console.WriteLine("3->Stergeti o melodiie care nu mai vreti in lista.");
            Console.WriteLine("4->Adaugare in lista o melodie");
            Console.WriteLine("5-> Stergerea Cantareti din Lista.");
            Console.WriteLine("6-> Adaugarea Cantareti in Lista.");
            Console.WriteLine("7->Deconectare.");


        }
        public void play()
        {
             meniu();
            bool run = true;
            
            while(run)
            {

                int alegere = int.Parse(Console.ReadLine());

                 switch (alegere)
                {
                    case 1:
                        AfisareCantaretiUrmariti();
                        break;
                    case 2:
                        AfisareMelodii();
                        break;
                    case 3:
                        StergereMelodiiedinLista();
                        break;
                    case 4:
                        AdaugareaMelodiieinLista();
                        break;
                    case 5:
                        StergereaSingerLista();
                        break;
                    case 6:
                        AdaugareaSingerLista();
                        break;
                        case 7:
                        run = false;
                        break;






                }







            }

        }

        public void AfisareCantaretiUrmariti()
        {
            Console.WriteLine("Cantaretii dumneavoastra sunt:" + "\n");

            List<int> ids = _serviceenrolments.GetSingerIdByFollId(_follower.Id);
            for (int i = 0; i < ids.Count; i++)
            {
                Console.WriteLine(ids[i]);
            }

            List<Singer> singers = _serviceuser.ReturnSingersById(ids);
            for (int j = 0; j < singers.Count; j++)
            {
                Console.WriteLine(singers[j].DescriereSinger());

            }





        }

        public void AfisareMelodii()
        {
            List<int> idsSongs = _serviceenrolments.GetSongsByFollId(_follower.Id);
            List<Music> songs = _serviceMusic.GetAllSongsByFenrol(idsSongs);

            Console.WriteLine("Melodiile placute sunt:"+"\n");

            for(int i=0;i<songs.Count;i++)
            {

                Console.WriteLine(songs[i].Descriere());


            }



        }

        public void StergereMelodiiedinLista()
        {
            AfisareMelodii();

            Console.Write("Introduceti numele Melodiei care doriti sa stergeti" + "\n");
            string name = Console.ReadLine();

            Music songDelete = _serviceMusic.GetSongByName(name);

            bool verificare = _serviceenrolments.VerficareDeleteSong(_follower.Id, songDelete.Id);

            if(verificare)
            {
                _serviceenrolments.DeleteSongById(_follower.Id,songDelete.Id);
                Console.WriteLine("Sa sters cu succes aceasta melodie, acuma aveti aceste melodii:");
                AfisareMelodii();

            }
            else
            {
                Console.WriteLine("Nu exista aceasa melodie in lista dumneavoastra.");
            }

        }


        public void AdaugareaMelodiieinLista()
        {
            Console.WriteLine("Melodiile sunt: " + "\n");
            _serviceMusic.Afisare();
            Console.WriteLine("Introduceti numele caruia doriti sa adaugati in lista dumneavoastra:" + "\n");

            string name = Console.ReadLine();

            Music AdaugSong = _serviceMusic.GetSongByName(name);

            bool verif = _serviceenrolments.VerficareDeleteSong(_follower.Id, AdaugSong.Id);

            if (verif)
            {
                Console.WriteLine("Deja o aveti in lista");

            }
            else
            {
                EnrolFollower newenrol = new EnrolFollower(_serviceenrolments.GenerateIdUnique(),_follower.Id,_serviceenrolments.GenerateIdUniqueSinger(),AdaugSong.Id);
                _serviceenrolments.AdaugareEnrolmentFoll(newenrol);
                Console.WriteLine("A fost adaugat cu succes, acuma lista dumneavoastra este:"+"\n");
                AfisareMelodii();

            }










        }

        public void StergereaSingerLista()
        {
            AfisareCantaretiUrmariti();

            Console.WriteLine("Introduceti numele Cantaretului care doriti sa stergeti:"+"\n");
            string name = Console.ReadLine();

            Singer deletesinger =_serviceuser.GetSingerByName(name);

            bool verifSinger = _serviceenrolments.VerificareDeleteSinger(_follower.Id,deletesinger.Id);

            if(verifSinger)
            {
                _serviceenrolments.DeleteSingerById(_follower.Id, deletesinger.Id);
                Console.WriteLine("S-a sters cu succes cantaretul, acuma lista dumneavoastra este:" + "\n");
                AfisareCantaretiUrmariti();

            }
            else
            {
                Console.WriteLine("Nu exista cantaretul preferat in lista.");
            }
        }

        public void AdaugareaSingerLista()
        {
            _serviceuser.AfisareSinger();
            Console.WriteLine("Introduceti numele cantaretul care doriti sa adaugati in lista dumneavoastra: " + "\n");
            string name = Console.ReadLine();

            Singer addsinger = _serviceuser.GetSingerByName(name);

            bool verificareSinger = _serviceenrolments.VerificareDeleteSinger(_follower.Id,addsinger.Id);

            if (verificareSinger)
            {
                Console.WriteLine("Deja exista cantaretul favorit in lista: ");

            }
            else
            {
               EnrolFollower newenrol = new EnrolFollower(_serviceenrolments.GenerateIdUnique(),_follower.Id,addsinger.Id,_serviceenrolments.GenerateIdUniqueSong());

              _serviceenrolments.AdaugareEnrolmentFoll(newenrol);

            }









        }

       







    }
}
