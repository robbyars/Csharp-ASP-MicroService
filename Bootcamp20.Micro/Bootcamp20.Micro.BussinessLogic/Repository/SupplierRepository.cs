using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootcamp20.Micro.Core;
using Bootcamp20.Micro.Common.Interfaces.Application;
using Bootcamp20.Micro.DataAccess.Context;
using Bootcamp20.Micro.DataAccess.Models;
using Bootcamp20.Micro.DataAccess.Param;
using System.Data.Entity;

namespace Bootcamp20.Micro.BussinessLogic.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        BaseContext _context = new BaseContext();
        bool status = false;
        public bool Delete(int? id)
        {
            var getSupplier = Get(id);
            getSupplier.Delete();
            _context.Entry(getSupplier).State = EntityState.Modified;
            var result = _context.SaveChanges();
            if(result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Supplier> Get()
        {
            return _context.Suppliers.Where(x => x.IsDelete.Equals(false)).ToList();
        }

        public Supplier Get(int? id)
        {
            if(id == null)
            {
                Console.Write("id is null");
            }
            Supplier supplier = _context.Suppliers.SingleOrDefault(x => x.Id == id);
            if(supplier == null)
            {
                Console.Write("Supplier Has not Value");
            }
            return supplier;
        }

        public bool Insert(SupplierParam supplierParam)
        {
            var push = new Supplier(supplierParam);
            _context.Suppliers.Add(push);
            var result = _context.SaveChanges();
            if(result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(SupplierParam supplierParam)
        {
            var getSupplier = Get(supplierParam.Id);
            getSupplier.Update(supplierParam);
            _context.Entry(getSupplier).State = EntityState.Modified;
            var result = _context.SaveChanges();
            if(result > 0)
            {
                status = true;
            }
            return status;
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            this.Dispose(disposing);
        }
    }
}
