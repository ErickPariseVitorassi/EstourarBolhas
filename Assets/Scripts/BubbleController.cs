using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour {

    private float stopX;
    private float largeY;
    private float speed;
    private float timerDestroy;
    private float timerDestroy_0;
    private bool destroy;
    private bool audioTest;
    private bool write;
    private bool destroyBefore;

    public static bool destroyAll;
    public string[] whatLetter;
    public int numBubble;
    public float forceMoveUp;
    public float forceMoveLeft;

    public AudioSource audioBubble;
    public AudioClip soundBubbleBurst;
    public Animator anime;
    public Rigidbody2D bubbleRigidbody;
    public GameObject TextBubble;

    // Use this for initialization
    void Start()
    {
        bubbleRigidbody.AddForce(new Vector2(0, forceMoveUp));
        bubbleRigidbody.AddForce(new Vector2(forceMoveLeft, 0));
        largeY = transform.position.y;
        speed = 0;
        timerDestroy_0 = 0;
        timerDestroy = 0;
        destroyAll = false;
        destroy = false;
        audioTest = true;
        destroyBefore = false;
        TextBubble.GetComponent<TextMesh>().text = whatLetter[0];     
    }

    // Update is called once per frame
    void Update()
    {
        if (numBubble == 0)
            TextBubble.GetComponent<TextMesh>().text = whatLetter[SpawnController.numLetterBubble_0];
        if (numBubble == 1)
            TextBubble.GetComponent<TextMesh>().text = whatLetter[SpawnController.numLetterBubble_1];
        if (numBubble == 2)
            TextBubble.GetComponent<TextMesh>().text = whatLetter[SpawnController.numLetterBubble_2];
        if (numBubble == 3)
            TextBubble.GetComponent<TextMesh>().text = whatLetter[SpawnController.numLetterBubble_3];
        if (numBubble == 4)
            TextBubble.GetComponent<TextMesh>().text = whatLetter[SpawnController.numLetterBubble_4];
        if (numBubble == 5)
            TextBubble.GetComponent<TextMesh>().text = whatLetter[SpawnController.numLetterBubble_5];

        // To do the bubble to fall vertically at the end
        if (largeY < transform.position.y)
            largeY = transform.position.y;
        else
        {
            if (speed < 1.15f)
                speed += 1 * Time.deltaTime;

            stopX = transform.position.x;
            stopX += speed * Time.deltaTime;
            transform.position = new Vector3(stopX, transform.position.y, transform.position.z);
        }

        // Destroy the bubble in the ground
        if (transform.position.y <= -4.0f)
        {
            anime.SetBool("burst", true);
            destroy = true;
        }

        // Destroy the bubble Clicked
        if (destroy)
        {
            if (audioTest)
            {
                audioBubble.PlayOneShot(soundBubbleBurst);
                audioTest = false;
            }
            timerDestroy += Time.deltaTime;
            if (timerDestroy > 0.15f)
            {
                if (!destroyAll)
                {
                    SpawnController.timePlay = true;
                    destroyAll = true;

                    // Do all the tests of pontuation and destruction of the bubbles
                    if (numBubble == 0)
                    {
                        if (SpawnController.numLetterBubble_0 == SpawnController.whatLetter)
                        {
                            if (transform.position.y <= -4.0f)
                            {
                                ScoreController.error++;
                                ScoreController.animateBad = true;
                            }
                            else
                            {
                                ScoreController.animate = true;
                                SpawnController.level++;
                                ScoreController.score++;
                                if (SpawnController.level >= 5)
                                {
                                    SpawnController.level = 0;
                                    ScoreController.round++;
                                    SpawnController.soundLetter = true;
                                    if (ScoreController.round >= 4)
                                        Application.LoadLevel("end_game");
                                }
                            }                     
                        }
                        else if (transform.position.y > -4.0f)
                        {
                            ScoreController.error++;
                            ScoreController.animateBad = true;
                        }
                        else
                        {
                            SpawnController.timePlay = false;
                            destroyAll = false;
                        }
                    }
                    else if (numBubble == 1)
                    {
                        if (SpawnController.numLetterBubble_1 == SpawnController.whatLetter)
                        {
                            if (transform.position.y <= -4.0f)
                            {
                                ScoreController.error++;
                                ScoreController.animateBad = true;
                            }
                            else
                            {
                                ScoreController.animate = true;
                                SpawnController.level++;
                                ScoreController.score++;
                                if (SpawnController.level >= 5)
                                {
                                    SpawnController.level = 0;
                                    ScoreController.round++;
                                    SpawnController.soundLetter = true;
                                    if (ScoreController.round >= 4)
                                        Application.LoadLevel("end_game");
                                }
                            }
                        }
                        else if (transform.position.y > -4.0f)
                        {
                            ScoreController.error++;
                            ScoreController.animateBad = true;
                        }
                        else
                        {
                            SpawnController.timePlay = false;
                            destroyAll = false;
                        }
                    }
                    else if (numBubble == 2)
                    {
                        if (SpawnController.numLetterBubble_2 == SpawnController.whatLetter)
                        {
                            if (transform.position.y <= -4.0f)
                            {
                                ScoreController.error++;
                                ScoreController.animateBad = true;
                            }
                            else
                            {
                                ScoreController.animate = true;
                                SpawnController.level++;
                                ScoreController.score++;
                                if (SpawnController.level >= 5)
                                {
                                    SpawnController.level = 0;
                                    ScoreController.round++;
                                    SpawnController.soundLetter = true;
                                    if (ScoreController.round >= 4)
                                        Application.LoadLevel("end_game");
                                }
                            }
                        }
                        else if (transform.position.y > -4.0f)
                        {
                            ScoreController.error++;
                            ScoreController.animateBad = true;
                        }
                        else
                        {
                            SpawnController.timePlay = false;
                            destroyAll = false;
                        }
                    }
                    else if (numBubble == 3)
                    {
                        if (SpawnController.numLetterBubble_3 == SpawnController.whatLetter)
                        {
                            if (transform.position.y <= -4.0f)
                            {
                                ScoreController.error++;
                                ScoreController.animateBad = true;
                            }
                            else
                            {
                                ScoreController.animate = true;
                                SpawnController.level++;
                                ScoreController.score++;
                                if (SpawnController.level >= 5)
                                {
                                    SpawnController.level = 0;
                                    ScoreController.round++;
                                    SpawnController.soundLetter = true;
                                    if (ScoreController.round >= 4)
                                        Application.LoadLevel("end_game");
                                }
                            }
                        }
                        else if (transform.position.y > -4.0f)
                        {
                            ScoreController.error++;
                            ScoreController.animateBad = true;
                        }
                        else
                        {
                            SpawnController.timePlay = false;
                            destroyAll = false;
                        }
                    }
                    else if (numBubble == 4)
                    {
                        if (SpawnController.numLetterBubble_4 == SpawnController.whatLetter)
                        {
                            if (transform.position.y <= -4.0f)
                            {
                                ScoreController.error++;
                                ScoreController.animateBad = true;
                            }
                            else
                            {
                                ScoreController.animate = true;
                                SpawnController.level++;
                                ScoreController.score++;
                                if (SpawnController.level >= 5)
                                {
                                    SpawnController.level = 0;
                                    ScoreController.round++;
                                    SpawnController.soundLetter = true;
                                    if (ScoreController.round >= 4)
                                        Application.LoadLevel("end_game");
                                }
                            }
                        }
                        else if (transform.position.y > -4.0f)
                        {
                            ScoreController.error++;
                            ScoreController.animateBad = true;
                        }
                        else
                        {
                            SpawnController.timePlay = false;
                            destroyAll = false;
                        }
                    }
                    else if (numBubble == 5)
                    {
                        if (SpawnController.numLetterBubble_5 == SpawnController.whatLetter)
                        {
                            if (transform.position.y <= -4.0f)
                            {
                                ScoreController.error++;
                                ScoreController.animateBad = true;
                            }
                            else
                            {
                                ScoreController.animate = true;
                                SpawnController.level++;
                                ScoreController.score++;
                                if (SpawnController.level >= 5)
                                {
                                    SpawnController.level = 0;
                                    ScoreController.round++;
                                    SpawnController.soundLetter = true;
                                    if (ScoreController.round >= 4)
                                        Application.LoadLevel("end_game");
                                }
                            }
                        }
                        else if(transform.position.y > -4.0f)
                        {
                            ScoreController.error++;
                            ScoreController.animateBad = true;
                        }
                        else
                        {
                            SpawnController.timePlay = false;
                            destroyAll = false;
                        }
                    }
                }
                Destroy(transform.gameObject);
            }
        }
        // Destroy every bubbles on screen
        if (destroyAll)
        {
            timerDestroy_0 += Time.deltaTime;
            if (timerDestroy_0 > 1.5f)
            {
                destroyBefore = true;
                timerDestroy_0 = 0;
            }
            if (destroyBefore)
            {
                if (audioTest)
                {
                    audioBubble.PlayOneShot(soundBubbleBurst);
                    audioTest = false;
                }
                anime.SetBool("burst", true);
                timerDestroy += Time.deltaTime;
                if (timerDestroy > 0.15f)
                {
                    destroyBefore = false;
                    Destroy(transform.gameObject);
                }
            }   
        }
    }
    // Destroy the Bubble on click
    void OnMouseDown()
    {
        anime.SetBool("burst", true);
        destroy = true;
    }
}
