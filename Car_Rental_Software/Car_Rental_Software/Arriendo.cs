using System;

namespace Car_Rental_Software{
  class Arriendo{
    Vehiculo vehiculo;
    Cliente cliente;
    Accesorio accesorio;
    int precio;

    public Arriendo(Vehiculo vehiculo, Cliente cliente, Accesorio accesorio, int precio){
      this.vehiculo = vehiculo;
      this.cliente = cliente;
      this.accesorio = accesorio;
      this.precio = precio;
    }
  }
}