using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStuff : MonoBehaviour
{
    public string SampleScene;

    public void GoNextScene()
    {
        SceneManager.LoadScene(SampleScene);
    }
}
