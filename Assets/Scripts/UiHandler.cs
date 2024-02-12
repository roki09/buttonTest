using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiHandler : MonoBehaviour
{
    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private ShopMenu _shopMenu;
    void Start()
    {
        _mainMenu.StartScreen();
        //_shopMenu.StartScreen();
    }

}
