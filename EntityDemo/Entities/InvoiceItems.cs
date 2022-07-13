namespace EntityDemo.Entities
{
    public class InvoiceItems
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public Invoice Invoice { get; set; }
    }
}
