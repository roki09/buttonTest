using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUi : Abstract_Ui
{
    [SerializeField] private AbstractButton exit;
    [SerializeField] private Abstract_Ui _mainMenu;

    public override void StartScreen()
    {
        base.StartScreen();
        exit.AddListener(ExitShop);
    }
    public async void ExitShop()
    {
        await CloseScreen();
        _mainMenu.StartScreen();
    }
}
