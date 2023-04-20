using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowChar : MonoBehaviour
{
    public Transform character1; // the character being followed
    public Transform character2; // the character following

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set the position of character2 to the position of character1
        //character2.position = character1.position;
        character2.position = Vector3.Lerp(character2.position, character1.position, Time.deltaTime * 2f);
    }
}
