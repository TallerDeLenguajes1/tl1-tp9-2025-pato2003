namespace ID3V1
{
    public class Id3v1
    {
        private string titulo;
        private string artista;
        private string album;
        private int anio;
        private string comentario;
        private int genero;

        public Id3v1(string titulo, string artista, string album, string anio, string comentario, byte genero)
        {
            this.titulo = titulo;
            this.artista = artista;
            this.album = album;
            int.TryParse(anio, out this.anio);
            this.comentario = comentario;
            this.genero = genero;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Artista { get => artista; set => artista = value; }
        public string Album { get => album; set => album = value; }
        public int Anio { get => anio; set => anio = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public int Genero { get => genero; set => genero = value; }
    }
    
}