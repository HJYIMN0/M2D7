using JetBrains.Annotations;
using UnityEngine;

public class Enemy
{
    private int hp;
    private int lvl;
    private string name;
    [SerializeField] public int lvlPublic;
    [SerializeField] public int hpPublic;
    public int SetHp()
    {
        hp = Random.Range(10, 25);        
        return hp;
    }

    public int SetLvl()
    {
        lvl = Random.Range(1, 10);
        return lvl;    
    }

        public int GetLvl() 
    {
        lvlPublic = lvl;
        Debug.Log(lvlPublic);
        return lvl;
    }

    public int Gethp()
    {
        hpPublic = hp;
        Debug.Log(hpPublic);
        return hp;    
    }

    public int SubisciDanno(int danno)
    {
        hp -= danno;
        hpPublic = hp;
        if (hp > 0)
            {
             Debug.Log("Bel colpo! Ma sono ancora in piedi.");
            }
        else 
            {
            Debug.Log("Mi hai sconfitto...");
            }
        return hp;
    }



}