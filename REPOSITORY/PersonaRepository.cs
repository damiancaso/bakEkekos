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
    public class PersonaRepository : CrudRepository<Persona>, IPersonaRepository
    {
        
        public Persona obtenerPorPersona(string username)
        {
            Persona Persona = dbSet
                .Where(x => x.Email.ToLower() == username.ToLower())
                .FirstOrDefault();
            return Persona;
        }

        public GenericFilterResponse<Persona> GetByFilter(GenericFilterRequest request)
        {
            var query = dbSet.Where(x => x.IdPersona == x.IdPersona);
            request.Filtros.ForEach(j =>
            {
                if (!string.IsNullOrEmpty(j.Value))
                {
                    switch (j.Name)
                    {
                        case "Id":
                            query = query.Where(x => x.IdPersona == short.Parse(j.Value));
                            break;
                        case "ApPaterno":
                            query = query.Where(x => x.ApPaterno.ToLower().Contains(j.Value));
                            break;
                        case "ApMaterno":
                            query = query.Where(x => x.ApMaterno.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "Dni":
                            query = query.Where(x => x.NroDocumento.ToLower().Contains(j.Value.ToLower()));
                            break;
                    }
                }
            }
            );
            GenericFilterResponse<Persona> res = new GenericFilterResponse<Persona>();

            res.TotalRegistros = query.Count();
            res.Lista = query
                //.Include(x => x.Status)
                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .OrderBy(x => x.ApPaterno)
                .ToList();

            return res;
        }

        public VwPersona obtenerVistaPersona(string username)
        {
            VwPersona VistaPersona = db.VwPersonas.Where(x => x.Email.ToLower() == username.ToLower()).FirstOrDefault();

            return VistaPersona;
        }        
    }
}
