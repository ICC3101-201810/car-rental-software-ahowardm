using System;

namespace Car_Rental_Software{
  class Arriendo{
    Vehiculo vehiculo;
    Cliente cliente;
    Accesorio accesorio;

    public Arriendo(Vehiculo vehiculo, Cliente cliente, Accesorio accesorio){
      this.vehiculo = vehiculo;
      this.cliente = cliente;
      this.accesorio = accesorio;
    }
  }
}