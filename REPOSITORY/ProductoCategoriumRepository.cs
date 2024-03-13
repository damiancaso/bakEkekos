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
    public class ProductoCategoriumRepository : CrudRepository<ProductoCategorium>, IProductoCategoriumRepository
    {
        public GenericFilterResponse<ProductoCategorium> GetByFilter(GenericFilterRequest request)
        {
            var query = dbSet.Where(x => x.IdCategoria == x.IdCategoria);
            request.Filtros.ForEach(j =>
            {
                if (!string.IsNullOrEmpty(j.Value))
                {
                    switch (j.Name)
                    {
                        case "id":
                            query = query.Where(x => x.IdCategoria == short.Parse(j.Value));
                            break;
                        case "Descripcion":
                            query = query.Where(x => x.Nombre.ToLower().Contains(j.Value.ToLower()));
                            break;
                        
                    }
                }
            });

            GenericFilterResponse<ProductoCategorium> res = new GenericFilterResponse<ProductoCategorium>();

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
