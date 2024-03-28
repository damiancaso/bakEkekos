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
    public class MesaBussnies : IMesaBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IMesaRepository _MesaRepository;
        private readonly IMapper _mapper;
        public MesaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _MesaRepository = new MesaRepositoy();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<MesaResponse> GetAll()
        {
            //declarando la lista de Mesa response como resultado
            List<MesaResponse> lstResponse = new List<MesaResponse>();
            List<Mesa> Mesas = _MesaRepository.GetAll();

            lstResponse = _mapper.Map<List<MesaResponse>>(Mesas);
            return lstResponse;
        }

        public MesaResponse GetById(int Id)
        {
            Mesa Mesa = _MesaRepository.GetById(Id);
            MesaResponse resul = _mapper.Map<MesaResponse>(Mesa);
            return resul;
        }

        public MesaResponse Create(MesaRequest entity)
        {
            Mesa Mesa = _mapper.Map<Mesa>(entity);
            Mesa = _MesaRepository.Create(Mesa);
            MesaResponse result = _mapper.Map<MesaResponse>(Mesa);
            return result;
        }
        public List<MesaResponse> InsertMultiple(List<MesaRequest> lista)
        {
            List<Mesa> Mesas = _mapper.Map<List<Mesa>>(lista);
            Mesas = _MesaRepository.CreateMultiple(Mesas);
            List<MesaResponse> result = _mapper.Map<List<MesaResponse>>(Mesas);
            return result;
        }

        public MesaResponse Update(MesaRequest entity)
        {
            Mesa Mesa = _mapper.Map<Mesa>(entity);
            Mesa = _MesaRepository.Update(Mesa);
            MesaResponse result = _mapper.Map<MesaResponse>(Mesa);
            return result;
        }

        public List<MesaResponse> UpdateMultiple(List<MesaRequest> lista)
        {
            List<Mesa> Mesas = _mapper.Map<List<Mesa>>(lista);
            Mesas = _MesaRepository.UpdateMultiple(Mesas);
            List<MesaResponse> result = _mapper.Map<List<MesaResponse>>(Mesas);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _MesaRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<MesaRequest> lista)
        {
            List<Mesa> Mesas = _mapper.Map<List<Mesa>>(lista);
            int cantidad = _MesaRepository.DeleteMultipleItems(Mesas);
            return cantidad;
        }

        public GenericFilterResponse<MesaResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<MesaResponse> result = _mapper.Map<GenericFilterResponse<MesaResponse>>(_MesaRepository.GetByFilter(request));

            return result;
        }

        public List<MesaResponse> CreateMultiple(List<MesaRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
