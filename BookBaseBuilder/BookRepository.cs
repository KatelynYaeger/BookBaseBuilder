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
            return _conn.Query<Book>("SELECT BOOKID, TITLE, AUTHOR, GENRE, CHARACTERISTICS, ISBN FROM ATTRIBUTES;");
        }

        public Book GetBook(int id)
        {
            return _conn.QuerySingle<Book>("SELECT BOOKID, TITLE, AUTHOR, GENRE, CHARACTERISTICS, ISBN FROM ATTRIBUTES WHERE BOOKID = @id",
                new { id = id });
        }

        public void UpdateBook(Book book)
        {
            _conn.Execute("UPDATE attributes SET Title = @title, Author = @author, Genre = @genre, Characteristics = @characteristics, ISBN = @isbn WHERE BookID = @id",
                new { title = book.Title, author = book.Author, genre = book.Genre, characteristics = book.Characteristics, id = book.BookID , isbn = book.ISBN
                });

        }

        public void InsertBook(Book bookToInsert)
        {
            _conn.Execute("INSERT INTO attributes (TITLE, AUTHOR, GENRE, CHARACTERISTICS, ISBN) VALUES (@title, @author, @genre, @characteristics, @ISBN);",
    new { title = bookToInsert.Title, author = bookToInsert.Author, genre = bookToInsert.Genre, characteristics = bookToInsert.Characteristics, isbn = bookToInsert.ISBN });

        }

        public void DeleteBook(Book book)
        {
            _conn.Execute("DELETE FROM Attributes WHERE Bookid = @id;",
                                       new { id = book.BookID });

        }
    }
}

