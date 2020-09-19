

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RegistroCompleto.Entidades
{
    public class Persona
   {
     [Key]
     public int Id { get; set; }
      public string Nombres { get; set; }
     public string Telefono{ get; set; }

     public string Cedula{get; set;}

     public string Direccion{get; set;}

     public string FechaNacimiento{get; set;} 
    }

}