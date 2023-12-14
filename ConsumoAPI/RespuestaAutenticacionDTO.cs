using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoAPI
{
    public class RespuestaAutenticacionDTO
    {
        public string accessToken { get; set; }
        public DateTime accessExpiracion { get; set; }
        public IList<MenuDTO>? menus { get; set; }
        public string errorResp { get; set; }

    }
    public class MenuDTO
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Recurso { get; set; }
        public IList<MenuDTO>? SubMenu { get; set; }

        public static implicit operator MenuDTO(List<MenuDTO> v)
        {
            throw new NotImplementedException();
        }


    }
}
