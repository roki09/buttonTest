using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinsScore : MonoBehaviour
{

    [SerializeField] private int _coins = 100;
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        SetScore();
    }
    public void SetScore()
    {
        _text.text = $"Ñoins: {_coins}";
    }

    public void BuyItem(int cost)
    {
        if (_coins > cost)
            _coins -= cost;
    }
}
