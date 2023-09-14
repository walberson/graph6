namespace graph6{
    public class Author{
        public string Name { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}