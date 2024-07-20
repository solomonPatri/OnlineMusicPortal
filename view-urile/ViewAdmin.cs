using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMusicPortal.Service;
using OnlineMusicPortal.Utilizatori;

namespace OnlineMusicPortal.view_urile
{
    internal class ViewAdmin
    {
        private ServiceUser _serviceuser;
        private List<Admin> _admin;

        public ViewAdmin()
        {
            _serviceuser = new ServiceUser();
            _admin = new List<Admin>();


        }

        public void meniu()
        {
            Console.WriteLine("Lista useri sunt: " + "\n");
            _serviceuser.AfisareUser();
            Console.WriteLine("Unde doriti sa modificati:");
            Console.WriteLine("1->Singer");
            Console.WriteLine("2->Follower: ");

        }

        public void play()
        {
            bool run = true;
            while(run)
            {
                meniu();
                int nrales= int.Parse(Console.ReadLine());
                switch (nrales)
                {
                    case 1:
                        ModificareSinger();
                        break;
                    case 2:
                        ModificareFollower();
                        break;
                    default:
                        break;




                }


            }




        }

        public void ModificareSinger()
        {
            Console.WriteLine("Introduceti datele Cantaretului care doriti sa modificati:");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Singer admin = _serviceuser.GetSingerByName(name);

            ViewSinger viewsinger = new ViewSinger(admin);
            viewsinger.play();





        }
        public void ModificareFollower()
        {
            Console.WriteLine("Introduceti datele Follower care doriti sa modificati:");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Follower admin = _serviceuser.GetFollowersByName(name);

            ViewFollower follower = new ViewFollower(admin);
            follower.play();



        }

    }
}
