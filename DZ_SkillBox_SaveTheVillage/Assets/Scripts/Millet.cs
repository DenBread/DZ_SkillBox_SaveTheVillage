using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Millet : MonoBehaviour
{
    private int _cointMillet; // кол-во пшеницы
    public int _quantityMillet; // коэфициент добычи
    private float _timerSecond = 2f;

    public int CointMillet
    {
        set { _cointMillet = value; }
        get { return _cointMillet; }
    }

    private void Start()
    {
        _quantityMillet = 1;
    }

    private void Update()
    {
        TimerMillet();
    }

    public void AddAndTakeAwayMillet(int coint)
    {
        _cointMillet += coint;
    }

    private void TimerMillet()
    {
        if (_timerSecond >= 0)
        {
            _timerSecond -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Add Millet");
            AddAndTakeAwayMillet(+_quantityMillet);
            _timerSecond = 2f;
        }
    }
}
