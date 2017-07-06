using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour {

    private int whatCelebration;
    private bool visualScore;
    private bool visualError;
    private float timeVisual;

    public static int score;
    public static int error;
    public static int round;
    public static bool animate;
    public static bool animateBad;

    public UnityEngine.UI.Text scoreTrue;
    public UnityEngine.UI.Text scoreFalse;
    public UnityEngine.UI.Text timer;
    public UnityEngine.UI.Text roundNow;
    public float time;

    public Animator babu;
    public AudioSource audioBabu;
    public AudioClip[] soundLetters;
    public AudioClip[] babuCelebration;
    public AudioClip soundScore;
    public AudioClip soundError;
    public GameObject prefabScore;
    public GameObject prefabError;

    // Use this for initialization
    void Start () {
        round = 1;
        score = 0;
        error = 0;
        timeVisual = 0;
        animate = false;
        animateBad = false;
        visualScore = false;
        visualError = false;
	}
	
	// Update is called once per frame
	void Update () {
        // If click in correct bubble
        if (animate)
        {
            babu.SetBool("Happy", true);
            audioBabu.PlayOneShot(soundScore);
            whatCelebration = Random.Range(0, 8);
            audioBabu.PlayOneShot(babuCelebration[whatCelebration]);
            prefabScore.transform.position = new Vector3(prefabScore.transform.position.x, prefabScore.transform.position.y - 100, prefabScore.transform.position.z);
            animate = false;
            visualScore = true;
        }
        if (visualScore)
        {
            timeVisual += Time.deltaTime;
            if (timeVisual > 1.5f) {
                timeVisual = 0;
                prefabScore.transform.position = new Vector3(prefabScore.transform.position.x, prefabScore.transform.position.y + 100, prefabScore.transform.position.z);
                visualScore = false;
            }       
        }

        // If don't click in correct bubble
        if (animateBad)
        {
            babu.SetBool("Sad", true);
            audioBabu.PlayOneShot(soundError);
            audioBabu.PlayOneShot(soundLetters[SpawnController.whatLetter]);
            prefabError.transform.position = new Vector3(prefabError.transform.position.x, prefabError.transform.position.y - 100, prefabError.transform.position.z);
            animateBad = false;
            visualError = true;
        }
        if (visualError)
        {
            timeVisual += Time.deltaTime;
            if (timeVisual > 1.5f)
            {
                timeVisual = 0;
                prefabError.transform.position = new Vector3(prefabError.transform.position.x, prefabError.transform.position.y + 100, prefabError.transform.position.z);
                visualError = false;
            }
        }

        if(time <= 0)
            Application.LoadLevel("end_game");

        //Modify the texts
        time -= Time.deltaTime;
        timer.text = time.ToString();
        roundNow.text = round.ToString();
        scoreTrue.text = score.ToString();
        scoreFalse.text = error.ToString();
    }
}
