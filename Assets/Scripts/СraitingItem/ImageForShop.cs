using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ImageForShop : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Sprite[] _spriteArray = new Sprite[6];
    [SerializeField] private TextMeshProUGUI _text;

    public Pot item;

    private Image currentImage;

    private Dictionary<int, string> _name = new Dictionary<int, string>
    {
        [0] = "HealPot",
        [1] = "PosionPot",
        [2] = "ManaPot",
        [3] = "HolyPot",
        [4] = "CursedPot",
        [5] = "Bottle"
    };

    private Dictionary<string, int> _sprite = new Dictionary<string, int>
    {
        ["HealPot"] = 0,
        ["PoisonPot"] = 1,
        ["ManaPot"] = 2,
        ["HolyPot"] = 3,
        ["CursedPot"] = 4,
        ["Bottle"] = 5
    };

    private void Awake()
    {
        currentImage = GetComponent<Image>();

        _name.TryGetValue(Random.Range(0, 5), out string name);
        _sprite.TryGetValue(name, out int spriteIndex);

        currentImage.sprite = _spriteArray[spriteIndex];

        item = new Pot(name, Random.Range(1, 5), Random.Range(100, 250));
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _text.text = item.ShowStats();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _text.text = null;
    }
}
