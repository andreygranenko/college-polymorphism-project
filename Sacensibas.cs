// Klases_nosaukums.cs

using System;

// Abstrakta klase - Sacensibas
public abstract class Sacensibas
{
    protected string nosaukums;
    protected string komandasNosaukums1;
    protected string komandasNosaukums2;
    protected int dalibniekuSkaits1;
    protected int dalibniekuSkaits2;
    protected int score1 = 0;
    protected int score2 = 0;
    // Abstrakta metode - saktSacensibas
    public abstract void SaktSacensibas();

    // Virtuala metode - Nosaukums
    public virtual string Nosaukums()
    {
        return nosaukums;
    }

    protected void ChangeScore()
    {
        // Izveido objektu, lai ģenerētu nejaušus skaitļus
        Random rnd = new Random();
        // Nejaušas vērtības ģenerēšana, lai mainītu rezultātu
        int kam = rnd.Next(0, 2);
        int cik = rnd.Next(0, 5);
        // Spēles rezultāta maiņa
        if (kam == 0)
        {
            this.score1 += cik;
        } else
        {
            this.score2 += cik;
        }
        // Parādām jaunu spēles rezultātu
        Console.WriteLine($"Komandai {this.komandasNosaukums1} rezultāts ir {this.score1}, un komandai {this.komandasNosaukums2} rezultāts ir {this.score2}");
        Console.WriteLine($"{this.score1}:{this.score2}");
    }

    // Konstruktors
    public Sacensibas(
        string nosaukums, 
        string komandasNosaukums1, 
        string komandasNosaukums2)
    {
        this.nosaukums = nosaukums;
        this.komandasNosaukums1 = komandasNosaukums1;
        this.komandasNosaukums2 = komandasNosaukums2;

    }
    
    
    
    
    public virtual void MainInfoAboutClass()
    {
        Console.WriteLine(" o   \\ o /  _ o         __|    \\ /     |__        o _  \\ o /   o");
        Console.WriteLine("/|\\    |     /\\   ___\\o   \\o    |    o/    o/__   /\\     |    /|\\");
        Console.WriteLine("/ \\   / \\   | \\  /)  |    ( \\  /o\\  / )    |  (\\  / |   / \\   / \\");
    }
}

// Klase - Hokejs
public class Hokejs : Sacensibas
{
    private string ledusTips;



    // Konstruktors
    public Hokejs(
        string nosaukums,
        string komandasNosaukums1, 
        string komandasNosaukums2,
        string ledusTips) : base(
            nosaukums, 
            komandasNosaukums1, 
            komandasNosaukums2)
    {
        this.ledusTips = ledusTips;
    }

    // Tekstuala attelojums
    public override string ToString()
    {
        return $"Hokeja sacensibas '{Nosaukums()}', dalibnieku skaits: {dalibniekuSkaits1}, ledus tips: {ledusTips}";
    }

    // Pārdefinēta virtuālā metode
    public override string Nosaukums()
    {
        return $"Hokeja sacensibas ar nosaukumu '{nosaukums}'";
    }

    // Pārdefinētas abstraktas metodes
    public override void SaktSacensibas()
    {
        Console.WriteLine("          __O         O__");
        Console.WriteLine("          \\/\\         /\\/");
        Console.WriteLine("          |\\ \\       / /|");
        Console.WriteLine("         /  | \\_ = _/ |  \\");
        Console.WriteLine("        ~   ~         ~   ~");
        Console.WriteLine($"Sakas hokeja sacensibas '{nosaukums}', komanda {this.komandasNosaukums1} spēlē pret komandu {this.komandasNosaukums2} ");
        Console.WriteLine("Spēle ilgst 30 minūtes, nospiediet taustiņu Enter, lai redzētu rezultātu pēc 5 spēles minūtēm");
        
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("Nospiediet taustiņu Enter, lai mainītu rezultātu");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                ChangeScore(); // Вызываем метод для изменения счета
            } else 
            {
                Console.WriteLine("");
                i--;
                continue;
            }
        }
        
        // Pārbaudam, kura komanda uzvarēja pēc spēles beigām
        if (score1 > score2)
        {
            Console.WriteLine($"Komanda {this.komandasNosaukums1} uzvarēja ar rezultātu {this.score1}:{this.score2}!");
        }
        else if (score1 < score2)
        {
            Console.WriteLine($"Komanda {this.komandasNosaukums2} uzvarēja ar rezultātu {this.score2}:{this.score1}!");
        }
        else
        {
            Console.WriteLine("Neizšķirts!");
        }
        
    }
    
    public override void MainInfoAboutClass()
    {
        Console.WriteLine("Pamatinformācija par klasi");
        Console.WriteLine("Hokejs ir komandu sporta veids, kurā divas komandas sacenšas, lai, izmantojot nūjas, raidītu ripu pretinieka vārtos. Spēle notiek uz ledus, katras komandas mērķis ir vairāk reižu iemest ripu pretinieka vārtos, nekā pretinieks to iemeta savos vārtos.");
        base.MainInfoAboutClass();
    }
}

// Klase - Futbols
public class Futbols : Sacensibas
{
    private string stadions;

    // Konstruktors
    public Futbols(
        string nosaukums,
        string komandasNosaukums1, 
        string komandasNosaukums2,
        string stadions) : base(
            nosaukums, 
            komandasNosaukums1, 
            komandasNosaukums2)
    {
        this.stadions = stadions;
    }

    // Tekstuala attelojums
    public override string ToString()
    {
        return $"Futbola sacensibas '{Nosaukums()}', dalibnieku skaits: {dalibniekuSkaits1}, stadions: {stadions}";
    }

    // Pārdefinēta virtuālā metode
    public override string Nosaukums()
    {
        return $"Futbola sacensibas ar nosaukumu '{nosaukums}'";
    }

    // Pārdefinētas abstraktas metodes
    public override void SaktSacensibas()
    {
        Console.WriteLine($"Sakas futbola sacensibas '{nosaukums}' ar {dalibniekuSkaits1} dalibniekiem.");
    }
    
    public override void MainInfoAboutClass()
    {
        Console.WriteLine("Pamatinformācija par klasi");
        Console.WriteLine("Futbols ir komandu sporta veids, kurā divas komandas no vienpadsmit spēlētājiem sacenšas, lai ar kājām iesistu bumbu pretinieka vārtos. Spēles mērķis ir atvēlētajā laikā gūt vairāk vārtu nekā pretiniekam. Futbola laukums ir taisnstūra formas, sadalīts divās daļās, un katra komanda cenšas kontrolēt bumbu un izjaukt pretinieka plānus.");
        base.MainInfoAboutClass();
    }
}
