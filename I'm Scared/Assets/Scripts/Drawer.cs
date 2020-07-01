using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drawer : MonoBehaviour
{
    [SerializeField]
    Text chatBox;
    [SerializeField]
    bool pillInside = false;
    [SerializeField]
    int NoOfPills = 0;

    public string[] strings;
    public string success;
    


    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E) && collision.CompareTag("Player") && pillInside)
        {
            
            collision.GetComponent<PillSystem>().addPill(NoOfPills);
            StartCoroutine("found", success);
            pillInside = false;
            NoOfPills = 0;

        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.CompareTag("Player") && !pillInside)
            StartCoroutine("found", strings[Random.Range(0, strings.Length)]);
    }


    IEnumerator found(string message)
    {
        chatBox.text = message;
        yield return new WaitForSecondsRealtime(5);
        chatBox.text = "";
    }

}
