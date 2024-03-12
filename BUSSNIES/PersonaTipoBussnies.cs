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
    public class PersonaTipoBussnies : IPersonaTipoBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IPersonaTipoRepository _PersonaTipoRepository;
        private readonly IMapper _mapper;
        public PersonaTipoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _PersonaTipoRepository = new PersonaTipoRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<PersonaTipoResponse> GetAll()
        {
            //declarando la lista de PersonaTipo response como resultado
            List<PersonaTipoResponse> lstResponse = new List<PersonaTipoResponse>();
            List<PersonTipo> PersonaTipos = _PersonaTipoRepository.GetAll();

            lstResponse = _mapper.Map<List<PersonaTipoResponse>>(PersonaTipos);
            return lstResponse;
        }

        public PersonaTipoResponse GetById(int Id)
        {
            PersonTipo PersonaTipo = _PersonaTipoRepository.GetById(Id);
            PersonaTipoResponse resul = _mapper.Map<PersonaTipoResponse>(PersonaTipo);
            return resul;
        }

        public PersonaTipoResponse Create(PersonaTipoRequest entity)
        {
            PersonTipo PersonaTipo = _mapper.Map<PersonTipo>(entity);
            PersonaTipo = _PersonaTipoRepository.Create(PersonaTipo);
            PersonaTipoResponse result = _mapper.Map<PersonaTipoResponse>(PersonaTipo);
            return result;
        }
        public List<PersonaTipoResponse> InsertMultiple(List<PersonaTipoRequest> lista)
        {
            List<PersonTipo> PersonaTipos = _mapper.Map<List<PersonTipo>>(lista);
            PersonaTipos = _PersonaTipoRepository.CreateMultiple(PersonaTipos);
            List<PersonaTipoResponse> result = _mapper.Map<List<PersonaTipoResponse>>(PersonaTipos);
            return result;
        }

        public PersonaTipoResponse Update(PersonaTipoRequest entity)
        {
            PersonTipo PersonaTipo = _mapper.Map<PersonTipo>(entity);
            PersonaTipo = _PersonaTipoRepository.Update(PersonaTipo);
            PersonaTipoResponse result = _mapper.Map<PersonaTipoResponse>(PersonaTipo);
            return result;
        }

        public List<PersonaTipoResponse> UpdateMultiple(List<PersonaTipoRequest> lista)
        {
            List<PersonTipo> PersonaTipos = _mapper.Map<List<PersonTipo>>(lista);
            PersonaTipos = _PersonaTipoRepository.UpdateMultiple(PersonaTipos);
            List<PersonaTipoResponse> result = _mapper.Map<List<PersonaTipoResponse>>(PersonaTipos);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _PersonaTipoRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<PersonaTipoRequest> lista)
        {
            List<PersonTipo> PersonaTipos = _mapper.Map<List<PersonTipo>>(lista);
            int cantidad = _PersonaTipoRepository.DeleteMultipleItems(PersonaTipos);
            return cantidad;
        }

        public GenericFilterResponse<PersonaTipoResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<PersonaTipoResponse> result = _mapper.Map<GenericFilterResponse<PersonaTipoResponse>>(_PersonaTipoRepository.GetByFilter(request));

            return result;
        }

        public List<PersonaTipoResponse> CreateMultiple(List<PersonaTipoRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
