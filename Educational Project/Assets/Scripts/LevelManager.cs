﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour {

    public string lastScene;
    public string currentScene;

    public void MainMenu()
    {
        SceneManager.LoadScene("Buttons");
    }

    public void Dictionary()
    {
        SceneManager.LoadScene("Dic1");
    }

    public void Dic1()
    {
        SceneManager.LoadScene("Dic1");
    }

    public void DicA1()
    {
        SceneManager.LoadScene("DicA1");
    }

    public void DictH1()
    {
        SceneManager.LoadScene("DictH1");
    }

    public void DictK1()
    {
        SceneManager.LoadScene("DictK1");
    }

    public void DictM1()
    {
        SceneManager.LoadScene("DictM1");
    }

    public void DictN1()
    {
        SceneManager.LoadScene("DictN1");
            }

    public void DictNg()
    {
        SceneManager.LoadScene("DictNg");
    }
    public void DictP1()
    {
        SceneManager.LoadScene("DictP1");

    }

    public void DictR1()
    {
        SceneManager.LoadScene("DictR1");
    }

    public void DictT1()
    {
        SceneManager.LoadScene("DictT1");
    }

    public void DictW1()
    {
        SceneManager.LoadScene("DictW1");
    }

    public void DictWh1()
    {
        SceneManager.LoadScene("DictWh1");
    }

    public void ForwardButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void LoadLastScene()
    {
        string last = lastScene;
        lastScene = currentScene;
        currentScene = last;
        SceneManager.LoadScene(currentScene);
    }

    //AScene Folder
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

    //sceneE folder

    public void SceneE()
    {
        SceneManager.LoadScene("SceneE");
    }

    public void SceneHE()
    {
        SceneManager.LoadScene("SceneHE");
    }

    public void SceneKE()
    {
        SceneManager.LoadScene("SceneKE");
    }

    public void SceneME()
    {
        SceneManager.LoadScene("SceneME");
    }

    public void SceneNE()
    {
        SceneManager.LoadScene("SceneNE");
    }
    
    public void SceneNGE()
    {
        SceneManager.LoadScene("SceneNGE");
    }

    public void ScenePE()
    {
        SceneManager.LoadScene("ScenePE");
    }

    public void SceneRE()
    {
        SceneManager.LoadScene("SceneRE");
    }

    public void SceneTE()
    {
        SceneManager.LoadScene("SceneTE");
    }

    public void SceneWE()
    {
        SceneManager.LoadScene("SceneWE");
    }

    public void SceneWHE()
    {
        SceneManager.LoadScene("SceneWHE");
    }

    //HScene folder

    public void SceneH()
    {
        SceneManager.LoadScene("SceneH");
    }

    public void SceneK()
    {
        SceneManager.LoadScene("SceneK");
    }

    public void SceneM()
    {
        SceneManager.LoadScene("SceneM");
    }

    public void SceneN()
    {
        SceneManager.LoadScene("SceneN");
    }

    public void SceneNG()
    {
        SceneManager.LoadScene("SceneNG");
    }

    public void SceneP()
    {
        SceneManager.LoadScene("SceneP");
    }

    public void SceneR()
    {
        SceneManager.LoadScene("SceneR");
    }

    public void SceneT()
    {
        SceneManager.LoadScene("SceneT");
    }

    public void SceneW()
    {
        SceneManager.LoadScene("SceneW");
    }

    public void SceneWH()
    {
        SceneManager.LoadScene("SceneWH");
    }

    //IScene folder

    public void SceneI()
    {
        SceneManager.LoadScene("SceneI");
    }

    public void SceneHI()
    {
        SceneManager.LoadScene("SceneHI");
    }

    public void SceneKI()
    {
        SceneManager.LoadScene("SceneKI");
    }

    public void SceneMI()
    {
        SceneManager.LoadScene("SceneMI");
    }

    public void SceneNI()
    {
        SceneManager.LoadScene("SceneNI");
    }

    public void SceneNGI()
    {
        SceneManager.LoadScene("SceneNGI");
    }

    public void ScenePI()
    {
        SceneManager.LoadScene("ScenePI");
    }

    public void SceneRI()
    {
        SceneManager.LoadScene("SceneRI");
    }

    public void SceneTI()
    {
        SceneManager.LoadScene("SceneTI");
    }

    public void SceneWI()
    {
        SceneManager.LoadScene("SceneWI");
    }

    public void SceneWHI()
    {
        SceneManager.LoadScene("SceneWHI");
    }

    //OScene folder

    public void SceneO()
    {
        SceneManager.LoadScene("SceneO");
    }

    public void SceneHO()
    {
        SceneManager.LoadScene("SceneHO");
    }

    public void SceneKO()
    {
        SceneManager.LoadScene("SceneKO");
    }

    public void SceneMO()
    {
        SceneManager.LoadScene("SceneMO");
    }

    public void SceneNO()
    {
        SceneManager.LoadScene("SceneNO");
    }

    public void SceneNGO()
    {
        SceneManager.LoadScene("SceneNGO");
    }

    public void ScenePO()
    {
        SceneManager.LoadScene("ScenePO");
    }

    public void SceneRO()
    {
        SceneManager.LoadScene("SceneRO");
    }

    public void SceneTO()
    {
        SceneManager.LoadScene("SceneTO");
    }

    public void SceneWO()
    {
        SceneManager.LoadScene("SceneWO");
    }

    public void SceneWHO()
    {
        SceneManager.LoadScene("SceneWHO");
    }

    //UScene folder

    public void SceneU()
    {
        SceneManager.LoadScene("SceneU");
    }

    public void SceneHU()
    {
        SceneManager.LoadScene("SceneHU");
    }

    public void SceneKU()
    {
        SceneManager.LoadScene("SceneKU");
    }

    public void SceneMU()
    {
        SceneManager.LoadScene("SceneMU");
    }

    public void SceneNU()
    {
        SceneManager.LoadScene("SceneNU");
    }

    public void SceneNGU()
    {
        SceneManager.LoadScene("SceneNGU");
    }

    public void ScenePU()
    {
        SceneManager.LoadScene("ScenePU");
    }

    public void SceneRU()
    {
        SceneManager.LoadScene("SceneRU");
    }

    public void SceneTU()
    {
        SceneManager.LoadScene("SceneTU");
    }

    public void SceneWU()
    {
        SceneManager.LoadScene("SceneWU");
    }

    public void SceneWHU()
    {
        SceneManager.LoadScene("SceneWHU");
    }
}

