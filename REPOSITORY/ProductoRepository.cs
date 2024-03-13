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
    public class ProductoRepository : CrudRepository<Producto>, IProductoRepository
    {
        public GenericFilterResponse<Producto> GetByFilter(GenericFilterRequest request)
        {
            var query = dbSet.Where(x => x.IdProducto == x.IdProducto);
            request.Filtros.ForEach(j =>
            {
                if (!string.IsNullOrEmpty(j.Value))
                {
                    switch (j.Name)
                    {
                        case "id":
                            query = query.Where(x => x.IdProducto == short.Parse(j.Value));
                            break;
                        case "Nombre":
                            query = query.Where(x => x.Nombre.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "Descripcion":
                            query = query.Where(x => x.Descripcion.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "Stock":
                            query = query.Where(x => x.Stock.ToString().Contains(j.Value.ToString()));
                            break;
                        case "Precio":
                            query = query.Where(x => x.Precio.ToString().Contains(j.Value.ToString()));
                            break;

                    }
                }
            });

            GenericFilterResponse<Producto> res = new GenericFilterResponse<Producto>();

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
