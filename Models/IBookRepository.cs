using System;
using System.Linq;

namespace Books.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
