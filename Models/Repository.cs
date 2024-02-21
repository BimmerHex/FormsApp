namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category {
                CategoryId = 1,
                Name = "Telefon"
            });

            _categories.Add(new Category {
                CategoryId = 2,
                Name = "Dizüstü Bilgisayar"
            });

            _categories.Add(new Category {
                CategoryId = 3,
                Name = "Tablet",
            });

            _products.Add(new Product {
                ProductId = 1,
                Name = "iPHONE SE",
                Price = 22000,
                Image = "iphone-se.png",
                IsActive = true,
                CategoryId = 1
            });

            _products.Add(new Product {
                ProductId = 2,
                Name = "iPHONE 11",
                Price = 22000,
                Image = "iphone-11.png",
                IsActive = false,
                CategoryId = 1
            });

            _products.Add(new Product {
                ProductId = 3,
                Name = "iPHONE 12",
                Price = 22000,
                Image = "iphone-12.png",
                IsActive = true,
                CategoryId = 1
            });

            _products.Add(new Product {
                ProductId = 4,
                Name = "iPHONE 13",
                Price = 26000,
                Image = "iphone-13.png",
                IsActive = true,
                CategoryId = 1
            });

            _products.Add(new Product {
                ProductId = 5,
                Name = "iPHONE 14 PLUS",
                Price = 36000,
                Image = "iphone-14plus.png",
                IsActive = true,
                CategoryId = 1
            });

            _products.Add(new Product {
                ProductId = 6,
                Name = "iPHONE 14 PRO",
                Price = 42000,
                Image = "iphone-14pro.png",
                IsActive = true,
                CategoryId = 1
            });

            _products.Add(new Product {
                ProductId = 7,
                Name = "iPHONE 15 PLUS",
                Price = 40000,
                Image = "iphone-15plus.png",
                IsActive = true,
                CategoryId = 1
            });

            _products.Add(new Product {
                ProductId = 8,
                Name = "iPHONE 15 PRO MAX",
                Price = 60000,
                Image = "iphone-15promax.png",
                IsActive = true,
                CategoryId = 1
            });

            _products.Add(new Product {
                ProductId = 9,
                Name = "SAMSUNG GALAXY CHROMEBOOK GO",
                Price = 15000,
                Image = "samsung-galaxy-chromebook-go.png",
                IsActive = true,
                CategoryId = 2
            });

            _products.Add(new Product {
                ProductId = 10,
                Name = "SAMSUNG GALAXY CHROMEBOOK2 360",
                Price = 29000,
                Image = "samsung-galaxy-chromebook2-360.png",
                IsActive = true,
                CategoryId = 2
            });

            _products.Add(new Product {
                ProductId = 11,
                Name = "ACER CHROMEBOOK SPIN 513",
                Price = 33000,
                Image = "acer-chromebook-spin-513.png",
                IsActive = true,
                CategoryId = 2
            });

            _products.Add(new Product {
                ProductId = 12,
                Name = "SAMSUNG GALAXY BOOK3 PRO 360 5G",
                Price = 90000,
                Image = "samsung-galaxy-book3-pro-360-5g.png",
                IsActive = true,
                CategoryId = 2
            });

            _products.Add(new Product {
                ProductId = 13,
                Name = "SAMSUNG GALAXY TAB S9 FE",
                Price = 24000,
                Image = "samsung-galaxy-tab-s9-fe.png",
                IsActive = true,
                CategoryId = 3
            });

            _products.Add(new Product {
                ProductId = 14,
                Name = "iPAD (9TH GEN)",
                Price = 38000,
                Image = "ipad-9th-gen.png",
                IsActive = true,
                CategoryId = 3
            });

            _products.Add(new Product {
                ProductId = 15,
                Name = "iPAD (10TH GEN)",
                Price = 56000,
                Image = "ipad-10th-gen.png",
                IsActive = true,
                CategoryId = 3
            });

            _products.Add(new Product {
                ProductId = 16,
                Name = "iPAD AIR",
                Price = 60000,
                Image = "ipad-air.png",
                IsActive = true,
                CategoryId = 3
            });

            _products.Add(new Product {
                ProductId = 17,
                Name = "iPAD PRO 11 INCH",
                Price = 64000,
                Image = "ipad-pro-11-inch.png",
                IsActive = true,
                CategoryId = 3
            });            
        }

        public static List<Product> Products
        {
            get { return _products; }
        }

        public static void CreateProduct(Product model) {
            _products.Add(model);
        }

        public static void EditProduct(Product model) {
            var entity = _products.FirstOrDefault(p => p.ProductId == model.ProductId);

            if (entity != null) {
                entity.Name = model.Name;
                entity.Price = model.Price;
                entity.Image = model.Image;
                entity.CategoryId = model.CategoryId;
                entity.IsActive = model.IsActive;
            }
        }

        public static void DeleteProduct(Product model) {
            var entity = _products.FirstOrDefault(p => p.ProductId == model.ProductId);

            if (entity != null) _products.Remove(entity);
        }

        public static List<Category> Categories
        {
            get { return _categories; }
        }
    }
}