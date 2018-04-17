using System;

namespace Car_Rental_Software{
  class Persona : Cliente{
    public String nombre { get; set; }
    public String apellido { get; set; }

    public Persona(String rut, String nombre, String apellido) : base(rut){
      this.nombre = nombre;
      this.apellido = apellido;
    }
  }
}