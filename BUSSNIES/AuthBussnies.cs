using AutoMapper;
using DocumentFormat.OpenXml.Math;
using EKEKOSDATABASEMODEL;
using IBUSSNIES;
using REQUESTRESPONSEMODEL;
using UTILSECURITY;

namespace BUSSNIES
{
    public class AuthBussnies : IAuthBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR
        private readonly IUsuarioBussnies _UsuarioBussnies;
        private readonly IRolBussnies _RolBussnies;
        private readonly IPersonaBussnies _PersonaBussnies;
        private readonly IMapper _mapper;
        //private readonly IRolAdminBussnies _RolAdminBussnies;
        private readonly UtilCripto _cripto;
        public AuthBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _UsuarioBussnies = new UsuarioBussnies(mapper);
            _RolBussnies = new RolBussnies(mapper);
            _PersonaBussnies = new PersonaBussnies(mapper);
            //_RolAdminBussnies = new RolAdminBussnies(mapper);
            _cripto = new UtilCripto();
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR
        public LoginResponse Login(LoginRequest request)
        {
            LoginResponse result = new LoginResponse();

            //validar al usuario
            VwUsuario usuario = _UsuarioBussnies.ObtenerVistaUsername(request.Username);
            if (usuario == null)
            {
                return result;
            }

            

            // proceso de encriptacion

            string newPasword = _cripto.AES_encriptar(request.Pasword);

            if (newPasword != usuario.Pasword)
            {
                return result;
            }

            result.Success = true;
            result.Mensaje = "login correcto";

            result.usuario = new UsuarioLoginResponse();

            result.usuario.IdUsuario = usuario.IdUsuario;
            result.usuario.Username = usuario.Username;
            result.usuario.ApPaterno = usuario.ApellidoPaterno;
            result.usuario.ApMaterno = usuario.ApellidoMaterno;
            result.Persona = new PersonaResponse();
            result.Persona.NombreCompleto = usuario.NombrePersona;
            result.Rol = new RolResponse();
            result.Rol.Descripcion = usuario.Rol;





            return result;
        }
    }
}
