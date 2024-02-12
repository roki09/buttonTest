using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : Abstract_Ui
{
    [SerializeField] private AbstractButton exit;
    [SerializeField] private Abstract_Ui _mainMenu;

    public override void StartScreen()
    {
        base.StartScreen();
        exit.AddListener(ExitOption);
    }
    public async void ExitOption()
    {
        await CloseScreen();
        _mainMenu.StartScreen();
    }
}
