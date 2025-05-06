using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio01_Script : MonoBehaviour
{
    Player giocatore1 = new Player();
    [SerializeField] string nomeGiocatore1 = "Pino";
    [SerializeField] string nomeGiocatore2 = "Paquale";
    // Start is called before the first frame update
    void Start()
    {

        giocatore1.nome = nomeGiocatore1;
        giocatore1.SetPunteggio(100);

        Player giocatore2 = new Player();
        giocatore2.nome = nomeGiocatore2;
        giocatore2.SetPunteggio(50);

        Debug.Log($"Il punteggio di {giocatore1.nome} è {giocatore1.GetPunteggio()}!");
        Debug.Log($"Il punteggio di {giocatore2.nome} è {giocatore2.GetPunteggio()}!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
