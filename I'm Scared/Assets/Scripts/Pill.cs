using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pill : MonoBehaviour
{
    [SerializeField]
    int Pill_No = 1;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PillSystem>().addPill(Pill_No);
            Destroy(gameObject);
        }
    }
    
}
