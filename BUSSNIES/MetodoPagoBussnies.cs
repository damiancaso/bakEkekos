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
    public class MetodoPagoBussnies : IMetodoPagoBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IMetodoPagoRepository _MetodoPagoRepository;
        private readonly IMapper _mapper;
        public MetodoPagoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _MetodoPagoRepository = new MetodoPagoRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<MetodoPagoResponse> GetAll()
        {
            //declarando la lista de MetodoPago response como resultado
            List<MetodoPagoResponse> lstResponse = new List<MetodoPagoResponse>();
            List<MetodoPago> MetodoPagos = _MetodoPagoRepository.GetAll();

            lstResponse = _mapper.Map<List<MetodoPagoResponse>>(MetodoPagos);
            return lstResponse;
        }

        public MetodoPagoResponse GetById(int Id)
        {
            MetodoPago MetodoPago = _MetodoPagoRepository.GetById(Id);
            MetodoPagoResponse resul = _mapper.Map<MetodoPagoResponse>(MetodoPago);
            return resul;
        }

        public MetodoPagoResponse Create(MetodoPagoRequest entity)
        {
            MetodoPago MetodoPago = _mapper.Map<MetodoPago>(entity);
            MetodoPago = _MetodoPagoRepository.Create(MetodoPago);
            MetodoPagoResponse result = _mapper.Map<MetodoPagoResponse>(MetodoPago);
            return result;
        }
        public List<MetodoPagoResponse> InsertMultiple(List<MetodoPagoRequest> lista)
        {
            List<MetodoPago> MetodoPagos = _mapper.Map<List<MetodoPago>>(lista);
            MetodoPagos = _MetodoPagoRepository.CreateMultiple(MetodoPagos);
            List<MetodoPagoResponse> result = _mapper.Map<List<MetodoPagoResponse>>(MetodoPagos);
            return result;
        }

        public MetodoPagoResponse Update(MetodoPagoRequest entity)
        {
            MetodoPago MetodoPago = _mapper.Map<MetodoPago>(entity);
            MetodoPago = _MetodoPagoRepository.Update(MetodoPago);
            MetodoPagoResponse result = _mapper.Map<MetodoPagoResponse>(MetodoPago);
            return result;
        }

        public List<MetodoPagoResponse> UpdateMultiple(List<MetodoPagoRequest> lista)
        {
            List<MetodoPago> MetodoPagos = _mapper.Map<List<MetodoPago>>(lista);
            MetodoPagos = _MetodoPagoRepository.UpdateMultiple(MetodoPagos);
            List<MetodoPagoResponse> result = _mapper.Map<List<MetodoPagoResponse>>(MetodoPagos);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _MetodoPagoRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<MetodoPagoRequest> lista)
        {
            List<MetodoPago> MetodoPagos = _mapper.Map<List<MetodoPago>>(lista);
            int cantidad = _MetodoPagoRepository.DeleteMultipleItems(MetodoPagos);
            return cantidad;
        }

        public GenericFilterResponse<MetodoPagoResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<MetodoPagoResponse> result = _mapper.Map<GenericFilterResponse<MetodoPagoResponse>>(_MetodoPagoRepository.GetByFilter(request));

            return result;
        }

        public List<MetodoPagoResponse> CreateMultiple(List<MetodoPagoRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
