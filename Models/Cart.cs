using System;
using System.Collections.Generic;
using System.Linq;

namespace Books.Models
{
    public class Cart
    {
        // the list of books in the cart
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();

        // Add book method
        public void AddItem(Book book, int qty)
        {
            CartLineItem Line = Items.Where(p => p.Book.BookId == book.BookId).FirstOrDefault();
            // if the book is not already there
            if (Line == null)
            {
                Items.Add(new CartLineItem
                {
                    Book = book,
                    Quantity = qty
                });
            }
            // if the book has already been added
            else
            {
                Line.Quantity += qty;
            }
        }
        // calculate the total
        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;
        }
    }

    public class CartLineItem
    {
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}