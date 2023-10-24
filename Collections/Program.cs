using Collections.Models;
using System.Globalization;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book book = new Book();
            Book book1 = new Book();
            Book book2 = new Book();


            book1.Name = "Qirxayaq";
            book1.AuthorName = "istek";
            book1.PageCount = 16;

            book.Name = "Melikmemmed";
            book.AuthorName = "Author";
            book.PageCount = 24;

            book2.Name = "Test";
            book2.AuthorName = "arzu";
            book2.PageCount = 45;




            library.Books.Add(book);
            library.Books.Add(book1);
            library.Books.Add(book2);


            List<Book> booksByName = library.FindAllBooksByName("Melikmemmed");

            
            foreach (var item in booksByName)
            {
                Console.WriteLine($"{item.Name} - {item.AuthorName} - {item.PageCount} - {item.Code}");
            }




            Console.WriteLine("=========================================================================");



            List<Book> removeBookByName = library.RemoveAllBooksByName("Melikmemmed");

            foreach (var item in removeBookByName)
            {
                Console.WriteLine($"{item.Name} - {item.AuthorName} - {item.PageCount}");
            }


            Console.WriteLine("=========================================================================");



            List<Book> searchBook = library.SearchBooks("45");

            foreach (var item in searchBook)
            {
                Console.WriteLine($"{item.Name} - {item.AuthorName} - {item.PageCount}");
            }



            Console.WriteLine("=========================================================================");



            List<Book> pageCount = library.FindAllBooksByPageCountRange(10,50);

            foreach (var item in pageCount)
            {
                Console.WriteLine($"{item.Name} - {item.AuthorName} - {item.PageCount}");
            }

            

            Console.WriteLine("=========================================================================");





            List<Book> removeCode = library.RemoveBookByCode("ME1");
            foreach (var item in removeCode)
            {
                Console.WriteLine($"{item.Name} - {item.AuthorName} - {item.PageCount} - {item.Code}");
            }




            //TASK 1


            //Dictionary<string, int> dictionary = new Dictionary<string, int>();
            //dictionary.Add("BIR", 1);
            //dictionary.Add("IKI", 2);

            //Console.WriteLine("\n\n========================================= ");
            //int value = dictionary["BIR"];
            //int value1 = dictionary["IKI"] ;

            
            //Console.WriteLine(value);
            //Console.WriteLine(value1);

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Birinci");
            //queue.Enqueue("Ikinci");

            //Stack<string> stack = new Stack<string>();
            //stack.Push("Birinci");
            //stack.Push("Ikinci");
            //stack.Peek();
            //string txt1 = stack.Pop();
            //Console.WriteLine(txt1);


            //string text = queue.Dequeue();
            //Console.WriteLine(text);


            //HashSet<string> set = new HashSet<string>();
            //set.Add("bmw");
            //set.Add("mercedes");

            //bool contains = set.Contains("bmw");
            //bool contains1 = set.Contains("merco");
            //Console.WriteLine(contains);
            //Console.WriteLine(contains1);

            //SortedList<int, string> sortedList = new SortedList<int, string>();

            
            //sortedList.Add(3, "Three");
            //sortedList.Add(1, "One");
            //sortedList.Add(2, "Two");

            
            //string txt3 = sortedList[3];
            //Console.WriteLine(txt3);

            //foreach (var pair in sortedList)
            //{
            //    Console.WriteLine($"{pair.Key} -  {pair.Value}");
            //}

            

        }
    }
}