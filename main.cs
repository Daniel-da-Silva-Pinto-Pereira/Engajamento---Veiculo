using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    string continuar="S", marca;
    double consumo;
    Carro aut = new Carro("TESTE", 0);
    List<Carro> listaCarros = new List<Carro>();

    while (continuar=="S"){
      Console.WriteLine("MARCA DO CARRO >>");
      marca = Console.ReadLine();
      Console.WriteLine("KM/L DO CARRO >>");
      consumo = double.Parse(Console.ReadLine());
      aut = new Carro(marca, consumo);
      listaCarros.Add(aut);
      Console.WriteLine("CONTINUAR? S/N");
      continuar = Console.ReadLine();
    }

    Carro menor_consumo = listaCarros[0];

    for(int i=1;i<listaCarros.Count;i++){
      if(listaCarros[i].getConsumo() > menor_consumo.getConsumo())
        menor_consumo = listaCarros[i];
    }
    Console.WriteLine("Marca de Menor Consumo: {0} \n Consumo D: {1} KM/L", menor_consumo.getMarca(), menor_consumo.getConsumo());

    for(int i=0;i<listaCarros.Count;i++){
      Console.WriteLine("-------------{0}------------", listaCarros[i].getMarca());
      Console.WriteLine("Litros Gastos em 1000 KM: {0}", 1000/listaCarros[i].getConsumo());
      Console.WriteLine("Valor Gasto ao Percorrer 1000 KM {0}", (1000/listaCarros[i].getConsumo())*4.89);    
    }

  }
}