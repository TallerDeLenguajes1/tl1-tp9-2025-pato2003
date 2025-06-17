void mostrarCarpetas(string ruta)
{
    Console.WriteLine("----------CARPETAS----------");
    string[] carpetas = Directory.GetDirectories(ruta);
    foreach (var carpeta in carpetas)
    {
        DirectoryInfo di = new DirectoryInfo(carpeta);
        Console.WriteLine(di.Name);
    }
    Console.WriteLine("----------------------------");


}
void mostrarArchivos(string ruta)
{
    string[] archivos = Directory.GetFiles(ruta);
    Console.WriteLine("----------ARCHIVOS----------");
    foreach (var archivo in archivos)
    {
        FileInfo fi = new FileInfo(archivo);
        Console.WriteLine($"Nombre: {fi.Name}, Tamanio: {(double)(fi.Length/1024)} kiloBytes");
    }
    Console.WriteLine("----------------------------");
    
}
Console.WriteLine("Ingrese la ruta de la carpeta que desea analizar: ");
string ruta = Console.ReadLine();
while (!Directory.Exists(ruta))
{
    Console.WriteLine("Ruta ingresada invalida. Ingrese nuevamente la ruta de la carpeta que desea analizar: ");
    ruta = Console.ReadLine();
}

Console.WriteLine("El directorio si existe");
mostrarArchivos(ruta);
mostrarCarpetas(ruta);

Console.WriteLine("\n-------CREACION DEL ARCHIVO------");
string nombreArchivo = ".\\reporte_archivos.csv";
var listaArchivos = Directory.GetFiles(ruta);


using (StreamWriter sw = new StreamWriter(nombreArchivo))
{

sw.WriteLine("Nombre del Archivo;Tamanio(kB);Fecha de la Ultima Modificacion");
foreach (var archivo in listaArchivos)
{
    FileInfo fi = new FileInfo(archivo);
    sw.WriteLine($"{fi.Name};{Math.Round(fi.Length / 1024.0, 2)};{fi.LastAccessTime}");
}
Console.WriteLine("El archivo fue creado con exito");
    
}

Console.WriteLine("---------------------------------\n");





