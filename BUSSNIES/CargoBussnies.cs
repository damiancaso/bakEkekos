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
    public class CargoBussnies : ICargoBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly ICargoRepository _CargoRepository;
        private readonly IMapper _mapper;
        public CargoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _CargoRepository = new CargoRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<CargoResponse> GetAll()
        {
            //declarando la lista de Cargo response como resultado
            List<CargoResponse> lstResponse = new List<CargoResponse>();
            List<Cargo> Cargos = _CargoRepository.GetAll();

            lstResponse = _mapper.Map<List<CargoResponse>>(Cargos);
            return lstResponse;
        }

        public CargoResponse GetById(int Id)
        {
            Cargo Cargo = _CargoRepository.GetById(Id);
            CargoResponse resul = _mapper.Map<CargoResponse>(Cargo);
            return resul;
        }

        public CargoResponse Create(CargoRequest entity)
        {
            Cargo Cargo = _mapper.Map<Cargo>(entity);
            Cargo = _CargoRepository.Create(Cargo);
            CargoResponse result = _mapper.Map<CargoResponse>(Cargo);
            return result;
        }
        public List<CargoResponse> InsertMultiple(List<CargoRequest> lista)
        {
            List<Cargo> Cargos = _mapper.Map<List<Cargo>>(lista);
            Cargos = _CargoRepository.CreateMultiple(Cargos);
            List<CargoResponse> result = _mapper.Map<List<CargoResponse>>(Cargos);
            return result;
        }

        public CargoResponse Update(CargoRequest entity)
        {
            Cargo Cargo = _mapper.Map<Cargo>(entity);
            Cargo = _CargoRepository.Update(Cargo);
            CargoResponse result = _mapper.Map<CargoResponse>(Cargo);
            return result;
        }

        public List<CargoResponse> UpdateMultiple(List<CargoRequest> lista)
        {
            List<Cargo> Cargos = _mapper.Map<List<Cargo>>(lista);
            Cargos = _CargoRepository.UpdateMultiple(Cargos);
            List<CargoResponse> result = _mapper.Map<List<CargoResponse>>(Cargos);
            return result;
        }

        public int Delete(int Id)
        {
            int cantidad = _CargoRepository.Delete(Id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<CargoRequest> lista)
        {
            List<Cargo> Cargos = _mapper.Map<List<Cargo>>(lista);
            int cantidad = _CargoRepository.DeleteMultipleItems(Cargos);
            return cantidad;
        }

        public GenericFilterResponse<CargoResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<CargoResponse> result = _mapper.Map<GenericFilterResponse<CargoResponse>>(_CargoRepository.GetByFilter(request));

            return result;
        }

        public List<CargoResponse> CreateMultiple(List<CargoRequest> lista)
        {
            throw new NotImplementedException();
        }

        #endregion END CRUD METHODS
    }
}
