using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Tupla : MonoBehaviour
{
    public Image sprite;
    public int size;
    public char[] alelos;
    private void Start(){
        alelos = new char[size];
    }
    public char GetAlelo(int pos){
        if (pos < alelos.Length) return alelos[pos];
        else return ' ';
    }
}
