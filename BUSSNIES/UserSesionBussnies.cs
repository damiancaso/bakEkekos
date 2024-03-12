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
    public class UserSesionBussnies : IUserSesionBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IUserSesionRepository _UserSesionRepository;
        private readonly IMapper _mapper;
        public UserSesionBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _UserSesionRepository = new UserSesionRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<UserSesionResponse> GetAll()
        {
            //declarando la lista de UserSesion response como resultado
            List<UserSesionResponse> lstResponse = new List<UserSesionResponse>();
            List<UserSesion> UserSesions = _UserSesionRepository.GetAll();

            lstResponse = _mapper.Map<List<UserSesionResponse>>(UserSesions);
            return lstResponse;
        }

        public UserSesionResponse GetById(int Id)
        {
            UserSesion UserSesion = _UserSesionRepository.GetById(Id);
            UserSesionResponse resul = _mapper.Map<UserSesionResponse>(UserSesion);
            return resul;
        }

        public UserSesionResponse Create(UserSesionRequest entity)
        {
            UserSesion UserSesion = _mapper.Map<UserSesion>(entity);
            UserSesion = _UserSesionRepository.Create(UserSesion);
            UserSesionResponse result = _mapper.Map<UserSesionResponse>(UserSesion);
            return result;
        }
        public List<UserSesionResponse> InsertMultiple(List<UserSesionRequest> lista)
        {
            List<UserSesion> UserSesions = _mapper.Map<List<UserSesion>>(lista);
            UserSesions = _UserSesionRepository.CreateMultiple(UserSesions);
            List<UserSesionResponse> result = _mapper.Map<List<UserSesionResponse>>(UserSesions);
            return result;
        }

        public UserSesionResponse Update(UserSesionRequest entity)
        {
            UserSesion UserSesion = _mapper.Map<UserSesion>(entity);
            UserSesion = _UserSesionRepository.Update(UserSesion);
            UserSesionResponse result = _mapper.Map<UserSesionResponse>(UserSesion);
            return result;
        }

        public List<UserSesionResponse> UpdateMultiple(List<UserSesionRequest> lista)
        {
            List<UserSesion> UserSesions = _mapper.Map<List<UserSesion>>(lista);
            UserSesions = _UserSesionRepository.UpdateMultiple(UserSesions);
            List<UserSesionResponse> result = _mapper.Map<List<UserSesionResponse>>(UserSesions);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _UserSesionRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<UserSesionRequest> lista)
        {
            List<UserSesion> UserSesions = _mapper.Map<List<UserSesion>>(lista);
            int cantidad = _UserSesionRepository.DeleteMultipleItems(UserSesions);
            return cantidad;
        }

        public GenericFilterResponse<UserSesionResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<UserSesionResponse> result = _mapper.Map<GenericFilterResponse<UserSesionResponse>>(_UserSesionRepository.GetByFilter(request));

            return result;
        }

        public List<UserSesionResponse> CreateMultiple(List<UserSesionRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
