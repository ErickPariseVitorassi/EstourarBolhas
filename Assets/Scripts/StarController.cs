using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {

    public GameObject star0;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    // Use this for initialization
    void Start () {
		if (ScoreController.score < 5 || ScoreController.error > 15)
            star0.transform.position = new Vector3(star0.transform.position.x, star0.transform.position.y, star0.transform.position.z - 5);
        else if (ScoreController.score > 4 && ScoreController.score < 10 || ScoreController.error > 10)
            star1.transform.position = new Vector3(star1.transform.position.x, star1.transform.position.y, star1.transform.position.z - 5);
        else if (ScoreController.score > 9 && ScoreController.score < 13 || ScoreController.error > 5)
            star2.transform.position = new Vector3(star2.transform.position.x, star2.transform.position.y, star2.transform.position.z - 5);
        else
            star3.transform.position = new Vector3(star3.transform.position.x, star3.transform.position.y, star3.transform.position.z - 5);
    }
}
