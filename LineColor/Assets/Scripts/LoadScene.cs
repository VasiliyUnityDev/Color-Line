using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string NameScene;

    public void OnClick()
    {
        SceneManager.LoadScene(NameScene);
    }
}
