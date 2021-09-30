﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Dto;
using Practica_EF_Entities;

namespace Practica_EF_Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public Customers cust { get; set; }

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customers Delete(Customers custom)
        {
            cust = context.Customers.Find(custom.CustomerID);
            context.Customers.Remove(cust);
            return cust;

            string message;
            try
            {
                context.SaveChanges();
            }
            catch (NotSupportedException)
            {
                throw new NotSupportedException("La accion no se puede realizar");
            }
            catch (ObjectDisposedException)
            {
                throw new ObjectDisposedException("El Clientes no existe en la Base de Datos");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();

            }
        }

        public Customers GetById(int obj)
        {
            throw new NotImplementedException();
        }

        public Customers GetById(String custom)
        {
            try
            {
                cust = (from c in context.Customers
                        where c.CustomerID.Equals(custom)
                        select c).Single();
                return cust;
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Ha ocurrido un error, no es posible mostrarle lo que esta buscando");
            }
            catch (System.InvalidOperationException)
            {
                throw new System.InvalidOperationException("Lo que busca no se encuentra disponible");
            }
        }
        

        public string Insert(Customers newCustom)
        {
            context.Customers.Add(newCustom);
            try
            {
                context.SaveChanges();
                return "OK";
            }
            catch (NotSupportedException)
            {
                throw new NotSupportedException("Error al insertar");
            }
            catch (ObjectDisposedException)
            {
                throw new ObjectDisposedException("El Cliente no se puede insertar");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("El cliente no esta disponible para Insertar");

            }
        }

        public string Update(Customers custom)
        {
          
          context.Entry(custom).State = EntityState.Modified;

          try
          {
              context.SaveChanges();
              return "OK";
          }
          catch (ObjectDisposedException)
          {
              throw new ObjectDisposedException("El cliente no esta disponible en los datos");
          }
          catch (InvalidOperationException)
          {
              throw new InvalidOperationException("No se encuentra disponible el ciente para realizarle cambios");

          }

            
        }

    }
}
