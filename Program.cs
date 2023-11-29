namespace Proje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.sayıyı giriniz");
            byte sayi1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz");
            byte sayi2 = byte.Parse(Console.ReadLine());
            string sonuc = sayi1 > sayi2 ? "birinci sayı büyüktür" : "2.sayı büyüktür ya da sayılar eşittir";
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}