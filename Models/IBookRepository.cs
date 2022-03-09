using System;
using System.Linq;

namespace Books.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }

        public void Savebook(Book b);

        public void CreateBook(Book b);

        public void DeleteBook(Book b);
    }
}
