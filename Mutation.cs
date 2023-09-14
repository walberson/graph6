namespace graph6
{
    public class Mutation
    {

        private readonly InMemoryDatabase _database;
        public Mutation(InMemoryDatabase database)
        {
            _database = database;
        }

        public Author AddAuthor(string name)
        {
            var author = _database.Authors.Find(a => a.Name == name);
            if (author != null)
            {
                return author;
            }
            var newAuthor = new Author { Name = name };

            _database.Authors.Add(newAuthor);
            return newAuthor;
        }


        public Book AddBook(string title, string authorName)
        {
            var author = _database.Authors.Find(a => a.Name == authorName);
            if (author == null)
            {
                author = new Author { Name = authorName };
                _database.Authors.Add(author);
            }
            var newBook = new Book { Title = title, Author = author };
            _database.Books.Add(newBook);

            author.Books.Add(newBook);

            return newBook;

        }
        public Book DeleteBook(string title)
        {
            var book = _database.Books.Find(b => b.Title == title);
            if (book != null)
            {
                book.Author.Books.Remove(book);
                _database.Books.Remove(book);
                return book;
            }
            return null;

        }







    }
}