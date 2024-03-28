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
    public class PersonaTipoDocumentoBussnies : IPersonaTipoDocumentoBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IPersonaTipoDocumentoRepository _PersonaTipoDocumentoRepository;
        private readonly IMapper _mapper;
        public PersonaTipoDocumentoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _PersonaTipoDocumentoRepository = new PersonaTipoDocumentoRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<PersonaTipoDocumentoResponse> GetAll()
        {
            //declarando la lista de PersonaTipoDocumento response como resultado
            List<PersonaTipoDocumentoResponse> lstResponse = new List<PersonaTipoDocumentoResponse>();
            List<PersonaTipoDocumento> PersonaTipoDocumentos = _PersonaTipoDocumentoRepository.GetAll();

            lstResponse = _mapper.Map<List<PersonaTipoDocumentoResponse>>(PersonaTipoDocumentos);
            return lstResponse;
        }

        public PersonaTipoDocumentoResponse GetById(int Id)
        {
            PersonaTipoDocumento PersonaTipoDocumento = _PersonaTipoDocumentoRepository.GetById(Id);
            PersonaTipoDocumentoResponse resul = _mapper.Map<PersonaTipoDocumentoResponse>(PersonaTipoDocumento);
            return resul;
        }

        public PersonaTipoDocumentoResponse Create(PersonaTipoDocumentoRequest entity)
        {
            PersonaTipoDocumento PersonaTipoDocumento = _mapper.Map<PersonaTipoDocumento>(entity);
            PersonaTipoDocumento = _PersonaTipoDocumentoRepository.Create(PersonaTipoDocumento);
            PersonaTipoDocumentoResponse result = _mapper.Map<PersonaTipoDocumentoResponse>(PersonaTipoDocumento);
            return result;
        }
        public List<PersonaTipoDocumentoResponse> InsertMultiple(List<PersonaTipoDocumentoRequest> lista)
        {
            List<PersonaTipoDocumento> PersonaTipoDocumentos = _mapper.Map<List<PersonaTipoDocumento>>(lista);
            PersonaTipoDocumentos = _PersonaTipoDocumentoRepository.CreateMultiple(PersonaTipoDocumentos);
            List<PersonaTipoDocumentoResponse> result = _mapper.Map<List<PersonaTipoDocumentoResponse>>(PersonaTipoDocumentos);
            return result;
        }

        public PersonaTipoDocumentoResponse Update(PersonaTipoDocumentoRequest entity)
        {
            PersonaTipoDocumento PersonaTipoDocumento = _mapper.Map<PersonaTipoDocumento>(entity);
            PersonaTipoDocumento = _PersonaTipoDocumentoRepository.Update(PersonaTipoDocumento);
            PersonaTipoDocumentoResponse result = _mapper.Map<PersonaTipoDocumentoResponse>(PersonaTipoDocumento);
            return result;
        }

        public List<PersonaTipoDocumentoResponse> UpdateMultiple(List<PersonaTipoDocumentoRequest> lista)
        {
            List<PersonaTipoDocumento> PersonaTipoDocumentos = _mapper.Map<List<PersonaTipoDocumento>>(lista);
            PersonaTipoDocumentos = _PersonaTipoDocumentoRepository.UpdateMultiple(PersonaTipoDocumentos);
            List<PersonaTipoDocumentoResponse> result = _mapper.Map<List<PersonaTipoDocumentoResponse>>(PersonaTipoDocumentos);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _PersonaTipoDocumentoRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<PersonaTipoDocumentoRequest> lista)
        {
            List<PersonaTipoDocumento> PersonaTipoDocumentos = _mapper.Map<List<PersonaTipoDocumento>>(lista);
            int cantidad = _PersonaTipoDocumentoRepository.DeleteMultipleItems(PersonaTipoDocumentos);
            return cantidad;
        }

        public GenericFilterResponse<PersonaTipoDocumentoResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<PersonaTipoDocumentoResponse> result = _mapper.Map<GenericFilterResponse<PersonaTipoDocumentoResponse>>(_PersonaTipoDocumentoRepository.GetByFilter(request));

            return result;
        }

        public List<PersonaTipoDocumentoResponse> CreateMultiple(List<PersonaTipoDocumentoRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
