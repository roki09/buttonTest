using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class MainMenu : Abstract_Ui
{

    [SerializeField] private AbstractButton start, options, shop;
    [SerializeField] private Abstract_Ui _shopUi;
    [SerializeField] private Abstract_Ui _optionUi;
    [SerializeField] private Abstract_Ui _inGame;

    public override void StartScreen()
    {
        base.StartScreen();
        start.AddListener(StartGame);
        shop.AddListener(StartShop);
        options.AddListener(StartOption);
    }

    private async void StartGame()
    {
        await CloseScreen();
        _inGame.StartScreen();
    }

    private async void StartOption()
    {
        await CloseScreen();
        _optionUi.StartScreen();
    }

    private async void StartShop()
    {
        await CloseScreen();
        _shopUi.StartScreen();
    }
}
