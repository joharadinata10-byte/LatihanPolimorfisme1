Imageprocessor imageprocessor = new Imageprocessor();

imageprocessor.Resize(-20);
imageprocessor.Resize(80);
imageprocessor.Resize(150);
imageprocessor.Resize(100);
imageprocessor.Resize(10, 15);
imageprocessor.Resize(300);


class Imageprocessor
{
    public void Resize(int persentase)
    {
        if (persentase <= 0)
        {
            Console.WriteLine("Error! Persentase tidak boleh nol atau negatif");
        }
        else if (persentase < 100)
        {
            Console.WriteLine($"Mengecilkan gambar menjadi {persentase}%");
        }
        else if (persentase > 100)
        {
            Console.WriteLine($"Membesarkan gambar menjadi {persentase}%");
        }
        else
        {
            Console.WriteLine("Ukuran tetap (100%). Tidak ada perubahan");
        }
    }

    public void Resize(int lebar, int tinggi)
    {
        Console.WriteLine($"Mengubah ukuran gambar menjadi {lebar}px X {tinggi}px");
    }
    public void Resize(string ukuran_kertas)
    {
        Console.WriteLine($"Menyesuaikan gambar menjadi {ukuran_kertas}");
    }
}














