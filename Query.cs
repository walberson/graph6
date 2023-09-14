namespace graph6{
    public class Query{
        private readonly InMemoryDatabase _database;
        public Query(InMemoryDatabase database)
        {
            _database = database;
        }
        public Book GetBookByTitle(string title)
        {
            return _database.Books.Find(b => b.Title == title);
        }
        public List<Book> GetAllBooks()
        {
            return _database.Books;
        }

        public Author GetAuthorByName(string name)
        {
            return _database.Authors.Find(a => a.Name == name);
        }
       
        public List<Author> GetAllAuthors()
        {
            return _database.Authors;
        }
       
    }
}