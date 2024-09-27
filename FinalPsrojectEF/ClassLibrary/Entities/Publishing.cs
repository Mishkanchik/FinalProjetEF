namespace ClassLibrary.Entities
{
    public class Publishing
    {
        public int Id { get; set; }
        public string? NamePublishing { get; set; }

        public ICollection<Book>? Books { get; set; }
       

    }
}
