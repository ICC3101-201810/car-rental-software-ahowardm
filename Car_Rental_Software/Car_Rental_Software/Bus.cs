using System;

namespace Car_Rental_Software{
  class Bus : Vehiculo{
    String tipo_bus;

    public Bus(String marca, String modelo, String tipo_bus) : base(marca, modelo, "bus", 100000){
      this.tipo_bus = tipo_bus;
    }
  }
}