using System;
namespace Giraffe
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {

        }

        public Book(string aTitle, string anAuthor, int aNumber)
        {
            title = aTitle;
            author = anAuthor;
            pages = aNumber;
        }


        public override string ToString()
        {
            return title.ToString() + " with pages of " + pages.ToString(); ;
        }
    }
}
