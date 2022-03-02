using System;
using System.Linq;

namespace Books.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchases { get; }

        public void SavePurchase(Purchase purchase);
    }
}
