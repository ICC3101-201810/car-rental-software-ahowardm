using System;

namespace Car_Rental_Software{
  class Arriendo{
    Vehiculo vehiculo;
    Cliente cliente;
    Accesorio accesorio;
    int precio;
    DateTime arriendo, devolucion;

    public Arriendo(Vehiculo vehiculo, Cliente cliente, Accesorio accesorio, DateTime arriendo, int devolucion){
      this.vehiculo = vehiculo;
      this.cliente = cliente;
      this.accesorio = accesorio;
      precio = vehiculo.precio * devolucion;
      this.arriendo = arriendo;
      this.devolucion = arriendo.AddDays(devolucion);
    }
  }
}