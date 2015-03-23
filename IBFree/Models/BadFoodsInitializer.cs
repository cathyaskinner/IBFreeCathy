using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IBFree.Models
{
    public class BadFoodsInitializer : DropCreateDatabaseIfModelChanges<IBFreeContext>
    {
        protected override void Seed(IBFreeContext context)
        {
            var foods = new List<BadFoods>
            {
                new BadFoods {NameId = "Apple", Fructan = true, Sorbitol = true, Mannitol = false, Fructose = true, GOS = false, Lactose = false},
                new BadFoods {NameId = "Avocado", Fructan = false, Sorbitol = true, Mannitol = false, Fructose = false, GOS = false, Lactose = false},
                new BadFoods {NameId = "Onion", Fructan = false, Sorbitol = true, Mannitol = false, Fructose = false, GOS = false, Lactose = false},
                new BadFoods {NameId = "Milk", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = true},
            };
            //base.Seed(context);

            foreach (var item in foods)
            {
                context.BadFood.Add(item);
            }
            context.SaveChanges();
        }
    }
}