using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio04 : MonoBehaviour
{

    Player giocatore1 = new Player();
    Enemy nemico = new Enemy();
    // Start is called before the first frame update
    void Start()
    {
        nemico.SetHp();
        nemico.Gethp();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        nemico.SubisciDanno(giocatore1.Attacca());
        if (nemico.Gethp() < 0)
        {
            
            giocatore1.GetPunteggio();
            giocatore1.IncrementaPunteggio(10);
            giocatore1.GetPunteggio();
            nemico.SetHp();
        }
        

    }
}
