// Programación Orientada a Objetos

// Es un paradigma de programación que se basa en el uso de clases y objetos.

// Creación de un objeto
// Un objeto es una instancia de una clase.
Beer beer = new Beer("Stella Artois", "Anheuser-Busch InBev", 0m, 2.5m);

Beer pilsenerBeer = new Beer("Pilsener", "Pilsener", 6.7m, 1.5m);

Console.WriteLine(pilsenerBeer.GetDescription());

//pilsenerBeer.SAlcohol = 10m; // No se puede asignar un valor a un atributo de solo lectura.

Console.WriteLine(pilsenerBeer.SAlcohol); // Se puede obtener el valor de un atributo de solo lectura.

public class Beer
{
    private decimal _alcohol; // Atributo privado

    public string Name { get; set; }
    public string Brand { get; set; }
    public decimal Alcohol
    {
        get
        {
            return _alcohol; // Se puede realizar validaciones
        }
        set
        {
            if (value < 0 || value > 100) // Validación
            {
                throw new Exception("El valor del alcohol debe estar entre 0 y 100");
            }
            _alcohol = value; // value es una palabra reservada que se utiliza para asignar el valor que se recibe.
        }
    }

    public string SAlcohol
    {
        get
        {
            return $"Grados de Alcohol: {_alcohol}%";
        }
    }
    public decimal Price { get; set; }

    // Creación del constructor
    // El contructor es un método especial que se llama cuando se crea un objeto de la clase.
    public Beer(string name, string brand, decimal alcohol, decimal price)
    {
        Name = name;
        Brand = brand;
        Alcohol = alcohol;
        Price = price;
    }

    // Creación de un método
    // Un método es una función que se define dentro de una clase.

    public string GetDescription()
    {
        return $"Nombre: {Name} - Marca: {Brand} - Grados de Alcohol: {Alcohol}%  - Precio: ${Price}";
    }
}


