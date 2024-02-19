using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RarityItem : AbstractButton, IPointerClickHandler
{
    [SerializeField]private ImageForShop _item;
    [SerializeField] private CoinsScore _coinsScore;
    [SerializeField] private Player _player;

    [SerializeField] private Sprite[] BackgroundImages = new Sprite[4];
    private UnityEngine.UI.Image _image;


    private void Awake()
    {
        _item = GetComponentInChildren<ImageForShop>();
        _image = GetComponent<UnityEngine.UI.Image>();
    }

    private void Start()
    {
        SelectBackground();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        BuyItem();
    }

    private void BuyItem()
    {
        if (_coinsScore._coins >= _item.item._cost)
        {
            _coinsScore._coins -= _item.item._cost;
            _player._inventar.Add(_item.item);
            _coinsScore.SetScore();
            Destroy(gameObject);
        }
    }

    private void SelectBackground()
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
