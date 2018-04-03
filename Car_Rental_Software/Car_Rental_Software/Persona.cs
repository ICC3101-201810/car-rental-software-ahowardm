using System;

namespace Car_Rental_Software{
  class Persona : Cliente{
    String nombre;
    String apellido;

    public Persona(Boolean licencia_valida, String rut, String nombre, String apellido) : base(licencia_valida, rut){
      this.nombre = nombre;
      this.apellido = apellido;
    }
  }
}