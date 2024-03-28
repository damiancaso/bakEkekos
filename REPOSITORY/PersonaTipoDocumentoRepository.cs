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
    public class PersonaTipoDocumentoRepository : CrudRepository<PersonaTipoDocumento>, IPersonaTipoDocumentoRepository
    {
        public GenericFilterResponse<PersonaTipoDocumento> GetByFilter(GenericFilterRequest request)
        {
            var query = dbSet.Where(x => x.IdPersonTipoDocumento == x.IdPersonTipoDocumento);
            request.Filtros.ForEach(j =>
            {
                if (!string.IsNullOrEmpty(j.Value))
                {
                    switch (j.Name)
                    {
                        case "id":
                            query = query.Where(x => x.IdPersonTipoDocumento == short.Parse(j.Value));
                            break;
                        case "Descripcion":
                            query = query.Where(x => x.Descripcion.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "Estado":
                            query = query.Where(x => x.IdStado.ToString().Contains(j.Value.ToString()));
                            break;

                    }
                }
            });

            GenericFilterResponse<PersonaTipoDocumento> res = new GenericFilterResponse<PersonaTipoDocumento>();

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
