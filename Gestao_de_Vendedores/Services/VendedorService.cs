using Gestao_de_Vendedores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_de_Vendedores.Services
{
    public class VendedorService
    {
        private readonly Context _context;
        public VendedorService(Context context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedores.ToList();
        }

        public void Insert(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
