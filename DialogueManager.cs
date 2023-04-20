using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;

    //for the animation stuff:
    public Animator anim;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue d) {
        //Debug.Log("Starting conversation with" + d.name);
        
        //for animation:
        anim.SetBool("IsOpen",true);

        nameText.text = d.name;

        sentences.Clear();

        foreach (string sentence in d.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        if (sentences.Count == 0) {
            EndDialogue();
            //maybe instead of returning I can signal the buttons to come up
            //I need to make method for start buttons, end buttons
            //
            return;
        }

        string sentence = sentences.Dequeue();
        //dialogueText.text = sentence;

        //Instead of line above we are calling it this way so it appears letter by letter.
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

        //Debug.Log(sentence);
    }

    IEnumerator TypeSentence (string sentence) {
        dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray()) {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue () {

        anim.SetBool("IsOpen",false);

        //This displays when all the sentences have been clicked through...
        // Debug.Log("...");
    }

}
