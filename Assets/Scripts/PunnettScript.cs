using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PunnettScript : MonoBehaviour
{
    private int cantAlelos;
    //private Tupla auxiliarTupla;
    private List<String> combinaciones;
    private List<Tupla> PadreCaracteristicas = new();
    private List<Tupla> Padre = new();
    private List<Tupla> Madre = new();
    private List<Tupla> Hijos = new();
    private BinaryConverter conversor;

    private void Start() {
        /*Ejemplo
        Tupla car1 = new();
        car1.SetDominante('A');
        car1.SetRecesivo('a');
        
        Tupla car2 = new();
        car2.SetDominante('B');
        car2.SetRecesivo('b');

        Tupla car3 = new();
        car3.SetDominante('C');
        car3.SetRecesivo('c');

        Tupla car4 = new();
        car4.SetDominante('D');
        car4.SetRecesivo('d');

        Tupla car5 = new();
        car5.SetDominante('E');
        car5.SetRecesivo('e');

        Tupla car6 = new();
        car6.SetDominante('F');
        car6.SetRecesivo('f');

        Tupla car7 = new();
        car7.SetDominante('G');
        car7.SetRecesivo('g');

        Tupla car8 = new();
        car8.SetDominante('H');
        car8.SetRecesivo('h');


        PadreCaracteristicas.Add(car1);
        PadreCaracteristicas.Add(car2);
        PadreCaracteristicas.Add(car3);
        PadreCaracteristicas.Add(car4);
        PadreCaracteristicas.Add(car5);
        PadreCaracteristicas.Add(car6);
        PadreCaracteristicas.Add(car7);
        PadreCaracteristicas.Add(car8);
        */
        
        
    }

    public void PreCombinar(int n) {
        conversor = new();
        cantAlelos = n;
        combinaciones = conversor.GetCombinaciones(n);

        //imprimir combinaciones
        for (int i = 0; i < combinaciones.Count; i++){
            Debug.Log(combinaciones[i]);
        }
        //Combinar();
    }
    public void Combinar() {
        CrearCombinacionesT(Padre, combinaciones);
        //CrearCombinacionesT(Madre, combinaciones);

        //imprimir combinaciones traducidas
        for (int j = 0; j < Padre.Count; j++)
        {
            Padre[j].SelfPrint();
        }
    }
    public void AddPadre(Tupla Alelo) {
        Padre.Add(Alelo);
    }
    public void AddMadre(Tupla Alelo){
        Madre.Add(Alelo);
    }
    private void Cruzar(){
        for (int i = 0; i < Padre.Count; i++) {
            for (int j = 0; j < Madre.Count; j++) { 

            }
        }
    }
    private void CrearCombinacionesT(List<Tupla> progenitor, List<String> combinaciones){
        //Recorre el arreglo de binarios 
        for (int i = 0; i < combinaciones.Count; i++) {
            String comb = combinaciones.ElementAt(i);
            Tupla aux = new();
            aux.setSize(cantAlelos);
            
            //Recorre el número binario (String), toma los valores 1 a 1 y los reemplaza en tuplas nuevas
            for (int j = cantAlelos - 1; j >= 0; j--) {
                if (comb[j].Equals('0')) aux.SetAlelo(j, PadreCaracteristicas[j].GetRecesivo());
                else aux.SetAlelo(j, PadreCaracteristicas[j].GetDominante());
            }
            progenitor.Add(aux);
        }
    }
}