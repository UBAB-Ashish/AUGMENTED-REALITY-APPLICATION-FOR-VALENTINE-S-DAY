using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MAINMENU : MonoBehaviour
{
   
    public string name = "scene1";
    //public Button enter;
     //Start is called before the first frame update
    void Start()
    {

    }

   // Update is called once per frame
    void Update()
    {

    }

    public void PLAY_BUTTON_PRESSED()
    {
        SceneManager.LoadScene(name);
    }

    public void EXIT_LEVEL()
    {
        Application.Quit();
    }
}

