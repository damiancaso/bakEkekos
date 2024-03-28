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
    public class MenuBussnies : IMenuBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IMenuRepository _MenuRepository;
        private readonly IMapper _mapper;
        public MenuBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _MenuRepository = new MenuRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<MenuResponse> GetAll()
        {
            //declarando la lista de Menu response como resultado
            List<MenuResponse> lstResponse = new List<MenuResponse>();
            List<Menu> Menus = _MenuRepository.GetAll();

            lstResponse = _mapper.Map<List<MenuResponse>>(Menus);
            return lstResponse;
        }

        public MenuResponse GetById(int Id)
        {
            Menu Menu = _MenuRepository.GetById(Id);
            MenuResponse resul = _mapper.Map<MenuResponse>(Menu);
            return resul;
        }

        public MenuResponse Create(MenuRequest entity)
        {
            Menu Menu = _mapper.Map<Menu>(entity);
            Menu = _MenuRepository.Create(Menu);
            MenuResponse result = _mapper.Map<MenuResponse>(Menu);
            return result;
        }
        public List<MenuResponse> InsertMultiple(List<MenuRequest> lista)
        {
            List<Menu> Menus = _mapper.Map<List<Menu>>(lista);
            Menus = _MenuRepository.CreateMultiple(Menus);
            List<MenuResponse> result = _mapper.Map<List<MenuResponse>>(Menus);
            return result;
        }

        public MenuResponse Update(MenuRequest entity)
        {
            Menu Menu = _mapper.Map<Menu>(entity);
            Menu = _MenuRepository.Update(Menu);
            MenuResponse result = _mapper.Map<MenuResponse>(Menu);
            return result;
        }

        public List<MenuResponse> UpdateMultiple(List<MenuRequest> lista)
        {
            List<Menu> Menus = _mapper.Map<List<Menu>>(lista);
            Menus = _MenuRepository.UpdateMultiple(Menus);
            List<MenuResponse> result = _mapper.Map<List<MenuResponse>>(Menus);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _MenuRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<MenuRequest> lista)
        {
            List<Menu> Menus = _mapper.Map<List<Menu>>(lista);
            int cantidad = _MenuRepository.DeleteMultipleItems(Menus);
            return cantidad;
        }

        public GenericFilterResponse<MenuResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<MenuResponse> result = _mapper.Map<GenericFilterResponse<MenuResponse>>(_MenuRepository.GetByFilter(request));

            return result;
        }

        public List<MenuResponse> CreateMultiple(List<MenuRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
