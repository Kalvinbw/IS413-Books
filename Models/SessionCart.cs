using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Books.Infrastructure;

namespace Books.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            SessionCart cart = session?.GetJson<SessionCart>("cart") ?? new SessionCart();

            cart.Session = session;

            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Book book, int qty)
        {
            base.AddItem(book, qty);
            Session.SetJson("cart", this);
        }

        public override void RemoveItem(Book book)
        {
            base.RemoveItem(book);
            Session.SetJson("cart", this);
        }

        public override void ClearBasket()
        {
            base.ClearBasket();
            Session.Remove("cart");
        }
    }
}
