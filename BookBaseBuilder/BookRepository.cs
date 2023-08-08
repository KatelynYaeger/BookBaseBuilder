using System;
using System.Data;
using Dapper;
using System.Collections.Generic;
using BookBaseBuilder.Models;

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
            return _conn.Query<Book>("SELECT BOOKID, TITLE, AUTHOR, GENRE, CHARACTERISTICS FROM ATTRIBUTES;");
        }

        public Book GetBook(int id)
        {
            return _conn.QuerySingle<Book>("SELECT BOOKID, TITLE, AUTHOR, GENRE, CHARACTERISTICS FROM ATTRIBUTES WHERE BOOKID = @id",
                new { id = id });
        }

        public void UpdateBook(Book book)
        {
            _conn.Execute("UPDATE books SET Title = @title, Author = @author, Genre = @genre, Characteristics = @characteristics WHERE BookID = @id",
                new { name = book.Title, price = book.Author, genre = book.Genre, characteristics = book.Characteristics, id = book.BookID , });

        }

        public void InsertBook(Book bookToInsert)
        {
            _conn.Execute("INSERT INTO attributes (TITLE, AUTHOR, GENRE, CHARACTERISTICS) VALUES (@title, @author, @genre, @characteristics);",
    new { title = bookToInsert.Title, author = bookToInsert.Author, genre = bookToInsert.Genre, characteristics = bookToInsert.Characteristics });

        }

        public void DeleteBook(Book book)
        {
            _conn.Execute("DELETE FROM Attributes WHERE Bookid = @id;",
                                       new { id = book.BookID });

        }
    }
}

