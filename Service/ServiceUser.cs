using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMusicPortal.Utilizatori;

namespace OnlineMusicPortal.Service
{
    internal class ServiceUser
    {
        private List<User> _users;
        private string _filePath;

        public ServiceUser()
        {

            _users = new List<User>();
            _filePath = GetDirectory();
            load();
        }

        public void load()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string line = " ";

                    while ((line = sr.ReadLine()) != null)
                    {


                        switch (line.Split(',')[0])
                        {

                            case "Singer":

                                Singer singer = new Singer(line);
                                _users.Add(singer);
                                break;


                            case "Follower":
                              Follower follower = new Follower(line);   
                                _users.Add(follower);
                                break;

                            case "Admin":
                                Admin admin = new Admin(line);
                                _users.Add(admin);
                                break;

                            default:
                                break;

                        }


                    }



                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }






        }
        public string GetDirectory()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string dataFolder = Path.Combine(currentDirectory, "data");
            string filePath = Path.Combine(dataFolder, "Users.txt");
            return filePath;
        }

        public User GetUserById(int id)
        {
            List<User> users = _users;
           for(int i=0;i<users.Count; i++)
            {
                if ((users[i] as Singer).Id.Equals(id) || (users[i] as Follower).Id.Equals(id))
                {
                    return users[i];
                } 



            }

            return null;
        }
        public void AfisareUser()
        {
            foreach (User users in _users)
            {
                Console.WriteLine(users.Descriere());
            }


        }
        public void AfisareSinger()
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i] is Singer)
                {
                    Console.WriteLine(_users[i].Descriere());

                }

            }
        }

        public void AfisareFollower()
        {

            for(int i=0;i < _users.Count; i++)
            {
                if (_users[i] is Follower)
                {
                    Console.WriteLine(_users[i].Descriere());
                }



            }


        }

        public int GenerateRandomId()
        {
            Random random = new Random();
            int nrrandom = random.Next(10, 100);
            while (GetUserById(nrrandom) != null)
            {

                nrrandom = random.Next(10, 100);

            }


            return nrrandom;


        }

        public void adaugareUser(User user)
        {
            user.Id = GenerateRandomId();
            this._users.Add(user);

        }
        public User GetUserByDate(string username, string password)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Email.Equals(username) && _users[i].Password.Equals(password))
                {
                    return _users[i];

                }

            }
            return null;
        }

        public User GetSpecificUser(string username,string password)
        {
            User user = GetUserByDate(username, password);
            for(int i=0;i< _users.Count; i++)
            {
                if((user as Singer).Email.Equals(_users[i].Email) && (user as Singer).Password.Equals(_users[i].Password)) {

                    Singer singer = _users[i] as Singer;
                    return singer;

                }
                else
                {

                    if ((user as Follower).Email.Equals(_users[i].Email) && (user as Follower).Password.Equals(_users[i].Password))
                    {

                        Follower follower = _users[i] as Follower;
                        return follower;


                    }


                }

            }
            return null;

        }

        public List<User> AfisareUserByIdiuri(List<int> ids)
        {
            List<User> users = new List<User>();

            for (int i = 0; i < _users.Count; i++)
            {
                if (ids.Contains(_users[i].Id))
                {
                    users.Add(_users[i]);


                }

            }

            return users;



        }



















    }
}
