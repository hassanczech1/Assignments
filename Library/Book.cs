using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
		public int NumOfCopies {  get; set; }
		public string Title { get; set; }
        public string Author { get; set; }

       public Book(int _NumOfCopies, string _Title, string _Author) {
            NumOfCopies = _NumOfCopies;
            Title = _Title;
            Author = _Author;
        }
	}
}
