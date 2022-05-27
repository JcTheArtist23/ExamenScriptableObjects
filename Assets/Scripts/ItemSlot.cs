
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour
{
    public Item item;
    public Image icon;
    public TextMeshProUGUI itemNameTXT;
    
    public void SetItem(Item item)
    {
        this.item = item;
        icon.overrideSprite = item.icon;
        itemNameTXT.text = item.itemName;
    }

    public void OnClick()
    {
        ItemController.instance.SetItem(item);
    }
}

