namespace ClassLibrary.Entities
{
    public class SellingBook
    {
        public int Id { get; set; }
        public decimal PriceBook { get; set; }
        
        public ICollection<Book>? Books { get; set; }
   
    } 
}
