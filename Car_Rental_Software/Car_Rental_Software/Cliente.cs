using System;
using System.Collections.Generic;

namespace Car_Rental_Software
{
  abstract class Cliente
  {
    Boolean puede_manejar;
    String rut;

    public Cliente(Boolean puede_manejar, String rut)
    {
      this.puede_manejar = puede_manejar;
      this.rut = rut;
    }
  }
}