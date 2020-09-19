
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using RegistroCompleto.DAL;
using RegistroCompleto.Entidades;
using Microsoft.EntityFrameworkCore;


namespace RegistroCompleto.BLL
{
    public class PersonaBLL
    {
    
      public static bool Guardar(Persona persona)
        {
            if (!Existe(persona.Id))
            return Insertar(persona);

            else
                return Modificar(persona);
        }
        private static bool Insertar(Persona persona)
        {
            Contexto context = new Contexto();
            bool paso = false;

            try
            {
                context.Persona.Add(persona);
                paso= context.SaveChanges()> 0;
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                context.Dispose();

            }
            return paso;


        }
        private static bool Modificar(Persona persona)
        {
            
            Contexto context=new Contexto();
            bool paso = false;

            try
            {
                context.Entry(persona) .State = EntityState.Modified;
                paso=context.SaveChanges()>0;
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                context.Dispose();

            }
            return paso;

        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto context = new Contexto();

            try
            {
                var persona = context.Persona.Find(id);

                if (persona != null)
                {
                    context.Persona.Remove(persona);
                    paso=context.SaveChanges() >0;

                }
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                context.Dispose();
            }
            return paso;

        }
         public static Persona Buscar(int id)
        {
           Persona persona;
           Contexto context = new Contexto();
           

            try
            {
                 persona = context.Persona.Find(id);
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                context.Dispose();
            }
            return persona;

        }
         public static bool Existe(int id)
        {
            
            Contexto context = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado= context.Persona.Any(p => p.Id ==id);
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                context.Dispose();
            }
            return encontrado;

        }
        public static List<Persona> GetList(Expression<Func<Persona, bool>> criterio)
        {
            List<Persona> lista = new List<Persona>();
            Contexto context=new Contexto();

            try
            {
                lista=context.Persona.Where(criterio).ToList();
            }
            catch(Exception)
            {
                throw;

            }
            finally{
                context.Dispose();
            }
            return lista;

        }



    }

}