using System;

class Usuario
{
    public string Nombre { get; set; }

    private string dpi;
    private string contrasena;

    public string DPI
    {
        get { return dpi; }
        set
        {
            if (value.Length == 13 && long.TryParse(value, out _))
            {
                dpi = value;
            }
            else
            {
                Console.WriteLine("DPI inválido. Debe contener 13 dígitos.");
            }
        }
    }

    public string Contrasena
    {
        set
        {
            if (value.Length >= 6)
            {
                contrasena = value;
            }
            else
            {
                Console.WriteLine("Contraseña inválida. Debe tener al menos 6 caracteres.");
            }
        }
    }

    public bool Autenticar(string input)
    {
        return contrasena == input;
    }
}

class Programa
{
    static void Main(string[] args)
    {
        Usuario usuario = new Usuario();

        usuario.Nombre = "Eduardo Fuentes";
        usuario.DPI = "3303708551202";
        usuario.Contrasena = "Apolo2025";

        Console.Write("Ingrese su contraseña: ");
        string input = Console.ReadLine();

        if (usuario.Autenticar(input))
        {
            Console.WriteLine("Acceso autorizado");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta.");
        }
    }
}
