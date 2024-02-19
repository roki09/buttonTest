using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Weapon : Item, IPointerEnterHandler
{
    [SerializeField] private string _name;
    [SerializeField] private int _damage = 100;
    [SerializeField] private int _cost = 100;

    public Weapon(string name, int value, int damage, int cost)
    {
        _name = name;
        _value = value;
        _damage = damage;
        _cost = (cost+damage)*value;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ShowStats();
    }

    public void ShowStats()
    {
        Debug.Log($"Value:{_value}\nDamage:{_damage}\nCost{_cost}");
    }
}
