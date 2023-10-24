using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Models
{
    internal class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        
        public int No { get; set; }
        private static int _no;

        static Book()
        {
            _no = 0;
        }

        public Book()
        {
            _no++;
            No = _no;
        }

        public string Code
        {
            get
            {
                string a = Name.Trim();
                char firstLetter = char.ToUpper(a[0]);
                char secondLetter = char.ToUpper(a[1]);

                string code = firstLetter + secondLetter + No.ToString() ;

                return code;
            }
        }
        

    }
}
