using System;

class LaptopShop
{
    static void Main()
    {
        var lap1 = new Laptop("HP 250 G2", 699.00M);
        var lap2 = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U", 8, "Intel HD Graphics 4400",
            128, "13.3, IPS sensor display", new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5), 2259.00M);
        Console.WriteLine(lap1);
        Console.WriteLine(lap2);

        var bat1 = new Battery();
        var bat2 = new Battery("Big Dog", 50.5);
        Console.WriteLine(bat1);
        Console.WriteLine(bat2);
    }
}