using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RarityItem : MonoBehaviour
{
    [SerializeField]private ImageForShop _item;
    [SerializeField] private Sprite[] BackgroundImages = new Sprite[4];
    private UnityEngine.UI.Image _image;

    private void Awake()
    {
        _item = GetComponentInChildren<ImageForShop>();
        _image = GetComponent<UnityEngine.UI.Image>();
    }

    private void Start()
    {
        switch (_item.item._value)
        {
            case 1:
                _image.sprite = BackgroundImages[0]; break;
            case 2:
                _image.sprite = BackgroundImages[1]; break;
            case 3:
                _image.sprite = BackgroundImages[2]; break;
            case 4:
                _image.sprite = BackgroundImages[3]; break;
        }
    }
}
