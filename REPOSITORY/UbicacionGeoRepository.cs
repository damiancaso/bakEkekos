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
    public class UbicacionGeoRepository : CrudRepository<UbicacionGeo>, IUbicacionGeoRepository
    {
        public GenericFilterResponse<UbicacionGeo> GetByFilter(GenericFilterRequest request)
        {
            var query = dbSet.Where(x => x.IdUbica == x.IdUbica);
            request.Filtros.ForEach(j =>
            {
                if (!string.IsNullOrEmpty(j.Value))
                {
                    switch (j.Name)
                    {
                        case "id":
                            query = query.Where(x => x.IdUbica == short.Parse(j.Value));
                            break;
                        case "Distrito":
                            query = query.Where(x => x.Distrito.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "Provincia":
                            query = query.Where(x => x.Provincia.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "Departamento":
                            query = query.Where(x => x.Departamento.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "Ubicacion":
                            query = query.Where(x => x.Ubicacion.ToString().Contains(j.Value.ToLower()));
                            break;
                        case "Direccion":
                            query = query.Where(x => x.Direccion.ToString().Contains(j.Value.ToLower()));
                            break;

                    }
                }
            });

            GenericFilterResponse<UbicacionGeo> res = new GenericFilterResponse<UbicacionGeo>();

            res.TotalRegistros = query.Count();
            res.Lista = query
                //.Include(x => x.Status)
                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .OrderBy(x => x.Distrito)
                .ToList();

            return res;
        }
    }
}
