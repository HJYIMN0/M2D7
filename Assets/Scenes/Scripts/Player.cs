using UnityEngine;

[System.Serializable]
public class Player
{
    [SerializeField] public string nome;
    private int punteggio;
    [SerializeField] int punteggioPubblico;

    public int IncrementaPunteggio(int a)
    {

        punteggio += a;
        return punteggio;

    }

    public int GetPunteggio()
    {
        if (punteggio >= 0)
        {
            punteggioPubblico = punteggio;
            Debug.Log($"Questo è il punteggio: {punteggioPubblico}");
            return punteggioPubblico;
        }
        else
        {
            Debug.Log("ERRORE! Il punteggio non è valido!");
            punteggio = 0;
            return punteggio;
        }
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

    public bool IsVincitore()
    {
        int a = GetPunteggio();
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
    
    