using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223039.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : Controller
    {
         public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Zidan Siva Fajar", "1302223039"),
            new Mahasiswa("Reihan Ramadhana Anwari", "1302220048"),
            new Mahasiswa("Muhammad Rafif AryaSatya Purnomo", "1302220003"),
            new Mahasiswa("Muhammad Ghaziveda Belvanaufal", "1302220011"),
            new Mahasiswa("Daffa Adrianto Effendi", "1302220151"),
            new Mahasiswa("Mochammad Rizky Septian", "1302220121"),
            new Mahasiswa("Muhammad Ghiyats Fatiha", "1302220109")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }


        [HttpGet("{id}")]
        public Mahasiswa Gett(int id)
        {
            return dataMahasiswa[id];
        }


        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
