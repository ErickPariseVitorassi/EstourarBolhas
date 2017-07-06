using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

    private float currentTime_0;
    private float currentTime;
    private int whatBubble;
    private float timerPlay;

    public static bool timePlay;
    public static bool soundLetter;
    public static bool play;
    public static int whatLetter;
    public static int level;
    public static int numLetterBubble_0;
    public static int numLetterBubble_1;
    public static int numLetterBubble_2;
    public static int numLetterBubble_3;
    public static int numLetterBubble_4;
    public static int numLetterBubble_5;

    public float rateSpawn;

    public GameObject[] bubbles;
    public AudioSource audioBubbles;
    public AudioClip soundBubbles;
    public AudioClip[] soundLetters;

    // Use this for initialization
    void Start()
    {
        level = 0;
        timerPlay = 0;  
        currentTime_0 = 0;
        currentTime = 0;
        soundLetter = true;
        play = true;
        timePlay = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Delay or start
        if (timePlay)
        {
            timerPlay += Time.deltaTime;
            if(timerPlay >= 1.7f)
            {
                timerPlay = 0;
                play = true;
                timePlay = false;
            } 
        }

        currentTime_0 += Time.deltaTime;
        if (currentTime_0 >= 2)
        {
            if (play)
            {
                // Sets the correct letter
                if (soundLetter)
                {
                    whatLetter = Random.Range(0, 25);
                    audioBubbles.PlayOneShot(soundLetters[whatLetter]);
                    soundLetter = false;
                }

                currentTime += Time.deltaTime;
                if (currentTime >= rateSpawn)
                {
                    currentTime = 0;

                    audioBubbles.PlayOneShot(soundBubbles);

                    // This levels randomly sets the other letters

                    // LEVEL 0
                    if (level == 0)
                    {
                        numLetterBubble_2 = Random.Range(0, 25);
                        numLetterBubble_4 = Random.Range(0, 25);

                        whatBubble = Random.Range(0, 100);
                        if (whatBubble < 50)
                        {
                            numLetterBubble_2 = whatLetter;
                        }
                        else
                        {
                            numLetterBubble_4 = whatLetter;
                        }
                        GameObject tempPrefab_0 = Instantiate(bubbles[2]) as GameObject;
                        GameObject tempPrefab_1 = Instantiate(bubbles[4]) as GameObject;
                    }

                    // LEVEL 1
                    if (level == 1)
                    {
                        numLetterBubble_0 = Random.Range(0, 25);
                        numLetterBubble_1 = Random.Range(0, 25);
                        numLetterBubble_3 = Random.Range(0, 25);

                        whatBubble = Random.Range(0, 150);
                        if (whatBubble < 50)
                        {
                            numLetterBubble_0 = whatLetter;
                        }
                        else if (whatBubble > 100)
                        {
                            numLetterBubble_1 = whatLetter;
                        }
                        else
                        {
                            numLetterBubble_3 = whatLetter;
                        }
                        GameObject tempPrefab_0 = Instantiate(bubbles[0]) as GameObject;
                        GameObject tempPrefab_1 = Instantiate(bubbles[1]) as GameObject;
                        GameObject tempPrefab_2 = Instantiate(bubbles[3]) as GameObject;
                    }

                    // LEVEL 2
                    if (level == 2)
                    {
                        numLetterBubble_0 = Random.Range(0, 25);
                        numLetterBubble_2 = Random.Range(0, 25);
                        numLetterBubble_4 = Random.Range(0, 25);
                        numLetterBubble_5 = Random.Range(0, 25);

                        whatBubble = Random.Range(0, 200);
                        if (whatBubble < 50)
                        {
                            numLetterBubble_0 = whatLetter;
                        }
                        else if (whatBubble > 150)
                        {
                            numLetterBubble_2 = whatLetter;
                        }
                        else if (whatBubble > 50 && whatBubble < 100)
                        {
                            numLetterBubble_4 = whatLetter;
                        }
                        else
                        {
                            numLetterBubble_5 = whatLetter;
                        }
                        GameObject tempPrefab_0 = Instantiate(bubbles[0]) as GameObject;
                        GameObject tempPrefab_1 = Instantiate(bubbles[2]) as GameObject;
                        GameObject tempPrefab_2 = Instantiate(bubbles[4]) as GameObject;
                        GameObject tempPrefab_3 = Instantiate(bubbles[5]) as GameObject;
                    }

                    // LEVEL 3
                    if (level == 3)
                    {
                        numLetterBubble_0 = Random.Range(0, 25);
                        numLetterBubble_1 = Random.Range(0, 25);
                        numLetterBubble_2 = Random.Range(0, 25);
                        numLetterBubble_3 = Random.Range(0, 25);
                        numLetterBubble_5 = Random.Range(0, 25);

                        whatBubble = Random.Range(0, 250);
                        if (whatBubble < 50)
                        {
                            numLetterBubble_0 = whatLetter;
                        }
                        else if (whatBubble > 200)
                        {
                            numLetterBubble_1 = whatLetter;
                        }
                        else if (whatBubble > 50 && whatBubble < 100)
                        {
                            numLetterBubble_2 = whatLetter;
                        }
                        else if (whatBubble > 100 && whatBubble < 150)
                        {
                            numLetterBubble_3 = whatLetter;
                        }
                        else
                        {
                            numLetterBubble_5 = whatLetter;
                        }
                        GameObject tempPrefab_0 = Instantiate(bubbles[0]) as GameObject;
                        GameObject tempPrefab_1 = Instantiate(bubbles[1]) as GameObject;
                        GameObject tempPrefab_2 = Instantiate(bubbles[2]) as GameObject;
                        GameObject tempPrefab_3 = Instantiate(bubbles[3]) as GameObject;
                        GameObject tempPrefab_4 = Instantiate(bubbles[5]) as GameObject;
                    }

                    // LEVEL 4
                    if (level == 4)
                    {
                        numLetterBubble_0 = Random.Range(0, 25);
                        numLetterBubble_1 = Random.Range(0, 25);
                        numLetterBubble_2 = Random.Range(0, 25);
                        numLetterBubble_3 = Random.Range(0, 25);
                        numLetterBubble_4 = Random.Range(0, 25);
                        numLetterBubble_5 = Random.Range(0, 25);

                        whatBubble = Random.Range(0, 300);
                        if (whatBubble < 50)
                        {
                            numLetterBubble_0 = whatLetter;
                        }
                        else if (whatBubble > 250)
                        {
                            numLetterBubble_1 = whatLetter;
                        }
                        else if (whatBubble > 50 && whatBubble < 100)
                        {
                            numLetterBubble_2 = whatLetter;
                        }
                        else if (whatBubble > 100 && whatBubble < 150)
                        {
                            numLetterBubble_3 = whatLetter;
                        }
                        else if (whatBubble > 150 && whatBubble < 200)
                        {
                            numLetterBubble_4 = whatLetter;
                        }
                        else
                        {
                            numLetterBubble_5 = whatLetter;
                        }
                        GameObject tempPrefab_0 = Instantiate(bubbles[0]) as GameObject;
                        GameObject tempPrefab_1 = Instantiate(bubbles[1]) as GameObject;
                        GameObject tempPrefab_2 = Instantiate(bubbles[2]) as GameObject;
                        GameObject tempPrefab_3 = Instantiate(bubbles[3]) as GameObject;
                        GameObject tempPrefab_4 = Instantiate(bubbles[4]) as GameObject;
                        GameObject tempPrefab_5 = Instantiate(bubbles[5]) as GameObject;
                    }
                    play = false;
                }
            }
        }
    }
}
