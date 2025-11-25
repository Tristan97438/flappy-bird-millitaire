using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ScriptMenu : MonoBehaviour
{
    private bool okForFade;
    
    
    
    
     private string sceneToLoad = "ScenePrincipal";


    void Start()
    {
        okForFade = true;
        Cursor.lockState = CursorLockMode.None;
    }


    void Update()
    {

    }
    public void play()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    public void exit()
    {
        Application.Quit();
    }

   
}

