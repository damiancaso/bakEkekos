using AutoMapper;
using BUSSNIES;
using IBUSSNIES;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REQUESTRESPONSEMODEL;
using System.Net;

namespace APIWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        #region declaracion variables generales
        public readonly IUsuarioBussnies _IUsuarioBussniess = null;
        public readonly IMapper _mapper;
        #endregion

        #region constructor
        public UsuarioController(IMapper mapper)
        {
            _mapper = mapper;
            _IUsuarioBussniess = new UsuarioBussnies(_mapper);
        }
        #endregion

        #region crud methods
        /// <summary>
        /// Retorna todos los registros
        /// </summary>
        /// <returns>Retorna todos los registros</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<UsuarioResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult GetAll()
        {
            List<UsuarioResponse> lst = _IUsuarioBussniess.GetAll();
            return Ok(lst);
        }

        /// <summary>
        /// retorna el registro por Primary key
        /// </summary>
        /// <param name="id">PK</param>
        /// <returns>retorna el registro</returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(UsuarioResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult GetById(int id)
        {
            UsuarioResponse res = _IUsuarioBussniess.GetById(id);
            return Ok(res);
        }

        /// <summary>
        /// Inserta un nuevo registro
        /// </summary>
        /// <param name="request">Registro a insertar</param>
        /// <returns>Retorna el registro insertado</returns>

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(UsuarioResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Create([FromBody] UsuarioRequest request)
        {
            UsuarioResponse res = _IUsuarioBussniess.Create(request);
            return Ok(res);
        }
        /// <summary>
        /// RETORNA LA TABLA Usuario EN BASE A PAGINACIÓN Y FIILTROS
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("filter")]
        public IActionResult GetByFilter([FromBody] GenericFilterRequest request)
        {
            GenericFilterResponse<UsuarioResponse> res = _IUsuarioBussniess.GetByFilter(request);

            return Ok(res);
        }

        /// <summary>
        /// Actualiza un registro
        /// </summary>
        /// <param name="entity">registro a actualizar</param>
        /// <returns>retorna el registro Actualiza</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(UsuarioResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Update([FromBody] UsuarioRequest entity)
        {
            UsuarioResponse res = _IUsuarioBussniess.Update(entity);
            return Ok(res);
        }

        /// <summary>
        /// Elimina un registro
        /// </summary>
        /// <param name="id">Valor del PK</param>
        /// <returns>Cantidad de registros afectados</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(int))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult delete(int id)
        {
            int res = _IUsuarioBussniess.Delete(id);
            return Ok(res);
        }



        #endregion
    }
}
