Siswa Rangga = new Siswa("Rangga", "Liorangga@gmail.com", "FUraB", "siswa", "XPG2");

Guru Bias = new Guru("Bias", "Bias@gmail.com", "12345", "guru", "PPLG");

Rangga.TampilkanInfo();
Rangga.SubmitTugas();

Console.WriteLine();

Bias.TampilkanInfo();
Bias.NilaiTugas();



class user
{


    public string Nama;

    public string Email;

    public string Password;

    public string Role;

    public user (string nama, string email, string password, string role)
    {
    Nama = nama;
    Email = email;
        Password = password;
        Role = role;
    }

    public void TampilkanInfo ()
    {
        Console.WriteLine("Menampilkan info user...");
        Console.WriteLine($"Nama: {Nama} ");
        Console.WriteLine($"Role: {Role}");
    }
}

class Siswa : user
{
    public string KelasName;
    public Siswa(string nama, string email, string password, string role, string KelasName) : base(nama, email, password, role)
    {
        KelasName = KelasName;
    }

    public void SubmitTugas()
    {
        Console.WriteLine($"Siswa {Nama} sudah mengumpulkan tugas");
    }
 }  

class Guru : user
{ 
        public String Mapel;
        public int Nilai;

    public Guru(string nama, string email, string password, string role, string mapel) : base(nama, email, password, role)
    {
    Mapel = mapel;
    }

    public void NilaiTugas()
    {
        Console.WriteLine($"Guru: {Nama} sudah menilai tugas");

    } 
}