namespace BookLoanApp.Modals
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string ImageCoverURL { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
