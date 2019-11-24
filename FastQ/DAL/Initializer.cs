using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public static class  Initializer
    {

        public static void InitData(EFDbContext context)
        {

            if (!context.Establishments.Any())
            {
                context.Establishments.Add(new Entity.Establishment() { Name = "Трактир", Address = "Людвига Свободы 51А", Phone = "0508899123", Site = "https://www.instagram.com/bohdan_stas/?hl=ru" });
                context.Establishments.Add(new Entity.Establishment() { Name = "511Restorant", Address = "Улица Пушкина Дом Колотушкина", Phone = "0667755345", Site = "https://www.instagram.com/bohdan_stas/?hl=ru" });
                context.SaveChanges();


            }
            if (!context.Dishes.Any())
            {
                context.Dishes.Add(new Entity.Dish() { Name="Борщ",Category="Первое блюдо",Price=25,EstablishmentId=context.Establishments.First().Id});
                context.Dishes.Add(new Entity.Dish() { Name = "Пельмени", Category = "Второе блюдо", Price = 25, EstablishmentId = context.Establishments.Last().Id });
                context.SaveChanges();
            }
          
        }

    }
}
