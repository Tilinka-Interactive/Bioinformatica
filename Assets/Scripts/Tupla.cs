using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Tupla
{
    public char dominante;
    public char recesivo;
    public int size;
    public char[] alelos;
    public void setSize(int n) {
        size = n;
        alelos = new char[n];
    }
    public void SetAlelo(int pos, char alelo){
        alelos[pos] = alelo;
    }
    public char GetAlelo(int pos){
        if (pos < alelos.Length) return alelos[pos];
        else return ' ';
    }
    public void ClearList() {
        Array.Clear(alelos, 0, size);
    }
    public char GetRecesivo() {
        return recesivo;
    }
    public char GetDominante(){
        return dominante;
    }

    public void SetRecesivo(char recesivo){
        this.recesivo = recesivo; ;
    }

    public void SetDominante(char dominante){
        this.dominante = dominante; 
    }

    public void SelfPrint() {
        String printr = "";
        for (int i = 0; i < alelos.Length; i++) {
            printr += alelos[i];
        }
        Debug.Log(printr);
    }
    public string GetStringTupla()
    {
        String printr = "";
        for (int i = 0; i < alelos.Length; i++)
        {
            printr += alelos[i];
        }
        return printr;
    }
}
