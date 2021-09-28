﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Entities;

namespace Practica_EF_Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        public void Delete(int id)
        {
            var shiper_delete = context.Shippers.Find(id);
            context.Shippers.Remove(shiper_delete);
            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                throw new DbUpdateException();
            }
            catch (NotSupportedException)
            {
                throw new NotSupportedException();
            }
            catch (ObjectDisposedException)
            {
                throw new ObjectDisposedException("Id: shipper_delete");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();

            }
        }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void GetById(string id)
        {
            throw new NotImplementedException();
        }

        public string Update(Shippers c)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            var ship = context.Customers.Find(id);
        }

        public void Insert(Shippers newShiper)
        {
            context.Shippers.Add(newShiper);
            try
            {
                context.SaveChanges();
            }
            catch (NotSupportedException)
            {
                throw new NotSupportedException();
            }
            catch (ObjectDisposedException)
            {
                throw new ObjectDisposedException("Id: shipper_delete");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();

            }

        }

    }
}
