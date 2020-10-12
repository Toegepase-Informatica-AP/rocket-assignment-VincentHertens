using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevelLoad : MonoBehaviour
{
    public string levelToLoad = "Level 2";

    public void LoadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }
   
}
