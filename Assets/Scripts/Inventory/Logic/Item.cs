using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemName itemName;
    //private string pickUpProp = "PickUpProp";
    private void Awake() 
    {
        
    }
    public void ItemPicked()
    {
        //添加到背包后隐藏物体
        InventoryManager.Instance.AddItem(itemName);
        this.gameObject.SetActive(false);
    }
}
