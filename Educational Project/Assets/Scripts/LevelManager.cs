using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour {


    public void MainMenu()
    {
        SceneManager.LoadScene("Buttons");
    }

    public void Dictionary()
    {
        SceneManager.LoadScene("Dictionary");
    }

    public void ForwardButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void SceneA()
    {
        SceneManager.LoadScene("SceneA");
    }

    public void SceneA1()
    {
        SceneManager.LoadScene("SceneA1");
    }

    public void SceneHA()
    {
        SceneManager.LoadScene("SceneHA");
    }

    public void SceneKA()
    {
        SceneManager.LoadScene("SceneKA");
    }

    public void SceneMA()
    {
        SceneManager.LoadScene("SceneMA");
    }

    public void SceneNA()
    {
        SceneManager.LoadScene("SceneNA");
    }

    public void ScenePA()
    {
        SceneManager.LoadScene("ScenePA");
    }

    public void SceneRA()
    {
        SceneManager.LoadScene("SceneRA");
    }

    public void SceneTA()
    {
        SceneManager.LoadScene("SceneTA");
    }

    public void SceneWA()
    {
        SceneManager.LoadScene("SceneWA");
    }

    public void SceneNGA()
    {
        SceneManager.LoadScene("SceneNGA");
    }

    public void SceneWHA()
    {
        SceneManager.LoadScene("SceneWHA");
    }

    public void SceneE()
    {
        SceneManager.LoadScene("SceneE");
    }
}

