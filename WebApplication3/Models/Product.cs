using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace WebApplication3.Models
{
    public class Product
    {

        private int _id;
        private string _name;
        private string _description;
        private int _price;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        [name]
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        [Range(1, 10000)]
        public int Price
        {
            get => _price;
            set => _price = value;
        }
    }

    public class nameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Product p = (Product) validationContext.ObjectInstance;

            if (p.Name.Contains("sex") || p.Name.Contains("porn"))
            {
                return new ValidationResult("Không được chứa nội dung nhậy cảm");
            }

            return ValidationResult.Success;
        }




    }
}
