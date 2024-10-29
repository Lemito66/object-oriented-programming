// Programación Orientada a Objetos

// Es un paradigma de programación que se basa en el uso de clases y objetos.

var beer = new Beer
{
    Name = "Stella Artois",
    Brand = "AB InBev",
    Alcohol = 5.0,
    Price = 2.5m
};

Console.WriteLine(beer.Name);



public class Beer
{

   public string Name { get; set; }
   public string Brand { get; set; }
   public double Alcohol { get; set; }
   public decimal Price { get; set; }
}


