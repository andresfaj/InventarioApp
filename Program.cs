// See https://aka.ms/new-console-template for more information

using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var assemblyName = assembly.GetName().Version;

if(args.Length > 0){
    switch(args[0].ToLower()){
        case "--help":
            MostrarAyuda();
            Environment.Exit(0); //el cero es un codigo de salida que indica que el programa se ejecuto correctamente
            break;
        case "--version":
            Console.WriteLine($"Inventario app: v[{assemblyName}]");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine($"Error: comando desconocido {args[0]}");
            Console.WriteLine("use--help para ver los comandos disponibles");
            // Environment.Exit(1); // el uno es un codigo de salida que indica que el programa se ejecuto con errores
            Environment.Exit(2); // el dos es un codigo de salida que indica que el programa se ejecuto con argumentos desconocidos
            break;
    }
}

MostrarBanner();

//Modo interactivo si no hay argumentos
Console.Write("Ingrese un comando (o 'salir' para terminar): ");
string? entrada = Console.ReadLine(); //Esperar entrada del usuario y el ? despues del string indica que puede ser nulo, STDIN

if (string.IsNullOrWhiteSpace(entrada) || entrada.ToLower() == "salir")
{
    Console.WriteLine("Saliendo del programa...");
    Environment.Exit(0);
}


// Console.WriteLine("Hello, World!");
// Console.WriteLine($"Plataforma: {Environment.OSVersion}");
// Console.WriteLine($"Version de la aplicacion: {assemblyName}");
// Console.WriteLine();
// Console.WriteLine("Estrucura del proyecto:");
// Console.WriteLine("Configuracion .csproj");
// Console.WriteLine("Carpeta /src creada");
// Console.WriteLine("Metadatos configurados");
// Console.WriteLine();
// Console.WriteLine("Proximo paso: Agregar argumentos CLI y configuracion de repositorio en Github");

// ========== FUNCIONES ==============

void MostrarAyuda()
{
    Console.WriteLine("USO: InventarioApp [comando] [opciones]");
    Console.WriteLine();
    Console.WriteLine("COMANDOS:");
    Console.WriteLine("  --help, -h      Muestra esta ayuda");
    Console.WriteLine("  --version, -v   Muestra la version del programa");
    Console.WriteLine();
    Console.WriteLine("EJEMPLOS:");
    Console.WriteLine(" dotnet run -- --help");
    Console.WriteLine(" dotnet run -- --version");
}

void MostrarBanner()
{
    Console.WriteLine("╔══════════════════════════════════════╗");
    Console.WriteLine("║   SISTEMA DE GESTIÓN DE INVENTARIO   ║");
    Console.WriteLine("╚══════════════════════════════════════╝");
    Console.WriteLine();
    Console.WriteLine($"Versión: {assemblyName}");
    Console.WriteLine($".NET: {Environment.Version}");
    Console.WriteLine($"Sistema: {Environment.OSVersion.Platform}");
    Console.WriteLine();
}
