using ShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Food> groceries = new List<Food>
            {
                new Food("apple", 1.7),
                new Food("bread", 1.2),
                new Food("cheese", 2)
            };



            ShoppingCart newCart = new ShoppingCart();

            foreach (var food in groceries)
            {
                newCart.Items.Add(food);

            }

            using (var db = new ShopDBContext())
            {
                db.ShoppingCarts.Add(newCart);
                db.SaveChanges();

            }
            
        }
    }
}
