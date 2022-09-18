using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunnettScript : MonoBehaviour
{
    private int cantAlelos;
    private List<Tupla> Padre = new List<Tupla>();
    private List<Tupla> CombinacionesPadre = new List<Tupla>();
    private List<Tupla> Madre = new List<Tupla>();
    private List<Tupla> CombinacionesMadre = new List<Tupla>();
    private List<Tupla> Hijos = new List<Tupla>();

    private void Start(){
        
        BinaryConverter conversor = new();
        conversor.Start();
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
    private void CrearCombinaciones(List<Tupla> Padre){

    }
}