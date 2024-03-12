using AutoMapper;
using BUSSNIES;
using IBUSSNIES;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using REQUESTRESPONSEMODEL;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using UTILSECURITY;

namespace APIWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR
        private readonly IAuthBussnies _authBussnies;
        private readonly IMapper _mapper;
        private readonly UtilCripto _cripto;

        public AuthController(IMapper mapper)
        {
            _mapper = mapper;
            _authBussnies = new AuthBussnies(mapper);
            _cripto = new UtilCripto();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(bool))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get()
        {
            return Ok(true);
        }

        /// <summary>
        /// Metodo para realizar el inicio de sesión
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(LoginResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            LoginResponse loginResponse = _authBussnies.Login(request);
            loginResponse.Token = CreateToken(loginResponse);
            return Ok(loginResponse);
        }
        #region INICIO GENERACIÓN DE TOKEN

        private string CreateToken(LoginResponse oLoginResponse)
        {
            //obteniendo información de nuestro archivo appsettings.json
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();

            //OBTENER EL TIEMPO DE VIDA DEL TOKEN
            int tiempoVida = int.Parse(configurationFile["Jwt:TimeJWTMin"]);
            //01 VAMOS A DETALLAR LOS CLAIMS
            //==> INFORMACIÓN QUE SE PUEDE ALMACENAR DENTRO DEL TOKEN GENERADO

            /**
             * VAMOS A DECLARAR LOS CLAIMS - LA INFORMACIÓN QUE SE VA A CARGAR DENTRO DEL TOKEN
             * 
             */

            //string stringClaims = JsonConvert.SerializeObject(oLoginResponse);
            //stringClaims = _cripto.AES_encriptar(stringClaims);

            var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub, configurationFile["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        ///new Claim(ClaimTypes.Role, oLoginResponse.Rol.IdRol.ToString()),
                        new Claim("UserId", oLoginResponse.usuario.IdUsuario.ToString()),
                        new Claim("DisplaName", oLoginResponse.Persona.NombreCompleto),
                        new Claim("UserName", oLoginResponse.usuario.Username),
                        ///new Claim("DNI",oLoginResponse.usuario.NroDocumento),
                        new Claim("RoleName", oLoginResponse.Rol.Descripcion),
                    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configurationFile["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                configurationFile["Jwt:Issuer"],
                configurationFile["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddHours(tiempoVida),
                signingCredentials: signIn

                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        #endregion FIN GENERACIÓN DE TOKEN


    }
}
