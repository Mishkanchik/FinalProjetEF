namespace ClassLibrary.Entities
{
    public class CostBook
    {
        public int Id { get; set; }
        
        public decimal PaperExpenses { get; set; }
        public decimal СardboardExpenses { get; set; }
        
        public Book? Books { get; set; }  
        public int BookId { get; set; }
        
       




    }
}
