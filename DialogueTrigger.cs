using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class DialogueTrigger : MonoBehaviour
{
    //This represents my trigger object, but it's a "Dialogue" object, so that it references the other classes.
    public Dialogue dialogue;

    // locating our dialogue manager
    public void TriggerDialogue () {
        //Singleton pattern? Better way to do it apparently
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
