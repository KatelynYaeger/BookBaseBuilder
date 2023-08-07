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

		//public enum Genre
  //      {
		//	Alternate History = 1,
		//	Apocalyptic = 2,
		//	Childrens = 3,
		//	Fairytale = 4,
		//	Fantasy = 5,
		//	General Fiction = 6,
		//	Gothic = 7,
		//	Historical Fiction = 8,
		//	Legal Thriller = 9,
		//	Mystery = 10,
		//	Romance = 11,
		//	Science Fiction = 12,
		//	Thriller = 13,
		//	Young Adult = 14
  //      }
    }
}

