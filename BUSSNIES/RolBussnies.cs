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
    public class RolBussnies : IRolBussnies
    {
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IRolRepository _RolRepository;
        private readonly IMapper _mapper;
        public RolBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _RolRepository = new RolRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<RolResponse> GetAll()
        {
            List<RolResponse> lstResponse = new List<RolResponse>();
            List<Rol> Rol = _RolRepository.GetAll();

            lstResponse = _mapper.Map<List<RolResponse>>(Rol);
            return lstResponse;
        }
        public RolResponse Create(RolRequest entity)
        {
            Rol Rol = _mapper.Map<Rol>(entity);
            Rol = _RolRepository.Create(Rol);
            RolResponse result = _mapper.Map<RolResponse>(Rol);
            return result;
        }
   

        public RolResponse GetById(int id)
        {
            Rol Rol = _RolRepository.GetById(id);
            RolResponse resul = _mapper.Map<RolResponse>(Rol);
            return resul;
        }

        public RolResponse Update(RolRequest entity)
        {
            Rol Rol = _mapper.Map<Rol>(entity);
            Rol = _RolRepository.Update(Rol);
            RolResponse result = _mapper.Map<RolResponse>(Rol);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _RolRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<RolRequest> lista)
        {
            List<Rol> Rol = _mapper.Map<List<Rol>>(lista);
            int cantidad = _RolRepository.DeleteMultipleItems(Rol);
            return cantidad;
        }

        public List<RolResponse> InsertMultiple(List<RolRequest> lista)
        {
            List<Rol> Rol = _mapper.Map<List<Rol>>(lista);
            Rol = _RolRepository.CreateMultiple(Rol);
            List<RolResponse> resul = _mapper.Map<List<RolResponse>>(Rol);

            return resul;
        }

        public List<RolResponse> CreateMultiple(List<RolRequest> lista)
        {
            throw new NotImplementedException();
        }

        public List<RolResponse> UpdateMultiple(List<RolRequest> lista)
        {
            List<Rol> Rols = _mapper.Map<List<Rol>>(lista);
            Rols = _RolRepository.UpdateMultiple(Rols);
            List<RolResponse> result = _mapper.Map<List<RolResponse>>(Rols);
            return result;
        }

        public GenericFilterResponse<RolResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<RolResponse> result = _mapper.Map<GenericFilterResponse<RolResponse>>(_RolRepository.GetByFilter(request));

            return result;
        }

        public RolResponse BuscarPorNombreRol(string role)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
