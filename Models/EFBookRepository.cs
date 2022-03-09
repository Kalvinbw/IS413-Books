using System;
using System.Linq;

namespace Books.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;

        public void Savebook(Book p)
        {
            context.Update(p);
            context.SaveChanges();
        }

        public void CreateBook(Book p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeleteBook(Book p)
        {
            context.Remove(p);
            context.SaveChanges();
        }
    }
}
