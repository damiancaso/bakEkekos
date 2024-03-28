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
    public class UbicacionGeoBussnies : IUbicacionGeoBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IUbicacionGeoRepository _UbicacionGeoRepository;
        private readonly IMapper _mapper;
        public UbicacionGeoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _UbicacionGeoRepository = new UbicacionGeoRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<UbicacionGeoResponse> GetAll()
        {
            //declarando la lista de UbicacionGeo response como resultado
            List<UbicacionGeoResponse> lstResponse = new List<UbicacionGeoResponse>();
            List<UbicacionGeo> UbicacionGeos = _UbicacionGeoRepository.GetAll();

            lstResponse = _mapper.Map<List<UbicacionGeoResponse>>(UbicacionGeos);
            return lstResponse;
        }

        public UbicacionGeoResponse GetById(int Id)
        {
            UbicacionGeo UbicacionGeo = _UbicacionGeoRepository.GetById(Id);
            UbicacionGeoResponse resul = _mapper.Map<UbicacionGeoResponse>(UbicacionGeo);
            return resul;
        }

        public UbicacionGeoResponse Create(UbicacionGeoRequest entity)
        {
            UbicacionGeo UbicacionGeo = _mapper.Map<UbicacionGeo>(entity);
            UbicacionGeo = _UbicacionGeoRepository.Create(UbicacionGeo);
            UbicacionGeoResponse result = _mapper.Map<UbicacionGeoResponse>(UbicacionGeo);
            return result;
        }
        public List<UbicacionGeoResponse> InsertMultiple(List<UbicacionGeoRequest> lista)
        {
            List<UbicacionGeo> UbicacionGeos = _mapper.Map<List<UbicacionGeo>>(lista);
            UbicacionGeos = _UbicacionGeoRepository.CreateMultiple(UbicacionGeos);
            List<UbicacionGeoResponse> result = _mapper.Map<List<UbicacionGeoResponse>>(UbicacionGeos);
            return result;
        }

        public UbicacionGeoResponse Update(UbicacionGeoRequest entity)
        {
            UbicacionGeo UbicacionGeo = _mapper.Map<UbicacionGeo>(entity);
            UbicacionGeo = _UbicacionGeoRepository.Update(UbicacionGeo);
            UbicacionGeoResponse result = _mapper.Map<UbicacionGeoResponse>(UbicacionGeo);
            return result;
        }

        public List<UbicacionGeoResponse> UpdateMultiple(List<UbicacionGeoRequest> lista)
        {
            List<UbicacionGeo> UbicacionGeos = _mapper.Map<List<UbicacionGeo>>(lista);
            UbicacionGeos = _UbicacionGeoRepository.UpdateMultiple(UbicacionGeos);
            List<UbicacionGeoResponse> result = _mapper.Map<List<UbicacionGeoResponse>>(UbicacionGeos);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _UbicacionGeoRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<UbicacionGeoRequest> lista)
        {
            List<UbicacionGeo> UbicacionGeos = _mapper.Map<List<UbicacionGeo>>(lista);
            int cantidad = _UbicacionGeoRepository.DeleteMultipleItems(UbicacionGeos);
            return cantidad;
        }

        public GenericFilterResponse<UbicacionGeoResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<UbicacionGeoResponse> result = _mapper.Map<GenericFilterResponse<UbicacionGeoResponse>>(_UbicacionGeoRepository.GetByFilter(request));

            return result;
        }

        public List<UbicacionGeoResponse> CreateMultiple(List<UbicacionGeoRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
