using System;

namespace PhotoAlbumTarea
{
    class PhotoAlbum
    {
        protected int _numberOfPages;
        public PhotoAlbum()
        {
            _numberOfPages = 16;
        }
        public PhotoAlbum(int numberOfPages)
        {
            _numberOfPages = numberOfPages;
        }
        public int GetNumberOfPages()
        {
            return _numberOfPages;
        }
    }
    class BigPhotoAlbum : PhotoAlbum
    {
        public BigPhotoAlbum()
        {
            _numberOfPages = 64;
        }
    }

    class AlbumTest
    {
        static void Main()
        {
            bool check = false;

            PhotoAlbum myPhotoAlbum1 = new PhotoAlbum();
            Console.WriteLine(myPhotoAlbum1.GetNumberOfPages());

            PhotoAlbum myPhotoAlbum2 = new PhotoAlbum(24);
            Console.WriteLine(myPhotoAlbum2.GetNumberOfPages());

            BigPhotoAlbum myBigAlbum = new BigPhotoAlbum();
            Console.WriteLine(myBigAlbum.GetNumberOfPages());

            if(check)
                Console.ReadLine();
        }
    }
}
