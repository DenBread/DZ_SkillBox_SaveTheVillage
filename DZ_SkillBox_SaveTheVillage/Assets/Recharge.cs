using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recharge : MonoBehaviour
{
    [SerializeField] private Button _buttonPeasant;
    [SerializeField] private Button _buttonWarrior;
    [SerializeField] private Image _btnPeasant;
    [SerializeField] private Image _btnWarrior;

    [SerializeField] private bool isSetTruePeasant = false;
    [SerializeField] private bool isSetTrueWarrior = false;

    private float _timerP, _timerW;
    private float _fillAmount;

    private void Update()
    {
        if (isSetTruePeasant)
        {
            _btnPeasant.fillAmount = CoolDownPeasant(2f);
        }

        if (isSetTrueWarrior)
        {
            _btnWarrior.fillAmount = CoolDownWarrior(4f);
        }
    }

    public float CoolDownPeasant(float maxNumber)
    {
        _timerP += Time.deltaTime;
        _fillAmount = Mathf.Lerp(0, maxNumber, _timerP / maxNumber) / maxNumber;

        if (_fillAmount >= 1f)
        {
            isSetTruePeasant = false;
        }
        return _fillAmount;
    }

    public float CoolDownWarrior(float maxNumber)
    {
        _timerW += Time.deltaTime;
        _fillAmount = Mathf.Lerp(0, maxNumber, _timerW / maxNumber) / maxNumber;

        if (_fillAmount >= 1f)
        {
            isSetTrueWarrior = false;
        }
        return _fillAmount;
    }

    public void StartBtnPeasant()
    {
        isSetTruePeasant = true;
        _timerP = 0;
    }

    public void StartBtnWarrior()
    {
        isSetTrueWarrior = true;
        _timerW = 0;
    }



}
