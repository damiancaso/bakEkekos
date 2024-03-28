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
    public class PersonaBussnies : IPersonaBussnies
    {
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IPersonaRepository _PersonaRepository;
        private readonly IMapper _mapper;
        public PersonaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _PersonaRepository = new PersonaRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<PersonaResponse> GetAll()
        {
            List<PersonaResponse> lstResponse = new List<PersonaResponse>();
            List<Persona> Persona = _PersonaRepository.GetAll();

            lstResponse = _mapper.Map<List<PersonaResponse>>(Persona);
            return lstResponse;
        }
        public PersonaResponse Create(PersonaRequest entity)
        {
            Persona Persona = _mapper.Map<Persona>(entity);
            Persona = _PersonaRepository.Create(Persona);
            PersonaResponse result = _mapper.Map<PersonaResponse>(Persona);
            return result;
        }

        public PersonaResponse BuscarPorNombrePersona(string person)
        {
            PersonaResponse Persona = _mapper.Map<PersonaResponse>(_PersonaRepository.obtenerPorPersona(person));
            return Persona;
        }

        public VwPersona ObtenerVistaPersona(string person)
        {
            VwPersona Persona = _PersonaRepository.obtenerVistaPersona(person);
            return Persona;
        }

        public PersonaResponse GetById(int id)
        {
            Persona Persona = _PersonaRepository.GetById(id);
            PersonaResponse resul = _mapper.Map<PersonaResponse>(Persona);
            return resul;
        }

        public PersonaResponse Update(PersonaRequest entity)
        {
            Persona Persona = _mapper.Map<Persona>(entity);
            Persona = _PersonaRepository.Update(Persona);
            PersonaResponse result = _mapper.Map<PersonaResponse>(Persona);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _PersonaRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<PersonaRequest> lista)
        {
            List<Persona> Persona = _mapper.Map<List<Persona>>(lista);
            int cantidad = _PersonaRepository.DeleteMultipleItems(Persona);
            return cantidad;
        }

        public List<PersonaResponse> InsertMultiple(List<PersonaRequest> lista)
        {
            List<Persona> Persona = _mapper.Map<List<Persona>>(lista);
            Persona = _PersonaRepository.CreateMultiple(Persona);
            List<PersonaResponse> resul = _mapper.Map<List<PersonaResponse>>(Persona);

            return resul;
        }

        public List<PersonaResponse> CreateMultiple(List<PersonaRequest> lista)
        {
            throw new NotImplementedException();
        }

        public List<PersonaResponse> UpdateMultiple(List<PersonaRequest> lista)
        {
            List<Persona> Personas = _mapper.Map<List<Persona>>(lista);
            Personas = _PersonaRepository.UpdateMultiple(Personas);
            List<PersonaResponse> result = _mapper.Map<List<PersonaResponse>>(Personas);
            return result;
        }

        public GenericFilterResponse<PersonaResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<PersonaResponse> result = _mapper.Map<GenericFilterResponse<PersonaResponse>>(_PersonaRepository.GetByFilter(request));

            return result;
        }
        #endregion
    }
}
