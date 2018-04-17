using System;

namespace Car_Rental_Software{
  class Camion : Vehiculo{

    public Camion(String marca, String modelo) : base(marca, modelo, "camion", 125000){
      
    }
  }
}