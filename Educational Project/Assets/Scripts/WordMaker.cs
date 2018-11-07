using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordMaker : MonoBehaviour {


    public AudioSource Words;
    public AudioClip[] WordsList;
    private AudioClip shootClip;



	// Use this for initialization
	private void Awake() {
        //WordsList = new AudioClip[]{(AudioClip)Resources.Load("Audio/WordsForImage")};
        // Words = gameObject.GetComponent<AudioSource>(); //https://answers.unity.com/questions/1161379/how-to-play-a-random-audio-clip-from-an-array-in-c.html

        WordsList = Resources.LoadAll<AudioClip>("Audio/WordsForImage");
        foreach (AudioClip clip in WordsList)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, WordsList.Length);
                shootClip = WordsList[index];
                Words.clip = shootClip;
                Words.Play();
            }
            //Do something with clip
            //WordsList.Add(clip);
            //return;
        }
	}

    //void Start() { 
    
    //}
	
    //// Update is called once per frame
    //void Update () {
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        int index = Random.Range(0, WordsList.Length);
    //        shootClip = WordsList[index];
    //        Words.clip = shootClip;
    //        Words.Play();
    //    }

    //}
}
