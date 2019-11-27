using GroceryShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace GroceryShop.DatabaseContext
{
    public class GroceryShopDatabaseInitializer : DropCreateDatabaseIfModelChanges<GroceryShopDbContext>
    {
        protected override void Seed(GroceryShopDbContext context)
        {
            context.Foods.AddOrUpdate(
                x => x.Name,
                new Food
                {
                  Name = "apple",
                  Price = 1
                },
                new Food
                {
                    Name = "bread",
                    Price = 0.6
                },
                new Food
                {
                    Name = "milk",
                    Price = 0.9
                },
                new Food
                {
                    Name = "cake",
                    Price = 2.1
                },
                new Food
                {
                    Name = "jam",
                    Price = 1.1
                }
                );
        }

    }
}