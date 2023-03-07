using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;//****

public class BigDoor : MonoBehaviour
{
    public Button unlockDoor;
    public TextMeshProUGUI doorLocked1;
    public TextMeshProUGUI doorLocked2;
    public TextMeshProUGUI waitForHer;

    Key keyScript;
    void Start()
    {
        GameObject keyy =  GameObject.Find("key");
        keyScript = keyy.GetComponent<Key>();

        unlockDoor.interactable = false;

        //hints initialize
        doorLocked1.gameObject.SetActive(false);
        doorLocked2.gameObject.SetActive(false);
        waitForHer.gameObject.SetActive(false);

    }

    private void OnCollisionEnter2D(Collision2D collision) { 
        //PLAYER 1
        if (collision.gameObject.tag == "Player1")
        {
            if(keyScript.keypicked) {
                unlockDoor.interactable = true;
                //extra: if check time
            }
            else{
                doorLocked1.gameObject.SetActive(true);
                }
        }
        //PLAYER 2
        if (collision.gameObject.tag == "Player2")
        {
            if(keyScript.keypicked) {
                waitForHer.gameObject.SetActive(true);
            }
            else{
                doorLocked2.gameObject.SetActive(true);
            }
        }

    }

    //turn off text when leave door
    private void OnCollisionExit2D(Collision2D collision) { 
        doorLocked1.gameObject.SetActive(false);
        doorLocked2.gameObject.SetActive(false);
        waitForHer.gameObject.SetActive(false);
    }

    public void UnlockDoor()
    {
        Debug.Log("Door unlocked.");
            //animation
            //sound effect
        SceneManager.LoadScene("EndingWin"); 

        
    }
}
