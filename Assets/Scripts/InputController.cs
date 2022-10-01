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
    [SerializeField] private GameObject Padre;
    [SerializeField] private GameObject PadreShow;
    [SerializeField] private GameObject Caracteristica;
    [SerializeField] private GameObject Show;
    private string[] caracteristicasA;
    private int alelos = 2;
    private void Start()
    {
        caracteristicasA  = new string[] { "Aa", "Bb", "Cc", "Dd", "Ee", "Ff", "Gg", "Hh", "Ii", "Jj", "Kk", "Ll", "Mm", "Nn", "Oo", "Pp", "Qq", "Rr"};
        
        _slider.onValueChanged.AddListener((v) =>
        {
            alelos = (int)v;
            _text.text = v.ToString();
        });
    }
    public void Pre_Mezcla()
    {
        _simulador.PreCombinar(alelos);
        for (int i = 0; i < alelos; i++)
        {
            GameObject Car = Instantiate(Caracteristica) as GameObject;
            GameObject Shower = Instantiate(Show) as GameObject;
            _simulador.AddTuplaPadre(caracteristicasA[i][0], caracteristicasA[i][0]);
            AleloConjunto alelo = Car.GetComponent<AleloConjunto>();
            alelo.SetId(i);
            alelo.setPunnettScript(_simulador);
            alelo.setAlelos(caracteristicasA[i][0], caracteristicasA[i][1]);
            alelo.AddShower(Shower.GetComponentInChildren<TextMeshProUGUI>());
            Car.transform.SetParent(Padre.transform);
            Shower.transform.SetParent(PadreShow.transform);
        }
    }
    public void Mezcla(){
        _simulador.Combinar();
    }
}
