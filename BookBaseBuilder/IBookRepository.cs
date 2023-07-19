using System;
using System.Collections.Generic;

namespace BookBaseBuilder
{
	public interface IBookRepository
	{
		public IEnumerable<Book> GetAllBooks();
	}
}

