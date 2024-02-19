using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pot : Item
{
    [SerializeField] private string _name;
    [SerializeField] private int _cost;

    public Pot(string name, int value, int cost) 
    {
        _name= name;
        _value = value;
        _cost = cost * value;
    
    }

    public string ShowStats()
    {
        return ($"Name:{_name}\nCost:{_cost}\nRarity:{_value}");
    }
}
