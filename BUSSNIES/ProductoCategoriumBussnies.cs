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
    public class ProductoCategoriumBussnies : IProductoCategoriumBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IProductoCategoriumRepository _ProductoCategoriumRepository;
        private readonly IMapper _mapper;
        public ProductoCategoriumBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _ProductoCategoriumRepository = new ProductoCategoriumRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<ProductoCategoriumResponse> GetAll()
        {
            //declarando la lista de ProductoCategorium response como resultado
            List<ProductoCategoriumResponse> lstResponse = new List<ProductoCategoriumResponse>();
            List<ProductoCategorium> ProductoCategoriums = _ProductoCategoriumRepository.GetAll();

            lstResponse = _mapper.Map<List<ProductoCategoriumResponse>>(ProductoCategoriums);
            return lstResponse;
        }

        public ProductoCategoriumResponse GetById(int Id)
        {
            ProductoCategorium ProductoCategorium = _ProductoCategoriumRepository.GetById(Id);
            ProductoCategoriumResponse resul = _mapper.Map<ProductoCategoriumResponse>(ProductoCategorium);
            return resul;
        }

        public ProductoCategoriumResponse Create(ProductoCategoriumRequest entity)
        {
            ProductoCategorium ProductoCategorium = _mapper.Map<ProductoCategorium>(entity);
            ProductoCategorium = _ProductoCategoriumRepository.Create(ProductoCategorium);
            ProductoCategoriumResponse result = _mapper.Map<ProductoCategoriumResponse>(ProductoCategorium);
            return result;
        }
        public List<ProductoCategoriumResponse> InsertMultiple(List<ProductoCategoriumRequest> lista)
        {
            List<ProductoCategorium> ProductoCategoriums = _mapper.Map<List<ProductoCategorium>>(lista);
            ProductoCategoriums = _ProductoCategoriumRepository.CreateMultiple(ProductoCategoriums);
            List<ProductoCategoriumResponse> result = _mapper.Map<List<ProductoCategoriumResponse>>(ProductoCategoriums);
            return result;
        }

        public ProductoCategoriumResponse Update(ProductoCategoriumRequest entity)
        {
            ProductoCategorium ProductoCategorium = _mapper.Map<ProductoCategorium>(entity);
            ProductoCategorium = _ProductoCategoriumRepository.Update(ProductoCategorium);
            ProductoCategoriumResponse result = _mapper.Map<ProductoCategoriumResponse>(ProductoCategorium);
            return result;
        }

        public List<ProductoCategoriumResponse> UpdateMultiple(List<ProductoCategoriumRequest> lista)
        {
            List<ProductoCategorium> ProductoCategoriums = _mapper.Map<List<ProductoCategorium>>(lista);
            ProductoCategoriums = _ProductoCategoriumRepository.UpdateMultiple(ProductoCategoriums);
            List<ProductoCategoriumResponse> result = _mapper.Map<List<ProductoCategoriumResponse>>(ProductoCategoriums);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _ProductoCategoriumRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<ProductoCategoriumRequest> lista)
        {
            List<ProductoCategorium> ProductoCategoriums = _mapper.Map<List<ProductoCategorium>>(lista);
            int cantidad = _ProductoCategoriumRepository.DeleteMultipleItems(ProductoCategoriums);
            return cantidad;
        }

        public GenericFilterResponse<ProductoCategoriumResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<ProductoCategoriumResponse> result = _mapper.Map<GenericFilterResponse<ProductoCategoriumResponse>>(_ProductoCategoriumRepository.GetByFilter(request));

            return result;
        }

        public List<ProductoCategoriumResponse> CreateMultiple(List<ProductoCategoriumRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
