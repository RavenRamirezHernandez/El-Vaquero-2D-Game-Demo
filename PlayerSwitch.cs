using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//[System.Serializable]
public class PlayerSwitch : MonoBehaviour
{
    public GameObject otherPlayer;
    //public int sceneBuildIndex;

    void OnMouseDown() {
        otherPlayer.GetComponent<playermovement>().enabled = false;
        GetComponent<playermovement>().enabled = true;
        //SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }
}
