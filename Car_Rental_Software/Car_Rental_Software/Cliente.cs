using System;
using System.Collections.Generic;

namespace Car_Rental_Software
{
  abstract class Cliente
  {
    //Boolean puede_manejar;
    Dictionary<String, Boolean> permiso_manejar;
    String rut;

    public Cliente(String rut)
    {
      //this.puede_manejar = puede_manejar;
      this.rut = rut;
      permiso_manejar = new Dictionary<String, Boolean>();
      InicializarPermisoManejar();
    }

    public void InicializarPermisoManejar(){
      permiso_manejar.Add("auto", false);
      permiso_manejar.Add("moto", false);
      permiso_manejar.Add("acuatico", false);
      permiso_manejar.Add("bus", false);
      permiso_manejar.Add("camion", false);
      permiso_manejar.Add("camioneta", false);
      permiso_manejar.Add("retroexcavadora", false);
    }

    public Boolean IngresaPermiso(String tipo){
      permiso_manejar[tipo] = true;
      return true;
    }
  }
}