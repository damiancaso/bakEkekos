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
    public class PersonaGeneroRepository : CrudRepository<PersonaGenero>, IPersonaGeneroRepository
    {
        public GenericFilterResponse<PersonaGenero> GetByFilter(GenericFilterRequest request)
        {
            var query = dbSet.Where(x => x.IdGenero == x.IdGenero);
            request.Filtros.ForEach(j =>
            {
                if (!string.IsNullOrEmpty(j.Value))
                {
                    switch (j.Name)
                    {
                        case "id":
                            query = query.Where(x => x.IdGenero == short.Parse(j.Value));
                            break;
                        case "nombre":
                            query = query.Where(x => x.Nombre.ToLower().Contains(j.Value.ToLower()));
                            break;

                    }
                }
            });

            GenericFilterResponse<PersonaGenero> res = new GenericFilterResponse<PersonaGenero>();

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
