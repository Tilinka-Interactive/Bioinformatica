using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AleloConjunto : MonoBehaviour
{
    private int id;
    private char dominante;
    private char recesivo;
    [SerializeField] private TextMeshProUGUI v1;
    [SerializeField] private TextMeshProUGUI v2;
    [SerializeField] private TextMeshProUGUI v3;
    [SerializeField] private TextMeshProUGUI show;
    [SerializeField] private PunnettScript punnett;
    public void SetId(int id) {
        this.id = id;
    }
    public int GetId(){
        return id;
    }
    public void setAlelos(char d, char r){
        dominante = d;
        recesivo = r;
        ChangeRep();
    }
    public void ChangeRep() {
        v1.text = dominante.ToString() + dominante.ToString();
        v2.text = recesivo.ToString() + recesivo.ToString();
        v3.text = dominante.ToString() + recesivo.ToString();
    }
    public void AddShower(TextMeshProUGUI showText) {
        show = showText;
    }
    public void ShowV1(){
        show.text = v1.text;
        RefreshTupla();
    }
    public void ShowV2(){
        show.text = v2.text;
        RefreshTupla();
    }
    public void ShowV3(){
        show.text = v3.text;
        RefreshTupla();
    }
    public void RefreshTupla(){
        //Debug.Log(show.text.ToString()[0]+","+ show.text.ToString()[1]);
        punnett.ChangeTupla(id, show.text.ToString()[0], show.text.ToString()[1]);
    }
    public void setPunnettScript(PunnettScript punnettP) {
        punnett = punnettP;
    }
}
