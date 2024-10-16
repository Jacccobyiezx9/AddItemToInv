using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public InvManager inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnMouseDown()
    {
        PickUp();
    }

    public void PickUp()
    {
        inventory.itemsInInventory.Add(gameObject);

        gameObject.SetActive(false);
    }

    public void Remove()
    {
        inventory.itemsInInventory.Remove(gameObject);
    }
}
