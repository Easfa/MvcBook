namespace MvcBook.Models
{
    internal class Commentaries
    {
        public int C_Id { get; set; }
        public int B_Id { get; set; }
        public string C_Head { get; set; }
        public string C_Body { get; set; }
        public virtual Books Books { get; set; }

    }
}