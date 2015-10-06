using UnityEngine;
using System.Collections;
/*
* Author: Chenyu Zhao
* Date last Modified: 2015-10-03
*/

public class DestoryByContact : MonoBehaviour {

    public GameObject exposion;
    public GameObject playerExposion;

    public int scoreValue;
    public int lifeValue;
    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("cannot find 'GameController' script");
        }
    }
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Boundary")
        {
            return;
        }
        if (other.tag == "Enemy")
        {
            return;
        }
        Instantiate(exposion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            Instantiate(playerExposion, other.transform.position, other.transform.rotation);
            gameController.GameOver();
        }
        gameController.AddScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
