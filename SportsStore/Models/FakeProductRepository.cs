using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models
{
    public class FakeProductRepository /*: IProductRepository*/
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product
            {
                Name = "God Of War:Remastered Collection",
                Description = "God of War 1, 2, 3 series for PS4 with remastered edition", Price = 59.99M
            },
            new Product
            {
                Name = "The Last Of Us:2",
                Description = "Amazing continius series of Franchize", Price = 89.99M
            },
            new Product
            {
                Name = "Pes 2019",
                Description = "Amazing graphical exclusive for football fans", Price = 65
            },
        }.AsQueryable<Product>();
    }
}