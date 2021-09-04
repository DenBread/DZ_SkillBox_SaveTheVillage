using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _txtWarrior;
    [SerializeField] private Text _txtMillet;
    [SerializeField] private Text _txtPeasant;
    [SerializeField] private Text _txtTimer;
    [SerializeField] private Text _txtEnemies;

    private Warrior _warrior;
    private Peasant _peasant;
    private Millet _millet;
    private Timer _timer;
    private Enemies _enemies;

    private void Start()
    {
        _warrior = GetComponent<Warrior>();
        _peasant = GetComponent<Peasant>();
        _millet = GetComponent<Millet>();
        _timer = GetComponent<Timer>();
        _enemies = GetComponent<Enemies>();
    }

    private void Update()
    {
        _txtWarrior.text = "Воинов: " + _warrior.CointWarrior.ToString();
        _txtPeasant.text = "Крестьяни: " + _peasant.CointPeasant.ToString();
        _txtMillet.text = "Пшеница: " + _millet.CointMillet.ToString();
        _txtTimer.text = "Время: " + Mathf.Round(_timer.TimerSecond).ToString();
        _txtEnemies.text = "Враги: " + _enemies.QuantityEnemies.ToString();
    }
}
