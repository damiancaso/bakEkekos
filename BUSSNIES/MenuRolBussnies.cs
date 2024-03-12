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
    public class MenuRolBussnies : IMenuRolBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IMenuRolRepository _MenuRolRepository;
        private readonly IMapper _mapper;
        public MenuRolBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _MenuRolRepository = new MenuRolRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<MenuRolResponse> GetAll()
        {
            //declarando la lista de MenuRol response como resultado
            List<MenuRolResponse> lstResponse = new List<MenuRolResponse>();
            List<MenuRol> MenuRols = _MenuRolRepository.GetAll();

            lstResponse = _mapper.Map<List<MenuRolResponse>>(MenuRols);
            return lstResponse;
        }

        public MenuRolResponse GetById(int Id)
        {
            MenuRol MenuRol = _MenuRolRepository.GetById(Id);
            MenuRolResponse resul = _mapper.Map<MenuRolResponse>(MenuRol);
            return resul;
        }

        public MenuRolResponse Create(MenuRolRequest entity)
        {
            MenuRol MenuRol = _mapper.Map<MenuRol>(entity);
            MenuRol = _MenuRolRepository.Create(MenuRol);
            MenuRolResponse result = _mapper.Map<MenuRolResponse>(MenuRol);
            return result;
        }
        public List<MenuRolResponse> InsertMultiple(List<MenuRolRequest> lista)
        {
            List<MenuRol> MenuRols = _mapper.Map<List<MenuRol>>(lista);
            MenuRols = _MenuRolRepository.CreateMultiple(MenuRols);
            List<MenuRolResponse> result = _mapper.Map<List<MenuRolResponse>>(MenuRols);
            return result;
        }

        public MenuRolResponse Update(MenuRolRequest entity)
        {
            MenuRol MenuRol = _mapper.Map<MenuRol>(entity);
            MenuRol = _MenuRolRepository.Update(MenuRol);
            MenuRolResponse result = _mapper.Map<MenuRolResponse>(MenuRol);
            return result;
        }

        public List<MenuRolResponse> UpdateMultiple(List<MenuRolRequest> lista)
        {
            List<MenuRol> MenuRols = _mapper.Map<List<MenuRol>>(lista);
            MenuRols = _MenuRolRepository.UpdateMultiple(MenuRols);
            List<MenuRolResponse> result = _mapper.Map<List<MenuRolResponse>>(MenuRols);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _MenuRolRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<MenuRolRequest> lista)
        {
            List<MenuRol> MenuRols = _mapper.Map<List<MenuRol>>(lista);
            int cantidad = _MenuRolRepository.DeleteMultipleItems(MenuRols);
            return cantidad;
        }

        public GenericFilterResponse<MenuRolResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<MenuRolResponse> result = _mapper.Map<GenericFilterResponse<MenuRolResponse>>(_MenuRolRepository.GetByFilter(request));

            return result;
        }

        public List<MenuRolResponse> CreateMultiple(List<MenuRolRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
