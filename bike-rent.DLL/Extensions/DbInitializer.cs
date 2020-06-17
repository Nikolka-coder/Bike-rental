﻿using bike_rent.DLL.Enums;
using bike_rent.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bike_rent.DLL.Extensions
{
    public class DbInitializer
    {
        public static async Task Seed(AppDbContext context)
        {
            if (!context.Bikes.Any())
            {
                await context.AddRangeAsync(
                    new Bike { Name = "Giant ", Type = TypeEnum.Mountain, Price = 10, Status = StatusEnum.Available },
                    new Bike { Name = "Trek ", Type = TypeEnum.Road, Price = 10, Status = StatusEnum.Rent },
                    new Bike { Name = "Specialized ", Type = TypeEnum.Road, Price = 10, Status = StatusEnum.Available}
                    );
            }

            await context.SaveChangesAsync();
        }
    }

}
