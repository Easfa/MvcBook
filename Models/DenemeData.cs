namespace MvcWorkspace.Models
{
    public class DenemeData
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public int SayfaSayisi { get; set; }
    }
    public class KullaniciDenemeData
    {
        public string username { get; set; }
        public string userpass { get; set; }
    }
    public class Yorumlar
    {
        public int Id { get; set; }
        public String Icerik { get; set; }
        
    }

}