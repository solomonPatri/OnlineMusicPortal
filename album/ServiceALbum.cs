using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnlineMusicPortal.album {

    public class ServiceALbum
    {
        private List<Album> _albume;

      public ServiceALbum()
        {
            _albume = new List<Album>();
            this.load();
      }

        public void load()
        {
            Album a1 = new Album(10, "Live", "2022-08-12");
            Album a2 = new Album(11, "Studio", "2023-01-15");
            Album a3 = new Album(12, "Acoustic", "2021-05-23");
            Album a4 = new Album(13, "Remix", "2020-11-08");
            Album a5 = new Album(14, "Compilation", "2019-06-30");
            Album a6 = new Album(15, "Tribute", "2022-09-14");
            Album a7 = new Album(16, "Deluxe", "2018-12-01");
            Album a8 = new Album(17, "Anniversary", "2024-02-17");
            Album a9 = new Album(18, "Cover", "2023-07-22");
            Album a10 = new Album(19, "Special Edition", "2021-03-05");

            _albume.Add(a1);
            _albume.Add(a2);
            _albume.Add(a3);
            _albume.Add(a4);
            _albume.Add(a5);
            _albume.Add(a6);
            _albume.Add(a7);
            _albume.Add(a8);
            _albume.Add(a9);
            _albume.Add(a10);

        }

        public void afisareAlbume()
        {
            for (int i = 0; i < _albume.Count; i++)
            {
                Console.WriteLine(_albume[i].DescriereAlbum());
            }

        }
        public int GenerateRandomId()
        {
            Random random = new Random();
            int nrrandom = random.Next(10, 100);
            while (GetAlbumById(nrrandom) != null)
            {

                nrrandom = random.Next(10, 100);

            }


            return nrrandom;


        }
        public void adaugareAlbum(Album album)
        {
            album.AlbumId = GenerateRandomId();
            this._albume.Add(album);


        }
        public List<Album> GetAlbume()
        {
            List<Album> list = new List<Album>();
            for(int i = 0; i < _albume.Count; i++)
            {
                list.Add(_albume[i]);

            }
            return list;



        }

        public bool DeleteAlbume(string nameAlbum){

            List<Album> albume = _albume;
            for(int i = 0;i < albume.Count; i++)
            {
                if (albume[i].Name.Equals(nameAlbum))
                {
                    this._albume.Remove(albume[i]);
                    return true;
                }
            }
            return false;




        }

        public Album GetAlbumById(int idAlbum)
        {
            for(int i=0;i<_albume.Count;i++)
            {
                if (_albume[i].AlbumId.Equals(idAlbum))
                {
                    return _albume[i];
                }


            }
            return null;


        }
        public List<Album> GetAllAlbumById(List<int> ids)
        {
            List<Album> albums = new List<Album>();
            for(int i = 0; i < _albume.Count; i++)
            {
                if (ids.Contains(_albume[i].AlbumId))
                {
                    albums.Add(_albume[i]);


                }



            }
            return albums;



        }
        
            
        public Album GetALbumByName(string name)
        { 
            for(int i = 0; i < _albume.Count; i++)
            {
                if (_albume[i].Name.Equals(name))
                {
                    return _albume[i];


                }

            }

            return null;

        }

        public bool VerificarAlbum(string name)
        {
            for(int i=0;i< _albume.Count; i++)
            {
                if (_albume[i].Name.Equals(name))
                {

                    return true;
                }


            }
            return false;

        }














    }


}
