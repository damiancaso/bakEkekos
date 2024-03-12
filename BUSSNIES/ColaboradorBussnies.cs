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
    public class ColaboradorBussnies : IColaboradorBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IColaboradorRepository _ColaboradorRepository;
        private readonly IMapper _mapper;
        public ColaboradorBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _ColaboradorRepository = new ColaboradoRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<ColaboradorResponse> GetAll()
        {
            //declarando la lista de Colaborador response como resultado
            List<ColaboradorResponse> lstResponse = new List<ColaboradorResponse>();
            List<Colaborador> Colaboradors = _ColaboradorRepository.GetAll();

            lstResponse = _mapper.Map<List<ColaboradorResponse>>(Colaboradors);
            return lstResponse;
        }

        public ColaboradorResponse GetById(int Id)
        {
            Colaborador Colaborador = _ColaboradorRepository.GetById(Id);
            ColaboradorResponse resul = _mapper.Map<ColaboradorResponse>(Colaborador);
            return resul;
        }

        public ColaboradorResponse Create(ColaboradorRequest entity)
        {
            Colaborador Colaborador = _mapper.Map<Colaborador>(entity);
            Colaborador = _ColaboradorRepository.Create(Colaborador);
            ColaboradorResponse result = _mapper.Map<ColaboradorResponse>(Colaborador);
            return result;
        }
        public List<ColaboradorResponse> InsertMultiple(List<ColaboradorRequest> lista)
        {
            List<Colaborador> Colaboradors = _mapper.Map<List<Colaborador>>(lista);
            Colaboradors = _ColaboradorRepository.CreateMultiple(Colaboradors);
            List<ColaboradorResponse> result = _mapper.Map<List<ColaboradorResponse>>(Colaboradors);
            return result;
        }

        public ColaboradorResponse Update(ColaboradorRequest entity)
        {
            Colaborador Colaborador = _mapper.Map<Colaborador>(entity);
            Colaborador = _ColaboradorRepository.Update(Colaborador);
            ColaboradorResponse result = _mapper.Map<ColaboradorResponse>(Colaborador);
            return result;
        }

        public List<ColaboradorResponse> UpdateMultiple(List<ColaboradorRequest> lista)
        {
            List<Colaborador> Colaboradors = _mapper.Map<List<Colaborador>>(lista);
            Colaboradors = _ColaboradorRepository.UpdateMultiple(Colaboradors);
            List<ColaboradorResponse> result = _mapper.Map<List<ColaboradorResponse>>(Colaboradors);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _ColaboradorRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<ColaboradorRequest> lista)
        {
            List<Colaborador> Colaboradors = _mapper.Map<List<Colaborador>>(lista);
            int cantidad = _ColaboradorRepository.DeleteMultipleItems(Colaboradors);
            return cantidad;
        }

        public GenericFilterResponse<ColaboradorResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<ColaboradorResponse> result = _mapper.Map<GenericFilterResponse<ColaboradorResponse>>(_ColaboradorRepository.GetByFilter(request));

            return result;
        }

        public List<ColaboradorResponse> CreateMultiple(List<ColaboradorRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
