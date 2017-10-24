using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    public float flyPower;

    public AudioClip flyClip;
    public AudioClip gameOverClip;

    private AudioSource audioSource;

    GameObject obj;
    GameObject gameController;
	// Use this for initialization
	void Start () {
        flyPower = 15;
        obj = gameObject;
        if ( gameController == null )
        {
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }

        audioSource = obj.GetComponent<AudioSource>();
        audioSource.clip = flyClip;
		
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetMouseButton(0))
        {
            if (gameController.GetComponent<GameController>().isEndGame == false)
            {
                Debug.Log("Fly");
                audioSource.Play();
                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
            }
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        gameController.GetComponent<GameController>().GetPoint();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        EndGame();
        audioSource.clip = gameOverClip;
        audioSource.Play();
    }

    void EndGame()
    {
        gameController.GetComponent<GameController>().EndGame();
    }
}
