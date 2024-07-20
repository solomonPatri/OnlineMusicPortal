using OnlineMusicPortal.Service;
using OnlineMusicPortal.Utilizatori;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.view_urile
{
    internal class ViewLogin
    {
        private ServiceUser _serviceuser;

        public ViewLogin()
        {
            _serviceuser = new ServiceUser();
            this.Play();



        }

        public void meniu()
        {
            Console.WriteLine("1->Log in");
            Console.WriteLine("2->Sign in");



        }

        public void Play()
        {
            bool run = true;

            while(run)
            {
                meniu();
                int nrales = int.Parse(Console.ReadLine());
                switch(nrales)
                {
                    case 1:
                        AfisareLogIn();
                        break;

                    case 2:
                        AfisareSignIn();
                        break;






                }



            }









        }

        public void AfisareLogIn()
        {
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Password: ");
            string pass = Console.ReadLine();
            User user  = _serviceuser.GetUserByDate(email,pass);

            if((user as Singer) != null) {

                ViewSinger viewsinger = new ViewSinger((user as Singer));
                viewsinger.play();
            }
            else
            {
                if((user as Follower) != null)
                {
                    ViewFollower viewFollower = new ViewFollower((user as Follower));
                    viewFollower.play();
                }
                else
                {
                    Console.WriteLine("Datele introduse gresite!");
                }
                
            }





        }

        public void InscriereSinger()
        {
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Mobile");
            string mobile = Console.ReadLine();
            Console.WriteLine("Adress: ");
            string adress = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = int.Parse(Console.ReadLine());

            Singer singer = new Singer("Singer",_serviceuser.GenerateRandomId(),email,password,name,mobile,adress,age);

            bool verifi = false;

            if(verifi)
            {
                Console.WriteLine("Deja exista acest cantareti, incercati din nou!");

            }
            else
            {
                _serviceuser.adaugareUser(singer);

            }





        }

        public void InscriereFollower()
        {
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Name:");
            string nameFoll = Console.ReadLine();
            Console.WriteLine("Follow Year:");
            int year = int.Parse(Console.ReadLine());

            Follower newfoll = new Follower("Follower", _serviceuser.GenerateRandomId(), email, password, nameFoll, year);

            bool verifi = false;
            if(verifi)
            {
                Console.WriteLine("Deja exista acest Follower, incercati din nou.");

            }
            else
            {
                _serviceuser.adaugareUser(newfoll);

            }




        }

        public void AfisareSignIn()
        {
            Console.WriteLine("1-> Singer");
            Console.WriteLine("2-> Follower");
            int SingerFoll = int.Parse(Console.ReadLine());
            switch(SingerFoll)
            {
                case 1:
                    InscriereSinger();
                    break;

                case 2:
                    InscriereFollower();
                    break;


            }







        }





    }
}
