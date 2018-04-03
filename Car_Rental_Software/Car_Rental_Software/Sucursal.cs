using System;
using System.Collections.Generic;

namespace Car_Rental_Software
{
  class Sucursal
  {
    List<Vehiculo> vehiculos;
    List<Accesorio> accesorios;
    List<Cliente> clientes;

    public Sucursal(List<Vehiculo> vehiculos, List<Cliente> clientes, List<Accesorio> accesorios){
      this.vehiculos = vehiculos;
      this.clientes = clientes;
      this.accesorios = accesorios;
    }


    /***************************************
    * Agrega cliente, vehiculo y accesorio *
    ****************************************/
    public Boolean AgregarCliente(Cliente cliente){
      clientes.Add(cliente);
      return true;
    }

    public Boolean AgregarVehiculo(Vehiculo vehiculo){
      vehiculos.Add(vehiculo);
      return true;
    }

    public Boolean AgregarAccesorio(Accesorio accesorio){
      accesorios.Add(accesorio);
      return true;
    }
  }
}