using System;
using BookBaseBuilder.Models;

namespace BookBaseBuilder
{
	public class Book
	{
		public Book()
		{
		}

		public int BookID { get; set; }
		public string Title { get; set; }
        public string Author { get; set; }
		public string Genre { get; set; }
		public string Characteristics { get; set; }
		public string ISBN { get; set; }

    }
}

