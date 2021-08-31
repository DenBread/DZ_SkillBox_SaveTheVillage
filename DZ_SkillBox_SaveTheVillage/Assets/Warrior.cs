using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    private Millet millet;
    private int _cointWarrior = 0;
    public int CointWarrior
    {
        get { return _cointWarrior; }
    }

    private float _traningTime;

    private void Start()
    {
        millet = GetComponent<Millet>();
    }

    public void HireWarrior()
    {
        if (millet.CointMillet >= 4)
        {
            millet.AddAndTakeAwayMillet(-4);
            ++_cointWarrior;
            Debug.Log("+1 воина");
        }
        else
        {
            Debug.Log("Мало пшеницы");
        }


    }
}
