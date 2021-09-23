using Gestao_de_Vendedores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_de_Vendedores.Services
{
    public class DepartamentoService
    {
        private readonly Context _context;

        public DepartamentoService(Context context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            return _context.Departamentos.OrderBy(x => x.Nome).ToList();
        }
    }
}
