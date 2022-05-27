using UnityEngine;
[CreateAssetMenu(fileName ="New Item",menuName = "Items/NewItem",order =0)]
public class Item : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public string itemPrice;
    public Sprite icon;
}
