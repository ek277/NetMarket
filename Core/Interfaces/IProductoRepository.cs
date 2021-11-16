using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductoRepository
    {
        Task<Producto> GetProductoByIdAsync(int id); // Dentro de los <> se indica qué tipo de objeto queremos devolver
        Task<IReadOnlyList<Producto>> GetProductosAsync(); 


    }
}
