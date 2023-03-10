using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flower : MonoBehaviour
{
    public bool foundFlower;
    public Button FlowerButton;
    private GameObject theFlower;
    public bool Flowerpicked;

    void Start()
    {
        foundFlower = false;
        FlowerButton.interactable = false;
    }

    void Update()
    {
        //Debug.Log(keypicked);
        if (foundFlower)
        {
            FlowerButton.interactable = true;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision) { 
        if (collision.gameObject.tag == "Player1") {
            foundFlower = true;}
    }

    private void OnTriggerExit2D(Collider2D collision) { 
            foundFlower = false;
            FlowerButton.interactable = false;
    }

    public void PickUpFlower()
    {
        Flowerpicked = true;
    }
}
