using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public int QuantityEnemies
    {
        get { return _quantityEnemies; }
    }

    [SerializeField] private int _quantityEnemies; // кол-во врагов
    [SerializeField] private float _timer; // время через сколько появяться враги
    [SerializeField] private bool _isEnemies;
    [SerializeField] private GameObject _losePanel;

    private Timer _timerScript;

    private Warrior warrior;

    private void Start()
    {
        _timerScript = GetComponent<Timer>();
        warrior = GetComponent<Warrior>();
        _quantityEnemies = Random.Range(2, 4);
        StartCoroutine(CoroutineSample());
    }

    private IEnumerator CoroutineSample()
    {
        while (true)
        {
            yield return new WaitForSeconds(_timer);

            if (_quantityEnemies > warrior.CointWarrior)
            {
                Debug.Log("Вы проиграли");
                _losePanel.SetActive(true);
                break;
            }

            if (_quantityEnemies <= warrior.CointWarrior)
            {
                warrior.CointWarrior -= _quantityEnemies;
            }

            _quantityEnemies = Random.Range(warrior.CointWarrior, warrior.CointWarrior+3);
            _timerScript.second1 = 30f;
        }
    }

}
