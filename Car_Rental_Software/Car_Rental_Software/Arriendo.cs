using System;

namespace Car_Rental_Software{
  class Arriendo{
    Vehiculo vehiculo;
    Cliente cliente;

    public Arriendo(Vehiculo vehiculo, Cliente cliente){
      this.vehiculo = vehiculo;
      this.cliente = cliente;
    }
  }
}