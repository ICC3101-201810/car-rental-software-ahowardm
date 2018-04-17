using System;

namespace Car_Rental_Software{
  class Auto : Vehiculo{

    public Auto(String marca, String modelo) : base(marca, modelo, "auto", 25000){
      
    }
  }
}