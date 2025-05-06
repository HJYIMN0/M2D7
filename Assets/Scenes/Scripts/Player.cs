using UnityEngine;

[System.Serializable]
public class Player
{
    [SerializeField] public string nome;
    private int punteggio = 100;
    [SerializeField] int punteggioPubblico;

    public int IncrementaPunteggio()
    {

        punteggio++;
        return punteggio;

    }

    public int GetPunteggio()
    {
        punteggioPubblico = punteggio;
        Debug.Log($"Questo è il punteggio: {punteggioPubblico}");
        return punteggioPubblico;
    }

    public void SetPunteggio(int punteggioPubblico)
    {
        if (punteggioPubblico >= 0)
        {
            punteggio = punteggioPubblico;
            Debug.Log($"Il nuovo valore assegnato del punteggio è: {punteggioPubblico}!");
        }
        else
        {
            Debug.LogWarning($"Il valore assegnato non è ammissibile!");
        }
    }

    public bool IsVincitore(int a)
    {
        if (a >= 100)
        {
            Debug.Log($"Hai vinto!");
            return true;
        }
        else
        {
            Debug.Log("Non hai vinto!");
            return false;
        }
    }

    public int Attacca()
    {
        int dannoEffettuato = Random.Range(0, 26);
        return dannoEffettuato;
    }
        }   
    
    