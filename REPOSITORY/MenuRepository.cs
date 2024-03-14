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
    public class MenuRepository : CrudRepository<Menu>, IMenuRepository
    {
        public GenericFilterResponse<Menu> GetByFilter(GenericFilterRequest request)
        {
            var query = dbSet.Where(x => x.IdMenu == x.IdMenu);
            request.Filtros.ForEach(j =>
            {
                if (!string.IsNullOrEmpty(j.Value))
                {
                    switch (j.Name)
                    {
                        case "id":
                            query = query.Where(x => x.IdMenu == short.Parse(j.Value));
                            break;
                        case "nombre":
                            query = query.Where(x => x.Nombre.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "descripcion":
                            query = query.Where(x => x.Descripcion.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "icono":
                            query = query.Where(x => x.Icono.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "dato":
                            query = query.Where(x => x.Datatarget.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "url":
                            query = query.Where(x => x.Url.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "padre":
                            query = query.Where(x => x.Padre == int.Parse(j.Value));
                            break;
                        case "estado":
                            query = query.Where(x => x.IdEstado == bool.Parse(j.Value));
                            break;
                        case "usuariocrea":
                            query = query.Where(x => x.UsuarioCrea.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "usuarioactua":
                            query = query.Where(x => x.UsuarioActualiza.ToLower().Contains(j.Value.ToLower()));
                            break;

                            

                    }
                }
            });

            GenericFilterResponse<Menu> res = new GenericFilterResponse<Menu>();

            res.TotalRegistros = query.Count();
            res.Lista = query
                //.Include(x => x.Status)
                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .OrderBy(x => x.Nombre)
                .ToList();

            return res;
        }
    }
}
