using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    struct Client
    {
        public double KodK;
        public double Nom;
        public string Name;
        public string Ad;
        public double KilkistSakas;
        public double Sym;

        public Client(double kodk, string ad, string name, double nom, double kilkistsakas, double sym) : this()
        {
            KodK = kodk;
            Ad = ad;
            Name = name;
            Nom = nom;
            KilkistSakas = kilkistsakas;
            Sym = sym;

        }

        public void Print()
        {
            Console.WriteLine($"Ad: {Ad}, KodK: {KodK}, Name: {Name}, KilkistSakas: {KilkistSakas}, Nom: {Nom}, Sym: {Sym}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double kodk = 734235235;
            string ad = "В.Травнева, д.102 " ;
            string name = "Subenko Mihail Petrovuch";
            double nom = 067341233;
            double sym = 10000;
            double kilkistsakas = 5;

            Client client = new Client(kodk, ad, name, nom, kilkistsakas, sym);
            client.Print();
        }
    }
}
