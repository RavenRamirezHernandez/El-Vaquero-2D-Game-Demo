using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reaction : MonoBehaviour
{
    public Animation bumpAnimation;

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "OtherCharacter") {
        bumpAnimation.Play();
        }
    }
}
