using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Esercizio02 : MonoBehaviour
{
    Player giocatore1 = new Player();
    public string nomeGiocatore1 = "Peppe";
    
    // Start is called before the first frame update
    void Start()
    {
        giocatore1.nome = nomeGiocatore1;
        giocatore1.GetPunteggio();
        //giocatore1.SetPunteggio(100);
        Debug.Log($"Questo è il valore del punteggio di {giocatore1.nome} prima del moltiplicatore: {giocatore1.GetPunteggio()}");
        giocatore1.IncrementaPunteggio();
        Debug.Log($"Questo è il valore del punteggio di {giocatore1.nome} dopo il moltiplicatore: {giocatore1.GetPunteggio()}");
        giocatore1.IsVincitore(giocatore1.GetPunteggio());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
