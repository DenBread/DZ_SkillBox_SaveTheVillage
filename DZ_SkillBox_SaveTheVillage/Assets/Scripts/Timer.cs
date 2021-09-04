using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _timeSecond;
    public float TimerSecond
    {
        get { return _timeSecond; }
    }

    public Text second;
    public Text minutes;
    public float param;
    public float second1;
    public float minuta1;

    [SerializeField] private GameObject losePanel;

    private void Update()
    {
        //StopWhatch();

        param -= Time.deltaTime;
        if (param <= 0 )
        {
            param = 1;
            second1 = second1 - 1;
        }

        if (second1 <= 0)
        {
            minuta1 = minuta1 - 1;
            second1 = 60;
        }

        if (minuta1 < 0)
        {
            minutes.text = "Время: 00 : 00";
            //losePanel.SetActive(true);
        }
        else
        {
            minutes.text = "Время: " + minuta1.ToString() + " : " + second1.ToString();
        }

        //second.text = "" + second1;
        
    }

    //private void StopWhatch()
    //{
    //    //Mathf.Round(_timeSecond).ToString(); // округляем в целое число
    //    if (_timeSecond > 0)
    //    {
    //        _timeSecond -= Time.deltaTime;
    //    }
    //    else
    //    {
    //        _timeSecond = 0;
    //    }
    //}
}
