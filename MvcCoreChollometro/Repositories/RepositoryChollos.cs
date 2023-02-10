using MvcCoreChollometro.Data;
using MvcCoreChollometro.Models;

namespace MvcCoreChollometro.Repositories
{
    public class RepositoryChollos
    {
        public ChollosContext context;
        public RepositoryChollos(ChollosContext context)
        {
            this.context = context;
        }
        public List<Chollos> GetChollos()
        {
            var consulta = from datos in this.context.Chollos
                           orderby datos.Fecha descending
                           select datos;
            return consulta.ToList();
        }
    }
}
