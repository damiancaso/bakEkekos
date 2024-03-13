using EKEKOSDATABASEMODEL;
using IREPOSITORY;
using REQUESTRESPONSEMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY
{
    public class RolRepository : CrudRepository<Rol>, IRolRepository
    {
        public GenericFilterResponse<Rol> GetByFilter(GenericFilterRequest request)
        {
            {
                var query = dbSet.Where(x => x.IdRol == x.IdRol);
                request.Filtros.ForEach(j =>
                {
                    if (!string.IsNullOrEmpty(j.Value))
                    {
                        switch (j.Name)
                        {
                            case "id":
                                query = query.Where(x => x.IdRol == short.Parse(j.Value));
                                break;
                            case "descripcion":
                                query = query.Where(x => x.Descripcion.ToLower().Contains(j.Value.ToLower()));
                                break;
                            case "funcion":
                                query = query.Where(x => x.Funcion.ToLower().Contains(j.Value.ToLower()));
                                break;
                            case "idEstado":
                                query = query.Where(x => x.IdEstado == bool.Parse(j.Value));
                                break;
                        }
                    }
                });

                GenericFilterResponse<Rol> res = new GenericFilterResponse<Rol>();

                res.TotalRegistros = query.Count();
                res.Lista = query
                    //.Include(x => x.Status)
                    .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                    .OrderBy(x => x.Descripcion)
                    .ToList();

                return res;
            }
        }
    }
}
