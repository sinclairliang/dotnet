using System;
namespace Giraffe
{
    public class Book
    {
        public string title;
        public string author;
        private  int pages;

        public Book()
        {

        }

        public Book(string aTitle, string anAuthor, int aNumber)
        {
            title = aTitle;
            author = anAuthor;
            Pages = aNumber;
        }

        public int Pages
        {
            get { return pages; }
            set
            {
                if(value < 0)
                {
                    pages = 0;
                }
                else
                {
                    pages = value;
                }
            }
        }

        public override string ToString()
        {
            return title.ToString() + " with pages of " + pages.ToString(); ;
        }
    }
}
