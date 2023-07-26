using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageController : MonoBehaviour
{
    [SerializeField] int sceneIndex;


    public void SceneChange()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
