using System;
using System.Data;
using Dapper;
using System.Collections.Generic;

namespace BookBaseBuilder
{
	public class BookRepository: IBookRepository
	{
        private readonly IDbConnection _conn;

        public BookRepository(IDbConnection conn)
        {
            _conn = conn;
        }


        public IEnumerable<Book> GetAllBooks()
        {
            return _conn.Query<Book>("SELECT BOOKID, TITLE, AUTHOR, CHARACTERISTICS FROM ATTRIBUTES;");
        }
    }
}

