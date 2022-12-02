namespace Kişisel_Veri_Kayit_Uygulamasi
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Male { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Experience> Experiences { get; set; }

        public User()
        {
            Addresses = new List<Address>();
            Experiences = new List<Experience>();
        }
    }
}
