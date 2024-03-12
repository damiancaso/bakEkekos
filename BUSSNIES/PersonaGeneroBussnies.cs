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
    public class PersonaGeneroBussnies : IPersonaGeneroBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IPersonaGeneroRepository _PersonaGeneroRepository;
        private readonly IMapper _mapper;
        public PersonaGeneroBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _PersonaGeneroRepository = new PersonaGeneroRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<PersonaGeneroResponse> GetAll()
        {
            //declarando la lista de PersonaGenero response como resultado
            List<PersonaGeneroResponse> lstResponse = new List<PersonaGeneroResponse>();
            List<PersonaGenero> PersonaGeneros = _PersonaGeneroRepository.GetAll();

            lstResponse = _mapper.Map<List<PersonaGeneroResponse>>(PersonaGeneros);
            return lstResponse;
        }

        public PersonaGeneroResponse GetById(int Id)
        {
            PersonaGenero PersonaGenero = _PersonaGeneroRepository.GetById(Id);
            PersonaGeneroResponse resul = _mapper.Map<PersonaGeneroResponse>(PersonaGenero);
            return resul;
        }

        public PersonaGeneroResponse Create(PersonaGeneroRequest entity)
        {
            PersonaGenero PersonaGenero = _mapper.Map<PersonaGenero>(entity);
            PersonaGenero = _PersonaGeneroRepository.Create(PersonaGenero);
            PersonaGeneroResponse result = _mapper.Map<PersonaGeneroResponse>(PersonaGenero);
            return result;
        }
        public List<PersonaGeneroResponse> InsertMultiple(List<PersonaGeneroRequest> lista)
        {
            List<PersonaGenero> PersonaGeneros = _mapper.Map<List<PersonaGenero>>(lista);
            PersonaGeneros = _PersonaGeneroRepository.CreateMultiple(PersonaGeneros);
            List<PersonaGeneroResponse> result = _mapper.Map<List<PersonaGeneroResponse>>(PersonaGeneros);
            return result;
        }

        public PersonaGeneroResponse Update(PersonaGeneroRequest entity)
        {
            PersonaGenero PersonaGenero = _mapper.Map<PersonaGenero>(entity);
            PersonaGenero = _PersonaGeneroRepository.Update(PersonaGenero);
            PersonaGeneroResponse result = _mapper.Map<PersonaGeneroResponse>(PersonaGenero);
            return result;
        }

        public List<PersonaGeneroResponse> UpdateMultiple(List<PersonaGeneroRequest> lista)
        {
            List<PersonaGenero> PersonaGeneros = _mapper.Map<List<PersonaGenero>>(lista);
            PersonaGeneros = _PersonaGeneroRepository.UpdateMultiple(PersonaGeneros);
            List<PersonaGeneroResponse> result = _mapper.Map<List<PersonaGeneroResponse>>(PersonaGeneros);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _PersonaGeneroRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<PersonaGeneroRequest> lista)
        {
            List<PersonaGenero> PersonaGeneros = _mapper.Map<List<PersonaGenero>>(lista);
            int cantidad = _PersonaGeneroRepository.DeleteMultipleItems(PersonaGeneros);
            return cantidad;
        }

        public GenericFilterResponse<PersonaGeneroResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<PersonaGeneroResponse> result = _mapper.Map<GenericFilterResponse<PersonaGeneroResponse>>(_PersonaGeneroRepository.GetByFilter(request));

            return result;
        }

        public List<PersonaGeneroResponse> CreateMultiple(List<PersonaGeneroRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
