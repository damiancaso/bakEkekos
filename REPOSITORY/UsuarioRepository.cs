using EKEKOSDATABASEMODEL;
using IREPOSITORY;
using Microsoft.EntityFrameworkCore;
using REQUESTRESPONSEMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY
{
    public class UsuarioRepository : CrudRepository<Usuario>, IUsuarioRepository
    {
        public Usuario obtenerPorUsername(string username)
        {
            Usuario Usuario = dbSet
                .Where(x => x.Username.ToLower() == username.ToLower())
                .FirstOrDefault();
            return Usuario;
        }

        public GenericFilterResponse<Usuario> GetByFilter(GenericFilterRequest request)
        {
            var query = dbSet.Where(x => x.IdUsuario == x.IdUsuario);
            request.Filtros.ForEach(j =>
            {
                if (!string.IsNullOrEmpty(j.Value))
                {
                    switch (j.Name)
                    {
                        case "Id":
                            query = query.Where(x => x.IdUsuario == short.Parse(j.Value));
                            break;
                        case "Username":
                            query = query.Where(x => x.Username.ToLower().Contains(j.Value));
                            break;
                        case "Email":
                            query = query.Where(x => x.Email.ToLower().Contains(j.Value.ToLower()));
                            break;
                        
                    }
                }
            }
            );
            GenericFilterResponse<Usuario> res = new GenericFilterResponse<Usuario>();

            res.TotalRegistros = query.Count();
            res.Lista = query
                //.Include(x => x.Status)
                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .OrderBy(x => x.Username)
                .ToList();

            return res;
        }

        public VwUsuario obtenerVistaUsuario(string username)
        {
            VwUsuario VwUsuario = db.VwUsuarios.Where(x => x.Username.ToLower() == username.ToLower()).FirstOrDefault();

            return VwUsuario;
        }      

    }
}