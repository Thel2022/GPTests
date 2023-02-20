using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using BookStore.Models;

namespace BookStore.ViewModels
{
    public class OrderViewModel
    {
        public Order order { get; set; }

    }
}
