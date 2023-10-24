using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Models
{
    internal class Library
    {
        public List<Book> Books = new List<Book>();

        public List<Book> FindAllBooksByName(string name)
        {
            List<Book> newBook = new List<Book>();
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Name == name)
                {
                    newBook.Add(Books[i]);
                }
            }
            return newBook;
        }

        public List<Book> RemoveAllBooksByName(string name)
        {
            
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Name.Contains(name))
                {
                    Books.Remove(Books[i]);
                }
            }
            return Books;
        }

        public List<Book> SearchBooks(string value)
        {
            List<Book> newBook2 = new List<Book>();
            int pageCount;

            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Name == value || Books[i].AuthorName == value ||
                    (int.TryParse(value, out pageCount) && Books[i].PageCount == pageCount))
                {
                    newBook2.Add(Books[i]);
                }
            }
            return newBook2;
        }




        public List<Book> FindAllBooksByPageCountRange(int minPage,int maxPage)
        {
            List<Book> newBook3 = new List<Book>();
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].PageCount >=minPage && Books[i].PageCount <=maxPage)
                {
                    newBook3.Add(Books[i]);
                }
            }
            return newBook3;
        }

        public List<Book> RemoveBookByCode(string code)
        {
            
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Code == code) 
                {
                    Books.Remove(Books[i]);
                }
            }return Books;

        }

        
        
    }
}
