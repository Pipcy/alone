using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public bool foundKey;
    public Button KeyButton;
    private GameObject theKey;
    public bool keypicked;

    void Start()
    {
        foundKey = false;
        KeyButton.interactable = false;
    }

    void Update()
    {
        //Debug.Log(keypicked);
        if (foundKey)
        {
            KeyButton.interactable = true;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision) { 
        if (collision.gameObject.tag == "Player2") {
            foundKey = true;}
    }

    private void OnTriggerExit2D(Collider2D collision) { 
            foundKey = false;
            KeyButton.interactable = false;
    }

    public void PickUpKey()
    {
        keypicked = true;
    }
}
