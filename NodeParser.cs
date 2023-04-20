using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XNode;

public class NodeParser : MonoBehaviour
{
    public DialogueGraph graph;
    Coroutine _parser;
    
    public Text speaker;
    public Text dialogue;
    public Image speakerImage;

    private void Start() {
        foreach (BaseNode b in graph.nodes) {
            if (b.GetString() == "Start") {
                //Do something here...
                //Tracking the first node...
                graph.current = b;
                break;
            }
        }

        _parser = StartCoroutine(ParseNode());
    }

    IEnumerator ParseNode() {
        BaseNode b = graph.current;
        string data = b.GetString();
        string[] dataParts = data.Split('/');
        //12:19
        if (dataParts[0] == "Start") {
            NextNode("exit");
        }
        
        if (dataParts[0] == "DialogueNode") {
            //Run Dialogue Processing...
            speaker.text = dataParts[1];
            dialogue.text = dataParts[2];
            speakerImage.sprite = b.GetSprite();

            //12:08
            //I might change this to be left click or whatever it was...
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
            yield return new WaitUntil(() => Input.GetMouseButtonUp(0));

            NextNode("exit");
        }
    }

    public void NextNode(string fieldName) {
        //find the port with this name...
        //10:45
        if (_parser != null) {
            StopCoroutine(_parser);
            _parser = null;
        }

        foreach (NodePort p in graph.current.Ports) {
            if (p.fieldName == fieldName) {
                graph.current = p.Connection.node as BaseNode;
                break;
            }
        }

        _parser = StartCoroutine(ParseNode());
    }
}
