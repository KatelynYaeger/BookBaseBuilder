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

        public Book GetBook(int id)
        {
            return _conn.QuerySingle<Book>("SELECT BOOKID, TITLE, AUTHOR, CHARACTERISTICS FROM ATTRIBUTES WHERE BOOKID = @id",
                new { id = id });
        }
    }
}

