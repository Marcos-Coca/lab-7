using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.DB;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudesController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> PostAsync(NewSolicitud newSolicitud)
        {
            using var db = new VisaContext();
            var filePath = $"Images/{newSolicitud.Documento}.jpg";
            System.IO.File.WriteAllBytes(filePath, Convert.FromBase64String(newSolicitud.Foto));

            var solicitud = new Solicitude
            {
                Apellidos = newSolicitud.Apellidos,
                Nombres = newSolicitud.Nombres,
                Sexo = newSolicitud.Sexo,
                Foto = filePath,
                Documento = newSolicitud.Documento,
                TipoDocumento = newSolicitud.TipoDocumento,
                FechaNacimiento = newSolicitud.FechaNacimiento,
                Correo = newSolicitud.Correo,
                Telefono = newSolicitud.Telefono,
            };
            db.Solicitudes.Add(solicitud);
            await db.SaveChangesAsync();

            return Ok();
        }

    }
}
