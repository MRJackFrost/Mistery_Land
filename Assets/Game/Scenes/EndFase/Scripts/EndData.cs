using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndData : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text dano;
    public TMP_Text escudo;
    public TMP_Text tempo;
    void Start()
    {
        escudo.text = "Escudo Conjurado: " + GameManager.Instance.escudo.ToString();
        dano.text = "Dano Recebido: " + GameManager.Instance.dano.ToString("F");
        tempo.text = "Tempo: " + GameManager.Instance.time.ToString("F") + " Segundos";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
