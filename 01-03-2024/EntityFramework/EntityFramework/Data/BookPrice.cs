namespace EntityFramework.Data
{
    public class BookPrice
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int CurrencyId { get; set; }
        public CurrencyType Currency { get; set; }
    }
}
