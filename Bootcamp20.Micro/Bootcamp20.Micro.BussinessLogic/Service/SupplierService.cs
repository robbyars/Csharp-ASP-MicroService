using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootcamp20.Micro.BussinessLogic.Repository;
using Bootcamp20.Micro.Common.Interfaces;
using Bootcamp20.Micro.Common.Interfaces.Application;
using Bootcamp20.Micro.DataAccess.Context;
using Bootcamp20.Micro.DataAccess.Models;
using Bootcamp20.Micro.DataAccess.Param;

namespace Bootcamp20.Micro.BussinessLogic.Service
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService() { }
        public SupplierService(ISupplierRepository supplierRepository)
        {
            this._supplierRepository = supplierRepository;
        }
        public bool Delete(int? id)
        {
            return _supplierRepository.Delete(id);
        }

        public List<Supplier> Get()
        {
            return _supplierRepository.Get();
        }

        public Supplier Get(int? id)
        {
            return _supplierRepository.Get(id);
        }

        public bool Insert(SupplierParam supplierParam)
        {
            return _supplierRepository.Insert(supplierParam);
            
        }

        public bool Update(SupplierParam supplierParam)
        {
            return _supplierRepository.Update(supplierParam);
            
        }
        
    }
}
