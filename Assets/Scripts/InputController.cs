using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private PunnettScript _simulador;
    private int alelos;
    private void Start()
    {
        _slider.onValueChanged.AddListener((v) =>
        {
            alelos = (int)v;
            _text.text = v.ToString();
        });
    }
    public void IniciarMezcla() {
        _simulador.PreCombinar(alelos);   
    }
}
