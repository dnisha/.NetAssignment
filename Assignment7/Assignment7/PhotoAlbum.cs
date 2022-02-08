using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class PhotoAlbum
    {
        int pages;
        public PhotoAlbum()
        {
            this.pages = 16;

        }
        public PhotoAlbum(int pages)
        {
            this.pages = pages;
        }
       public void GetNumberOfPages()
        {
            Console.WriteLine("Number of pages are " + this.pages);

        }
        static void Main (String [] args)
        {
            PhotoAlbum album = new PhotoAlbum(30);
            album.GetNumberOfPages();

            Console.ReadLine();

        }
    }
    class BigPhotoAlbum
    {
        int page;
        public BigPhotoAlbum()
        {
            this.page = 64;
        }
    }
    class AlbumTest
    {
        int page;
        public AlbumTest()
        {
            this.page = 24;
        }
    }
    
}
