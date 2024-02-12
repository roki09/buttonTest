using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public abstract class Abstract_Ui : MonoBehaviour
{
    private Image[] _allImage;
    private float animationDuration = 0.3f;

    private void OnEnable()
    {
        _allImage = GetComponentsInChildren<Image>();
    }

    public virtual void StartScreen()
    {
        gameObject.SetActive(true);
        Color baseColor = new Color(255, 255, 255, 0);

        foreach (var image in _allImage)
        {
            image.color = baseColor;
        }

        foreach (var image in _allImage)
        {
            image.DOFade(1, animationDuration);
        }
    }

    public async Task CloseScreen()
    {
       await Close();
    }

    private async Task Close()
    {
        foreach (var image in _allImage)
        {
            image.DOFade(0, animationDuration);
        }
        await Task.Delay(200);
        gameObject.SetActive(false);
    }
}
