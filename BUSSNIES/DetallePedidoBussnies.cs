using AutoMapper;
using EKEKOSDATABASEMODEL;
using IBUSSNIES;
using IREPOSITORY;
using REPOSITORY;
using REQUESTRESPONSEMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSNIES
{
    public class DetallePedidoBussnies : IDetallePedidoBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IDetallePedidoRepository _DetallePedidoRepository;
        private readonly IMapper _mapper;
        public DetallePedidoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _DetallePedidoRepository = new DetallePedidoRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<DetallePedidoResponse> GetAll()
        {
            //declarando la lista de DetallePedido response como resultado
            List<DetallePedidoResponse> lstResponse = new List<DetallePedidoResponse>();
            List<DetallePedido> DetallePedidos = _DetallePedidoRepository.GetAll();

            lstResponse = _mapper.Map<List<DetallePedidoResponse>>(DetallePedidos);
            return lstResponse;
        }

        public DetallePedidoResponse GetById(int Id)
        {
            DetallePedido DetallePedido = _DetallePedidoRepository.GetById(Id);
            DetallePedidoResponse resul = _mapper.Map<DetallePedidoResponse>(DetallePedido);
            return resul;
        }

        public DetallePedidoResponse Create(DetallePedidoRequest entity)
        {
            DetallePedido DetallePedido = _mapper.Map<DetallePedido>(entity);
            DetallePedido = _DetallePedidoRepository.Create(DetallePedido);
            DetallePedidoResponse result = _mapper.Map<DetallePedidoResponse>(DetallePedido);
            return result;
        }
        public List<DetallePedidoResponse> InsertMultiple(List<DetallePedidoRequest> lista)
        {
            List<DetallePedido> DetallePedidos = _mapper.Map<List<DetallePedido>>(lista);
            DetallePedidos = _DetallePedidoRepository.CreateMultiple(DetallePedidos);
            List<DetallePedidoResponse> result = _mapper.Map<List<DetallePedidoResponse>>(DetallePedidos);
            return result;
        }

        public DetallePedidoResponse Update(DetallePedidoRequest entity)
        {
            DetallePedido DetallePedido = _mapper.Map<DetallePedido>(entity);
            DetallePedido = _DetallePedidoRepository.Update(DetallePedido);
            DetallePedidoResponse result = _mapper.Map<DetallePedidoResponse>(DetallePedido);
            return result;
        }

        public List<DetallePedidoResponse> UpdateMultiple(List<DetallePedidoRequest> lista)
        {
            List<DetallePedido> DetallePedidos = _mapper.Map<List<DetallePedido>>(lista);
            DetallePedidos = _DetallePedidoRepository.UpdateMultiple(DetallePedidos);
            List<DetallePedidoResponse> result = _mapper.Map<List<DetallePedidoResponse>>(DetallePedidos);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _DetallePedidoRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<DetallePedidoRequest> lista)
        {
            List<DetallePedido> DetallePedidos = _mapper.Map<List<DetallePedido>>(lista);
            int cantidad = _DetallePedidoRepository.DeleteMultipleItems(DetallePedidos);
            return cantidad;
        }

        public GenericFilterResponse<DetallePedidoResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<DetallePedidoResponse> result = _mapper.Map<GenericFilterResponse<DetallePedidoResponse>>(_DetallePedidoRepository.GetByFilter(request));

            return result;
        }

        public List<DetallePedidoResponse> CreateMultiple(List<DetallePedidoRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
