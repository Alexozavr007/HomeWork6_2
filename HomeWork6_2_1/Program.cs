using HomeWork6_2_1;
using Microsoft.EntityFrameworkCore;    
using System.Diagnostics;
using System.Security.Cryptography;


var name0 = "Intel i000";
var name1 = "Intel i111";
var name5 = "Intel i555";
var name7 = "Intel i777";

using (var dbContext = new MyDatabaseContext()) {
    dbContext.Products.ExecuteDelete();

    dbContext.Products.AddRange(
        new Product {
                Id = Guid.NewGuid(),
                Cost = 120,
                Name = name0,
                Description = "popa",
                Quantity = 5
            },
        new Product {
            Id = Guid.NewGuid(),
            Cost = 160,
            Name = name1,
            Description = "popi",
            Quantity = 3
        },
        new Product {
            Id = Guid.NewGuid(),
            Cost = 100,
            Name = "Intel i3",
            Description = "popo",
            Quantity = 10
        },
        new Product {
            Id = Guid.NewGuid(),
            Cost = 160,
            Name = "Intel i9 11200",
            Description = "popu",
            Quantity = 3
        },
        new Product {
            Id = Guid.NewGuid(),
            Cost = 120,
            Name = "Intel i7",
            Description = "popb",
            Quantity = 51
        },
        new Product {
            Id = Guid.NewGuid(),
            Cost = 160,
            Name = name5,
            Description = "popp",
            Quantity = 323
        },
        new Product {
            Id = Guid.NewGuid(),
            Cost = 120,
            Name = "Intel i10",
            Description = "popt",
            Quantity = 43
        },
        new Product {
            Id = Guid.NewGuid(),
            Cost = 160,
            Name = name7,
            Description = "popa",
            Quantity = 3
        },
        new Product {
            Id = Guid.NewGuid(),
            Cost = 120,
            Name = "Intel i4",
            Description = "popca",
            Quantity = 23
        },
        new Product {
            Id = Guid.NewGuid(),
            Cost = 160,
            Name = "Intel i49",
            Description = "pop34",
            Quantity = 34
        }
    );
    dbContext.SaveChanges();

    var product0 = dbContext.Products.Single(x => x.Name == name0);
    Console.WriteLine(product0);

    var product1 = dbContext.Products.Single(x => x.Name == name1);
    Console.WriteLine(product1);

    var product5 = dbContext.Products.Single(x => x.Name == name5);
    Console.WriteLine(product5);

    var product7 = dbContext.Products.Single(x => x.Name == name7);
    Console.WriteLine(product7);

}