using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharactersticTablo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private void Awake()
    {
        ServiceLocator.RegisterService(text);
    }
}
