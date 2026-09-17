// See https://aka.ms/new-console-template for more information

using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var assemblyName = assembly.GetName().Version;


Console.WriteLine("Hello, World!");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($"Version de .NET: {Environment.Version}");
Console.WriteLine($"Version de la aplicacion: {assemblyName}");
Console.WriteLine();
Console.WriteLine("Estrucura del proyecto:");
Console.WriteLine("Configuracion .csproj");
Console.WriteLine("Carpeta /src creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine();
Console.WriteLine("Proximo paso: Agregar argumentos CLI y configuracion de repositorio en Github");
