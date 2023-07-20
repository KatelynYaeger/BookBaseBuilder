using System;
using System.Collections.Generic;

namespace BookBaseBuilder
{
	public interface IBookRepository
	{
		public IEnumerable<Book> GetAllBooks();
		public Book GetBook(int id);
		public void UpdateBook(Book book);
	}
}

