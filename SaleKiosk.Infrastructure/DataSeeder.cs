using SaleKiosk.Domain.Models;

namespace SaleKiosk.Infrastructure
{
    public class DataSeeder
    {
        private readonly KioskDbContext _dbContext;

        public DataSeeder(KioskDbContext context)
        {
            this._dbContext = context;
        }

        public void Seed()
        {
            _dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();

            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Products.Any())
                {
                    var products = new List<Product>
                    {
                        new Product()
                        {
                            Id = 1,
                            Name = "Kawa",
                            Description = "Mała czarna",
                            UnitPrice = 12,
                            CreatedAt = DateTime.Now.AddDays(-3),
                            ImageUrl = "/images/no-image-icon.png",
                        },

                        new Product()
                        {
                            Id = 2,
                            Name = "Herbata",
                            Description = "English tea",
                            UnitPrice = 12,
                            CreatedAt = DateTime.Now.AddDays(-2),
                            ImageUrl = "/images/no-image-icon.png",
                        },
                    };

                    if (!_dbContext.Users.Any())
                    {
                        var users = new List<User>
                    {
                        new User()
                        {
                            Id = 1,
                            FirstName="Jan",
                            LastName="Kowalski",
                            Email="jan.kowalski@onet.pl",
                            PhoneNumber="123456",
                            Username="Jan123",
                            ImageUrl = "/images/no-image-icon.png",
                        },

                        new User()
                        {
                            Id = 2,
                            FirstName="Ania",
                            LastName="Nowak",
                            Email="anna.nowak@onet.pl",
                            PhoneNumber="345678",
                            Username="Ania11",
                            ImageUrl = "/images/no-image-icon.png",
                        },
                    };
                        _dbContext.Products.AddRange(products);
                        _dbContext.Users.AddRange(users);
                        _dbContext.SaveChanges();
                    }
                }
            }
        }
    }
}