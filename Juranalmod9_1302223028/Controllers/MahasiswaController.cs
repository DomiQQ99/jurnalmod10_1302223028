using Juranalmod9_1302223028.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223028.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaControl : ControllerBase
    {

        private static List<Mahasiswa> mahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa("Rifqi", "1302223028" , new List<string>{"KPL"}, 2024)

        };

        // menggunakan IEnumerable untuk menampilkan seluruh list
        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }

        // menggunakan post untuk menambah data pada list mahasiswa
        [HttpPost]
        public void post([FromBody] Mahasiswa ListMahasiswa)
        {
            mahasiswa.Add(ListMahasiswa);
        }
        [HttpGet("{id}")]

        // menampilan data mahasiwa berdasarkan id yang diinput
        public Mahasiswa Get(int id)
        {
            return mahasiswa[id];
        }
        [HttpDelete("{id}")]


        // menggunakan delete untuk menghapus data list berdasarkan id
        public void delete(int id)
        {
            mahasiswa.RemoveAt(id);
        }
    }
}