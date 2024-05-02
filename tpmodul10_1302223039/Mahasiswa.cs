namespace tpmodul10_1302223039
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }

        public Mahasiswa(string nama, string nim)
        {
            this.Nama = nama;
            this.Nim = nim;
        }
    }
}
