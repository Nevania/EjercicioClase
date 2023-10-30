// See https://aka.ms/new-console-template for more information

class SuperHeroe
{
    public string nombre { get; set; }
    public string identidadSecreta { get; set; }
    public string ciudad { get; set; }
    public bool puedeVolar { get; set; }
}


class SuperPoder
{
    public string nombre { get; set; }
    public string descripcion { get; set; }
    public int nivel { get; set; }
    public string superPoder { get; set; }
}

class Programa
{
    static void Main(string[] args)
    {
        SuperPoder poder = new SuperPoder
        {
            nombre = "Fuerza Suprema",
            descripcion = "Capacidad para levantar cualquier objeto",
            nivel = 10,
           superPoder = "Fuerza",
    };

        SuperHeroe heroe = new SuperHeroe
        {
            nombre = "Batman",
            identidadSecreta = "Bruce Wayne",
            ciudad = "Gotham City",
            puedeVolar = false,
           


          
        };

        Console.WriteLine($"Nombre: {heroe.nombre}");
        Console.WriteLine($"Identidad Secreta: {heroe.identidadSecreta}");
        Console.WriteLine($"Ciudad: {heroe.ciudad}");
        Console.WriteLine($"Puede Volar: {heroe.puedeVolar}");
        Console.WriteLine($"Super Poder: {poder.superPoder}");
        Console.WriteLine($"Descripcion: {poder.descripcion}");
        Console.WriteLine($"Nivel: {poder.nivel}");
    }
}

class PrimerSuperHeroe
{
    static void Main(string[] args)
    {
        SuperPoder poder = new SuperPoder
        {
            nombre = "Fuerza Suprema",
            descripcion = "Capacidad para levantar cualquier objeto",
            nivel = 10,
            superPoder = "Fuerza",
        };

        SuperHeroe heroe = new SuperHeroe
        {
            nombre = "Batman",
            identidadSecreta = "Bruce Wayne",
            ciudad = "Gotham City",
            puedeVolar = false,




        };

        Console.WriteLine($"Nombre: {heroe.nombre}");
        Console.WriteLine($"Identidad Secreta: {heroe.identidadSecreta}");
        Console.WriteLine($"Ciudad: {heroe.ciudad}");
        Console.WriteLine($"Puede Volar: {heroe.puedeVolar}");
        Console.WriteLine($"Super Poder: {poder.superPoder}");
        Console.WriteLine($"Descripcion: {poder.descripcion}");
        Console.WriteLine($"Nivel: {poder.nivel}");
    }
}

class segundoSuperHeroe
{
    static void Main(string[] args)
    {
        SuperPoder poder = new SuperPoder
        {
            nombre = "Fuerza Suprema",
            descripcion = "Capacidad para volar",
            nivel = 9,
            superPoder = "volar",
        };

        SuperHeroe heroe = new SuperHeroe
        {
            nombre = "SuperMan",
            identidadSecreta = "Clark Kent",
            ciudad = "Mtropolis",
            puedeVolar = true,




        };

        Console.WriteLine($"Nombre: {heroe.nombre}");
        Console.WriteLine($"Identidad Secreta: {heroe.identidadSecreta}");
        Console.WriteLine($"Ciudad: {heroe.ciudad}");
        Console.WriteLine($"Puede Volar: {heroe.puedeVolar}");
        Console.WriteLine($"Super Poder: {poder.superPoder}");
        Console.WriteLine($"Descripcion: {poder.descripcion}");
        Console.WriteLine($"Nivel: {poder.nivel}");
    }
}

class TercerSuperHeroe
{
    static void Main(string[] args)
    {
        SuperPoder poder = new SuperPoder
        {
            nombre = "Fuerza Suprema",
            descripcion = "Capacidad para que la gente diga la verdad",
            nivel = 10,
            superPoder = "Fuerza",
        };

        SuperHeroe heroe = new SuperHeroe
        {
            nombre = "Mujer Maravilla",
            identidadSecreta = "Luxy Mant",
            ciudad = "Gothijamn",
            puedeVolar = false,




        };

        Console.WriteLine($"Nombre: {heroe.nombre}");
        Console.WriteLine($"Identidad Secreta: {heroe.identidadSecreta}");
        Console.WriteLine($"Ciudad: {heroe.ciudad}");
        Console.WriteLine($"Puede Volar: {heroe.puedeVolar}");
        Console.WriteLine($"Super Poder: {poder.superPoder}");
        Console.WriteLine($"Descripcion: {poder.descripcion}");
        Console.WriteLine($"Nivel: {poder.nivel}");
    }
}






