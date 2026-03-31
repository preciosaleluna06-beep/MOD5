// See https://aka.ms/new-console-template for more information
class PemrosesData
{
    public T DapatkanNilaiTerbesar<T> (T nilai1, T nilai2, T nilai3)
    {
        dynamic nil1 = (dynamic)nilai1;
        dynamic nil2 = (dynamic)nilai2;
        dynamic nil3 = (dynamic)nilai3;
        dynamic max = 0;

        if (nil2 > max)
        {
            max = nil2;
        }

        if (nil3 > max)
        {
            max = nil3;
        }

        return max;
    }
}

class Program
{
    static void Main(string[] args)
    {
        PemrosesData nilai = new PemrosesData();
        int max = nilai.DapatkanNilaiTerbesar(10, 30, 22);

        Console.WriteLine($"Nilai Terbesar : {max}");
    }
}