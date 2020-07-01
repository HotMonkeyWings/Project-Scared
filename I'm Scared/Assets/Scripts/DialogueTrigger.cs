using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public Dialogue success;
    public int NoOfPills = 0;
    public bool pillInside = false;
    

    public void TriggerDialogue() => FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    public void TriggerDialogueSuccess() => FindObjectOfType<DialogueManager>().StartDialogue(success);

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E) && collision.CompareTag("Player") && pillInside)
        {

            collision.GetComponent<PillSystem>().addPill(NoOfPills);
            TriggerDialogueSuccess();
            pillInside = false;
            NoOfPills = 0;

        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.CompareTag("Player") && !pillInside)
            TriggerDialogue();
    }

}
