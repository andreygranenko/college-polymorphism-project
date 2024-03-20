// Main.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        Sacensibas hokejaSacensibas = new Hokejs(
            "Ziemas kausa turnirs",
            "Bebra1",
            "Bebra2",
            "Apgaismots ledus");
        // Sacensibas futbolaSacensibas = new Futbols("Latvijas kausa fināls", 22, "Skonto stadions");

        Console.WriteLine(hokejaSacensibas);
        // Console.WriteLine(futbolaSacensibas);

        hokejaSacensibas.SaktSacensibas();
        // futbolaSacensibas.SaktSacensibas();
        // hokejaSacensibas.MainInfoAboutClass();
    }
}
