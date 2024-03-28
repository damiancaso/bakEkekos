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
    public class DetallePedidoController : ControllerBase
    {
        #region declaracion variables generales
        public readonly IDetallePedidoBussnies _IDetallePedidoBussniess = null;
        public readonly IMapper _mapper;
        #endregion

        #region constructor
        public DetallePedidoController(IMapper mapper)
        {
            _mapper = mapper;
            _IDetallePedidoBussniess = new DetallePedidoBussnies(_mapper);
        }
        #endregion

        #region crud methods
        /// <summary>
        /// Retorna todos los registros
        /// </summary>
        /// <returns>Retorna todos los registros</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<DetallePedidoResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult GetAll()
        {
            List<DetallePedidoResponse> lst = _IDetallePedidoBussniess.GetAll();
            return Ok(lst);
        }

        /// <summary>
        /// retorna el registro por Primary key
        /// </summary>
        /// <param name="id">PK</param>
        /// <returns>retorna el registro</returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(DetallePedidoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult GetById(int id)
        {
            DetallePedidoResponse res = _IDetallePedidoBussniess.GetById(id);
            return Ok(res);
        }

        /// <summary>
        /// Inserta un nuevo registro
        /// </summary>
        /// <param name="request">Registro a insertar</param>
        /// <returns>Retorna el registro insertado</returns>

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(DetallePedidoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Create([FromBody] DetallePedidoRequest request)
        {
            DetallePedidoResponse res = _IDetallePedidoBussniess.Create(request);
            return Ok(res);
        }
        /// <summary>
        /// RETORNA LA TABLA DetallePedido EN BASE A PAGINACIÓN Y FIILTROS
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("filter")]
        public IActionResult GetByFilter([FromBody] GenericFilterRequest request)
        {
            GenericFilterResponse<DetallePedidoResponse> res = _IDetallePedidoBussniess.GetByFilter(request);

            return Ok(res);
        }

        /// <summary>
        /// Actualiza un registro
        /// </summary>
        /// <param name="entity">registro a actualizar</param>
        /// <returns>retorna el registro Actualiza</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(DetallePedidoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Update([FromBody] DetallePedidoRequest entity)
        {
            DetallePedidoResponse res = _IDetallePedidoBussniess.Update(entity);
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
            int res = _IDetallePedidoBussniess.Delete(id);
            return Ok(res);
        }



        #endregion
    }
}
