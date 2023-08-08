using System;
using System.Collections.Generic;
using BookBaseBuilder.Models;

namespace BookBaseBuilder
{
	public interface IBookRepository
	{
		public IEnumerable<Book> GetAllBooks();
		public Book GetBook(int id);
		public void UpdateBook(Book book);
        public void InsertBook(Book bookToInsert);
		public void DeleteBook(Book book);
    }
}

