using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class BinaryConverter
{
   
    private int caracteristicas;
    public void Start()
    {
        caracteristicas = 8;
        List<String>combinaciones = new List<String>();
        for (int i = 0; i < (int)(Math.Pow(2, caracteristicas)); i++)
        {
            combinaciones.Add(Converter(i));
        }
        for (int j = 0; j < combinaciones.Count; j++) { 
            Debug.Log(combinaciones.ElementAt(j));
        }
    }
    public String Converter(int n)
    {
        int remainder;
        string binary = string.Empty;
        while (n > 0)
        {
            remainder = n % 2;
            n /= 2;
            binary = remainder.ToString() + binary;
        }
        Debug.Log(binary);
        return binary;
    }
}
