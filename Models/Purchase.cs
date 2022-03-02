using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Books.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an address")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter the city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the state")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter an email")]
        public string Email { get; set; }

    }
}
