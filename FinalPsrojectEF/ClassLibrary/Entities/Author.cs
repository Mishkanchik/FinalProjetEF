﻿namespace ClassLibrary.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        
        public int HowManyBooks { get; set; }
        public ICollection<Book>? Books { get; set; }

    }
}
