namespace MvcBook.Models
{
    internal class Books
    {
        public int B_Id { get; set; }
        public string B_Name { get; set; }
        public int B_Page { get; set; }
        public int C_Id { get; set; }
        public IEnumerable<Commentaries> Commentaries  { get; set; }
    }
}