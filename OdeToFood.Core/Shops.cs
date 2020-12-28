using System;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Core
{
    public class Shops
    {
        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string Name { get; set; }
        [Required, MaxLength(250)]
        public string Location { get; set; }
        public ShopSpecialty Specialty { get; set; }
    }
}
