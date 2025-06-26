
using ID3V1;

string ruta = @".\12 Al vacío.mp3";
if (!File.Exists(ruta))
{
    Console.WriteLine("El archivo no existe!!!!!");
}
else
{
    byte[] buffer = new byte[128];
    using (FileStream fs = new FileStream(ruta, FileMode.Open))
    {
        fs.Seek(-128, SeekOrigin.End);
        fs.Read(buffer, 0, 128);
    }
    string header = System.Text.Encoding.GetEncoding("latin1").GetString(buffer, 0, 3);
    string titulo = System.Text.Encoding.GetEncoding("latin1").GetString(buffer, 3, 30);
    string artista = System.Text.Encoding.GetEncoding("latin1").GetString(buffer, 33, 30);
    string album = System.Text.Encoding.GetEncoding("latin1").GetString(buffer, 63, 30);
    string anio = System.Text.Encoding.GetEncoding("latin1").GetString(buffer, 93, 4);
    string comentario = System.Text.Encoding.GetEncoding("latin1").GetString(buffer, 97, 30);
    byte genero = buffer[127];

    Id3v1 tag = new Id3v1(titulo, artista, album, anio, comentario, genero);

    Console.WriteLine($"Título: {tag.Titulo}");
    Console.WriteLine($"Artista: {tag.Artista}");
    Console.WriteLine($"Álbum: {tag.Album}");
    Console.WriteLine($"Año: {tag.Anio}");
    Console.WriteLine($"Comentario: {tag.Comentario}");
    Console.WriteLine($"Género: {tag.Genero}");
}
    