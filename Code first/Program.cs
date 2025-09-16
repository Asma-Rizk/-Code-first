using System;
using System.Linq;
using EFD2.models;


class Program
{
    static void Main(string[] args)
    {
        using (var db = new NewsContext())
        {
            Console.WriteLine("=== News System Demo ===");

            // ✅ 1. Create (إضافة بيانات)
            var author = new Author
            {
                Name = "Asma Rizk",
                Age = 22,
                Username = "asma",
                Password = "123",
                JoinDate = DateTime.Now
            };
            db.Authors.Add(author);

            var catalog = new Catalog
            {
                Name = "Technology",
                Desc = "All about latest tech"
            };
            db.Catalogs.Add(catalog);
            db.SaveChanges();

            var news = new News
            {
                Title = "First News",
                Bref = "Short Description",
                Desc = "This is the full content of the first news.",
                Time = DateTime.Now.ToShortTimeString(),
                Date = DateTime.Now,
                AuthorId = author.Id,
                Cat_Id = catalog.Id
            };
            db.News.Add(news);
            db.SaveChanges();

            Console.WriteLine("✅ News Added Successfully!");

            // ✅ 2. Read (عرض البيانات)
            Console.WriteLine("\n=== All News ===");
            var allNews = db.News.ToList();
            foreach (var n in allNews)
            {
                Console.WriteLine($"[{n.Id}] {n.Title} - by Author {n.AuthorId}, Category {n.Cat_Id}");
            }

            // ✅ 3. Update (تعديل بيانات)
            var firstNews = db.News.FirstOrDefault();
            if (firstNews != null)
            {
                firstNews.Title = "Updated News Title";
                db.SaveChanges();
                Console.WriteLine($"\n✅ News {firstNews.Id} Updated!");
            }

            // ✅ 4. Delete (حذف بيانات)
            var deleteNews = db.News.FirstOrDefault();
            if (deleteNews != null)
            {
                db.News.Remove(deleteNews);
                db.SaveChanges();
                Console.WriteLine($"\n✅ News {deleteNews.Id} Deleted!");
            }
        }

        Console.WriteLine("\n=== Done ===");
        Console.ReadLine();
    }
}
