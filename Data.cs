using graph6;
using System.Collections.Generic;
namespace graph6{
    public class InMemoryDatabase
    {
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
        
        public InMemoryDatabase()
        {
            Authors = new List<Author>
            {
                new Author {Name = "John Snow"},
                new Author {Name = "John Doe"},
            };
            Books = new List<Book>()
            {
                new Book {Title = "The Programatic Programmer", Author = Authors[0]},
                new Book {Title = "Titanic", Author = Authors[0]},
                new Book {Title = "Querida encolhi as crianças", Author = Authors[1]},
                new Book {Title = "Lagoa Azul", Author = Authors[1]},
            };

            Authors[0].Books.Add(Books[0]);
            Authors[1].Books.Add(Books[1]);
        }
    }
}