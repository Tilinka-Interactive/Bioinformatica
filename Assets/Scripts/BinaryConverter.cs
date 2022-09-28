using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class BinaryConverter
{
    private int caracteristicas;
    public List<String> GetCombinaciones(int n)
    {
        List<String> combinaciones = new();
        
        caracteristicas = n;
        int pow = (int)(Math.Pow(2, caracteristicas));

        //Ejectuta combinatoria
        for (int i = 0; i < pow; i++)
        {
            combinaciones.Add(Converter(i));
        }

        //Normaliza tamaño de números binarios
        for (int j = 0; j < (int)pow / 2; j++)
        {
            String auxComb = "";
            if (combinaciones[j].Length < caracteristicas) {
                for (int k = 0; k < caracteristicas - combinaciones[j].Length; k++) {
                    auxComb = auxComb + '0';
                }
                auxComb += combinaciones[j];
                combinaciones[j] = auxComb;
            }
        }
        return combinaciones;
    }
    public String Converter(int n)
    {
        if (n == 0) return "0";
        int remainder;
        string binary = string.Empty;
        while (n > 0)
        {
            remainder = n % 2;
            n /= 2;
            binary = remainder.ToString() + binary;
        }
        return binary;
    }
}
