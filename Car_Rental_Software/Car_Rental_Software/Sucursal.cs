using System;
using System.Collections.Generic;

namespace Car_Rental_Software
{
  class Sucursal
  {
    String nombre;
    List<Vehiculo> vehiculos;
    List<Accesorio> accesorios;
    List<Cliente> clientes;
    List<Arriendo> arriendos;

    public Sucursal(String nombre, List<Vehiculo> vehiculos, List<Cliente> clientes, List<Accesorio> accesorios){
      this.nombre = nombre;
      this.vehiculos = vehiculos;
      this.clientes = clientes;
      this.accesorios = accesorios;
      arriendos = new List<Arriendo>();
    }

    public Sucursal(String nombre){
      this.nombre = nombre;
      vehiculos = new List<Vehiculo>();
      accesorios = new List<Accesorio>();
      clientes = new List<Cliente>();
      arriendos = new List<Arriendo>();
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

    public Boolean Arrendar(Vehiculo vehiculo, Cliente cliente){
      if (cliente.PuedeManejar && vehiculo.Arrendar()){
        arriendos.Add(new Arriendo(vehiculo, cliente));
        return true;
      }
      return false;
    }

    //public Boolean Devolver(Vehiculo vehiculo, Cliente cliente){
    //  
    //}

    public override String ToString(){
      return nombre;
    }

    public void ImprimirVehiculos(){
      for (int i = 0; i < vehiculos.Count; i++){
        Console.WriteLine(i + ": " + vehiculos[i]);
      }
    }

    public List<Vehiculo> Vehiculos{
      get{
        return vehiculos;
      }
      set{
        vehiculos = value;
      }
    }
  }
}