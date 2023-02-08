﻿using BooksAPI.Models;
using System.Collections.Generic;

namespace BooksAPI.Managers
{
    public class BooksRepository
    {
        private static int _nextId = 1;
        private readonly List<Book> Data = new List<Book>
        {
            new Book {Id = _nextId++, Title = "C# is nice", Price = 12.34},
            new Book {Id = _nextId++, Title = "Python is even nicer", Price = 22.33}
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };

        public List<Book> GetAll()
        {
            return new List<Book>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }

        public Book? GetById(int id)
        {
            return Data.Find(book => book.Id == id);
        }

        public Book Add(Book newBook)
        {
            newBook.Id = _nextId++;
            Data.Add(newBook);
            return newBook;
        }

        public Book? Delete(int id)
        {
            Book? book = GetById(id);
            if (book == null) return null;
            Data.Remove(book);
            return book;
        }

        public Book? Update(int id, Book updates)
        {
            Book? book = GetById(id);
            if (book == null) return null;
            book.Title = updates.Title;
            book.Price = updates.Price;
            return book;
        }
    }
}