namespace webapi.DB
{
    public class NewSolicitud
    {
        public string TipoDocumento { get; set; } = null!;

        public string Documento { get; set; } = null!;

        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public DateTime FechaNacimiento { get; set; }

        public string Sexo { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public string Correo { get; set; } = null!;

        public string Foto { get; set; } = null!;
    }
}
