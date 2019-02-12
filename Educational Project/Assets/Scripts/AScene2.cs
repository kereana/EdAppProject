using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AScene2 : MonoBehaviour {

    public void Home()
    {   //loading home scene once the home button is selected
        SceneManager.LoadScene("Buttons");
    
    }

}
