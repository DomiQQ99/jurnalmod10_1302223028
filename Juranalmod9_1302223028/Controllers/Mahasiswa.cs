namespace Juranalmod9_1302223028.Controllers
{
    public class Mahasiswa
    {
        public String nama {get; set;}
        public String NIM { get; set; }
        public List<String> Course { get; set;}
        public int year { get; set; }

        public Mahasiswa(string nama, string NIM, List<String> Course, int year )
        {
            Course = new List<String>();
            this.nama = nama;
            this.NIM = NIM;
            this.Course = Course;
            this.year = year;
        }
    }
}
