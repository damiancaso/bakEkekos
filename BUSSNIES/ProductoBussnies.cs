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
    public class ProductoBussnies : IProductoBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IProductoRepository _ProductoRepository;
        private readonly IMapper _mapper;
        public ProductoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _ProductoRepository = new ProductoRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<ProductoResponse> GetAll()
        {
            //declarando la lista de Producto response como resultado
            List<ProductoResponse> lstResponse = new List<ProductoResponse>();
            List<Producto> Productos = _ProductoRepository.GetAll();

            lstResponse = _mapper.Map<List<ProductoResponse>>(Productos);
            return lstResponse;
        }

        public ProductoResponse GetById(int Id)
        {
            Producto Producto = _ProductoRepository.GetById(Id);
            ProductoResponse resul = _mapper.Map<ProductoResponse>(Producto);
            return resul;
        }

        public ProductoResponse Create(ProductoRequest entity)
        {
            Producto Producto = _mapper.Map<Producto>(entity);
            Producto = _ProductoRepository.Create(Producto);
            ProductoResponse result = _mapper.Map<ProductoResponse>(Producto);
            return result;
        }
        public List<ProductoResponse> InsertMultiple(List<ProductoRequest> lista)
        {
            List<Producto> Productos = _mapper.Map<List<Producto>>(lista);
            Productos = _ProductoRepository.CreateMultiple(Productos);
            List<ProductoResponse> result = _mapper.Map<List<ProductoResponse>>(Productos);
            return result;
        }

        public ProductoResponse Update(ProductoRequest entity)
        {
            Producto Producto = _mapper.Map<Producto>(entity);
            Producto = _ProductoRepository.Update(Producto);
            ProductoResponse result = _mapper.Map<ProductoResponse>(Producto);
            return result;
        }

        public List<ProductoResponse> UpdateMultiple(List<ProductoRequest> lista)
        {
            List<Producto> Productos = _mapper.Map<List<Producto>>(lista);
            Productos = _ProductoRepository.UpdateMultiple(Productos);
            List<ProductoResponse> result = _mapper.Map<List<ProductoResponse>>(Productos);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _ProductoRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<ProductoRequest> lista)
        {
            List<Producto> Productos = _mapper.Map<List<Producto>>(lista);
            int cantidad = _ProductoRepository.DeleteMultipleItems(Productos);
            return cantidad;
        }

        public GenericFilterResponse<ProductoResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<ProductoResponse> result = _mapper.Map<GenericFilterResponse<ProductoResponse>>(_ProductoRepository.GetByFilter(request));

            return result;
        }

        public List<ProductoResponse> CreateMultiple(List<ProductoRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
