using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootcamp20.Micro.DataAccess.Models;
using Bootcamp20.Micro.DataAccess.Param;

namespace Bootcamp20.Micro.Common.Interfaces
{
    public interface ISupplierService
    {
        List<Supplier> Get();
        Supplier Get(int? id);
        bool Insert(SupplierParam supplierParam);
        bool Update(SupplierParam supplierParam);
        bool Delete(int? id);
    }
}
