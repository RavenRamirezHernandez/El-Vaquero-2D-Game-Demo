using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonAreaTrigger : MonoBehaviour
{
    public int sceneBuildIndex;
    public Button button;

    private void Start() {
        button.onClick.AddListener(SwitchScene);
    }

    private void SwitchScene() {
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }

}
