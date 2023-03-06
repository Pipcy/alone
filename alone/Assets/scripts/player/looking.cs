using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looking : MonoBehaviour
{
    
    [Header("Looking Attributes")]
    [SerializeField] private float range;
    [SerializeField] private LayerMask playerLayer;
    private Vector3[] directions = new Vector3[2];
    private Vector3 destination;




    void Update()
    {
        /*
        if (outdoor)
        {

        }
        */
        CheckForPlayer();
    }

    private void CheckForPlayer()
    {
        CalculateDirections();

        //check if bird sees player in all 4 directions
        for (int i = 0; i < directions.Length; i++)
        {
            Debug.DrawRay(transform.position, directions[i], Color.red);
            RaycastHit2D found = Physics2D.Raycast(transform.position, directions[i], range, playerLayer);
        
            if (found.collider != null)
            {
                Debug.Log("found!!!");
            }
        }
    }

    private void CalculateDirections()
    {
            directions[0] = transform.right * range; //right direction
            directions[1] = -transform.right * range; //left

    }
}
