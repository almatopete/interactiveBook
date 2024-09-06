using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneNamed : MonoBehaviour
{
    public void LoadSceneWithName(string sceneName){
        Debug.Log("Hello scene: " + sceneName);
        SceneManager.LoadScene(sceneName);
    } 
}
