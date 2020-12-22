using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    //Create this interface because we're using an in memory data store for learning purposes
    //We can switch this method to use a actual database later on
    public interface IShopData
    {
        IEnumerable<Shops> GetAllShops();
        Shops GetShopByName(string name);
        IList<Shops> GetShopsByName(string name);
        Shops GetShopById(int id);
    }

    public class InMemoryShopData : IShopData
    {
        List<Shops> MusicShopData;

        public InMemoryShopData()
        {
            MusicShopData = new List<Shops>()
            {
                new Shops { Id = 1, Location = "Luton", Name = "Bass Guitar Central", Specialty = ShopSpecialty.BassGuitar },
            new Shops { Id = 2, Location = "London", Name = "Guitar Maniacs", Specialty = ShopSpecialty.Guitar },
            new Shops { Id = 3, Location = "Milton Keynes", Name = "Piano Gods", Specialty = ShopSpecialty.Piano },
            new Shops { Id = 4, Location = "Surrey", Name = "VioNation", Specialty = ShopSpecialty.Violin }
            };
        }

        public IEnumerable<Shops> GetAllShops()
        {

            return MusicShopData.OrderBy(x => x.Name);
        }

        public Shops GetShopByName(string name)
        {
            return MusicShopData.Where(x => x.Name.StartsWith(name)).SingleOrDefault();
        }

        public IList<Shops> GetShopsByName(string name = null)
        {
            return (from s in MusicShopData
                   where s.Name.ToLower().StartsWith(name) || string.IsNullOrEmpty(name)
                   orderby s.Name
                   select s).ToList();
        }

        public Shops GetShopById(int Id)
        {
            return MusicShopData.Where(x => x.Id == Id).FirstOrDefault();
        }
    }
}
