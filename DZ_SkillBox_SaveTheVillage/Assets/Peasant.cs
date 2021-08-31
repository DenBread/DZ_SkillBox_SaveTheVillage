using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peasant : MonoBehaviour
{
    private Recharge _recharge;
    private int _cointPeasant = 1; // кол-во крестьян

    public int CointPeasant
    {
        get { return _cointPeasant; }
    }

    private Millet millet; // пшеница


    private void Start()
    {
        
        millet = GetComponent<Millet>();
    }

    public void HirePeasant()
    {
        
        if (millet.CointMillet >= 2)
        {
            millet.AddAndTakeAwayMillet(-2);
            ++_cointPeasant;
            Debug.Log("+1 крестьянин");
        }
        else
        {
            Debug.Log("Мало пшеницы");   
        }

        
    }
    
}
