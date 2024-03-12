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
    public class UsuarioBussnies : IUsuarioBussnies
    {
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IUsuarioRepository _UsuarioRepository;
        private readonly IMapper _mapper;
        public UsuarioBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _UsuarioRepository = new UsuarioRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<UsuarioResponse> GetAll()
        {
            List<UsuarioResponse> lstResponse = new List<UsuarioResponse>();
            List<Usuario> Usuario = _UsuarioRepository.GetAll();

            lstResponse = _mapper.Map<List<UsuarioResponse>>(Usuario);
            return lstResponse;
        }
        public UsuarioResponse Create(UsuarioRequest entity)
        {
            Usuario Usuario = _mapper.Map<Usuario>(entity);
            Usuario = _UsuarioRepository.Create(Usuario);
            UsuarioResponse result = _mapper.Map<UsuarioResponse>(Usuario);
            return result;
        }

        public UsuarioResponse BuscarPorNombreUsuario(string username)
        {
            UsuarioResponse usuario = _mapper.Map<UsuarioResponse>(_UsuarioRepository.obtenerPorUsername(username));
            return usuario;
        }

        public VwUsuario ObtenerVistaUsername(string username)
        {
            VwUsuario usuario = _UsuarioRepository.obtenerVistaUsuario(username);
            return usuario;
        }

        public UsuarioResponse GetById(int id)
        {
            Usuario usuario = _UsuarioRepository.GetById(id);
            UsuarioResponse resul = _mapper.Map<UsuarioResponse>(usuario);
            return resul;
        }

        public UsuarioResponse Update(UsuarioRequest entity)
        {
            Usuario usuario = _mapper.Map<Usuario>(entity);
            usuario = _UsuarioRepository.Update(usuario);
            UsuarioResponse result = _mapper.Map<UsuarioResponse>(usuario);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _UsuarioRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<UsuarioRequest> lista)
        {
            List<Usuario> usuario = _mapper.Map<List<Usuario>>(lista);
            int cantidad = _UsuarioRepository.DeleteMultipleItems(usuario);
            return cantidad;
        }

        public List<UsuarioResponse> InsertMultiple(List<UsuarioRequest> lista)
        {
            List<Usuario> usuario = _mapper.Map<List<Usuario>>(lista);
            usuario = _UsuarioRepository.CreateMultiple(usuario);
            List<UsuarioResponse> resul = _mapper.Map<List<UsuarioResponse>>(usuario);

            return resul;
        }

        public List<UsuarioResponse> CreateMultiple(List<UsuarioRequest> lista)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioResponse> UpdateMultiple(List<UsuarioRequest> lista)
        {
            List<Usuario> Usuarios = _mapper.Map<List<Usuario>>(lista);
            Usuarios = _UsuarioRepository.UpdateMultiple(Usuarios);
            List<UsuarioResponse> result = _mapper.Map<List<UsuarioResponse>>(Usuarios);
            return result;
        }

        public GenericFilterResponse<UsuarioResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<UsuarioResponse> result = _mapper.Map<GenericFilterResponse<UsuarioResponse>>(_UsuarioRepository.GetByFilter(request));

            return result;
        }
        #endregion
    }
}
