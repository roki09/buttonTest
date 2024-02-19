using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BuyLogic : MonoBehaviour
{
    [SerializeField] private Image _image;
    private Image currentImage;


    private void Start()
    {
        for (int i = 0; i < 500; i++)
        { 
            CreateItem();
        }
    }

    public void CreateItem()
    {
        currentImage = Instantiate(_image, transform.position, Quaternion.identity);
        currentImage.transform.SetParent(transform, true);
    }

}
