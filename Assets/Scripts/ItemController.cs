using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemController : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public GameObject prefabItemSlot;

    [Header("Item Selected")]
    public Image iconSelected;
    public TextMeshProUGUI itemNameTxt;
    public TextMeshProUGUI itemDescription;
    public TextMeshProUGUI itemPrice;
    // Start is called before the first frame update
    public static ItemController instance;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        foreach (var item in items)
        {
            var slotGo = Instantiate(prefabItemSlot, transform.position, Quaternion.identity);
            slotGo.transform.SetParent(GameObject.Find("PanelItems").transform);
            slotGo.GetComponent<ItemSlot>().SetItem(item);
        }
    }

    public void SetItem(Item item)
    {
        var sprite = Resources.Load<Sprite>("Images/" + item.itemName);
        iconSelected.overrideSprite = sprite;
        itemNameTxt.text = item.itemName;
        itemDescription.text = item.itemDescription;
        itemPrice.text = item.itemPrice;
    }
}

