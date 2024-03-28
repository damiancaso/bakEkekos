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
    public class ErrorBussnies : IErrorBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IErrorRepository _ErrorRepository;
        private readonly IMapper _mapper;
        public ErrorBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _ErrorRepository = new ErrorRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<ErrorResponse> GetAll()
        {
            //declarando la lista de Error response como resultado
            List<ErrorResponse> lstResponse = new List<ErrorResponse>();
            List<Error> Errors = _ErrorRepository.GetAll();

            lstResponse = _mapper.Map<List<ErrorResponse>>(Errors);
            return lstResponse;
        }

        public ErrorResponse GetById(int Id)
        {
            Error Error = _ErrorRepository.GetById(Id);
            ErrorResponse resul = _mapper.Map<ErrorResponse>(Error);
            return resul;
        }

        public ErrorResponse Create(ErrorRequest entity)
        {
            Error Error = _mapper.Map<Error>(entity);
            Error = _ErrorRepository.Create(Error);
            ErrorResponse result = _mapper.Map<ErrorResponse>(Error);
            return result;
        }
        public List<ErrorResponse> InsertMultiple(List<ErrorRequest> lista)
        {
            List<Error> Errors = _mapper.Map<List<Error>>(lista);
            Errors = _ErrorRepository.CreateMultiple(Errors);
            List<ErrorResponse> result = _mapper.Map<List<ErrorResponse>>(Errors);
            return result;
        }

        public ErrorResponse Update(ErrorRequest entity)
        {
            Error Error = _mapper.Map<Error>(entity);
            Error = _ErrorRepository.Update(Error);
            ErrorResponse result = _mapper.Map<ErrorResponse>(Error);
            return result;
        }

        public List<ErrorResponse> UpdateMultiple(List<ErrorRequest> lista)
        {
            List<Error> Errors = _mapper.Map<List<Error>>(lista);
            Errors = _ErrorRepository.UpdateMultiple(Errors);
            List<ErrorResponse> result = _mapper.Map<List<ErrorResponse>>(Errors);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _ErrorRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<ErrorRequest> lista)
        {
            List<Error> Errors = _mapper.Map<List<Error>>(lista);
            int cantidad = _ErrorRepository.DeleteMultipleItems(Errors);
            return cantidad;
        }

        public GenericFilterResponse<ErrorResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<ErrorResponse> result = _mapper.Map<GenericFilterResponse<ErrorResponse>>(_ErrorRepository.GetByFilter(request));

            return result;
        }

        public List<ErrorResponse> CreateMultiple(List<ErrorRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
