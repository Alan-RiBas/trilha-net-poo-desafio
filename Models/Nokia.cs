using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_desafio.Models
{
  public class Nokia : Smartphone
  {

        //fazer encapsulamento
        private string _numero;
        private string _modelo;
        private string _imei;
        private int _memoria;

    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

    // TODO: Sobrescrever o método "InstalarAplicativo"
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando {nomeApp} no Nokia...");
    }
  }
}