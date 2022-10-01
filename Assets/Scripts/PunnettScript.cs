using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class PunnettScript : MonoBehaviour{
    private int cantAlelos;
    //private Tupla auxiliarTupla;
    private List<String> combinaciones;
    private List<Tupla> PadreCaracteristicas = new();
    private List<Tupla> TuplasGeneradas = new();
    //private List<Tupla> Padre = new();
    private List<Tupla> Hijos = new();
    private BinaryConverter conversor;
    [SerializeField] private GameObject ShowSon;
    [SerializeField] private GameObject ParentSons;

    private void Start() {

    }

    public void PreCombinar(int n) {
        conversor = new();
        cantAlelos = n;
        combinaciones = conversor.GetCombinaciones(n);

        //imprimir combinaciones
        for (int i = 0; i < combinaciones.Count; i++){
            Debug.Log(combinaciones[i]);
        }
    }
    public void Combinar() {
        CrearCombinacionesT(TuplasGeneradas, combinaciones);

        //imprimir combinaciones traducidas
        for (int j = 0; j < TuplasGeneradas.Count; j++){
            GameObject Son = Instantiate(ShowSon) as GameObject;
            Son.transform.SetParent(ParentSons.transform);
            Son.GetComponentInChildren<TextMeshProUGUI>().text = TuplasGeneradas[j].GetStringTupla();
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
                if (comb[j].Equals('0')) aux.SetAlelo(j, PadreCaracteristicas[j].GetDominante());
                else aux.SetAlelo(j, PadreCaracteristicas[j].GetRecesivo());
            }
            progenitor.Add(aux);
        }
    }
    public void AddTuplaPadre(char dominante, char recesivo) {
        Tupla auxTupla = new Tupla();
        auxTupla.SetDominante(dominante);
        auxTupla.SetRecesivo(recesivo);
        PadreCaracteristicas.Add(auxTupla);
    }
    public void ChangeTupla(int id, char c1, char c2){
        PadreCaracteristicas[id].SetDominante(c1);
        PadreCaracteristicas[id].SetRecesivo(c2);
        //Debug.Log(PadreCaracteristicas[id].GetDominante());
        //Debug.Log(PadreCaracteristicas[id].GetRecesivo());
    }
}