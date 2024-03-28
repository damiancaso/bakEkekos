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
    public class PedidoBussnies : IPedidoBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IPedidoRepository _PedidoRepository;
        private readonly IMapper _mapper;
        public PedidoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _PedidoRepository = new PedidoRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<PedidoResponse> GetAll()
        {
            //declarando la lista de Pedido response como resultado
            List<PedidoResponse> lstResponse = new List<PedidoResponse>();
            List<Pedido> Pedidos = _PedidoRepository.GetAll();

            lstResponse = _mapper.Map<List<PedidoResponse>>(Pedidos);
            return lstResponse;
        }

        public PedidoResponse GetById(int Id)
        {
            Pedido Pedido = _PedidoRepository.GetById(Id);
            PedidoResponse resul = _mapper.Map<PedidoResponse>(Pedido);
            return resul;
        }

        public PedidoResponse Create(PedidoRequest entity)
        {
            Pedido Pedido = _mapper.Map<Pedido>(entity);
            Pedido = _PedidoRepository.Create(Pedido);
            PedidoResponse result = _mapper.Map<PedidoResponse>(Pedido);
            return result;
        }
        public List<PedidoResponse> InsertMultiple(List<PedidoRequest> lista)
        {
            List<Pedido> Pedidos = _mapper.Map<List<Pedido>>(lista);
            Pedidos = _PedidoRepository.CreateMultiple(Pedidos);
            List<PedidoResponse> result = _mapper.Map<List<PedidoResponse>>(Pedidos);
            return result;
        }

        public PedidoResponse Update(PedidoRequest entity)
        {
            Pedido Pedido = _mapper.Map<Pedido>(entity);
            Pedido = _PedidoRepository.Update(Pedido);
            PedidoResponse result = _mapper.Map<PedidoResponse>(Pedido);
            return result;
        }

        public List<PedidoResponse> UpdateMultiple(List<PedidoRequest> lista)
        {
            List<Pedido> Pedidos = _mapper.Map<List<Pedido>>(lista);
            Pedidos = _PedidoRepository.UpdateMultiple(Pedidos);
            List<PedidoResponse> result = _mapper.Map<List<PedidoResponse>>(Pedidos);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _PedidoRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<PedidoRequest> lista)
        {
            List<Pedido> Pedidos = _mapper.Map<List<Pedido>>(lista);
            int cantidad = _PedidoRepository.DeleteMultipleItems(Pedidos);
            return cantidad;
        }

        public GenericFilterResponse<PedidoResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<PedidoResponse> result = _mapper.Map<GenericFilterResponse<PedidoResponse>>(_PedidoRepository.GetByFilter(request));

            return result;
        }

        public List<PedidoResponse> CreateMultiple(List<PedidoRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
