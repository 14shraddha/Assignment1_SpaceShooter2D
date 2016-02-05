//Balloon Collider
/*  Developed by Shraddhaben Patel 300821026
    Last Modified by Shraddhaben Patel
    Last Modified Date: Feb 4,2016
    This file is used for the balloon colision detection and do the necessary function */

using UnityEngine;
using System.Collections;

public class BalloonCollider : MonoBehaviour {


    //PRIVATE INSTANCES
    private AudioSource[] _audioSources;
    private AudioSource _coinSound;
    private AudioSource _birdSound;

    //PUBLIC INSTANCES
    public GameController gameController;

    // Use this for initialization
    void Start()
    {
        //Initialize audio source array
        this._audioSources = gameObject.GetComponents<AudioSource>();

        //ARRAY OF SOUND - SO IT IS ALLOCATED TO THE SPECIFIC ASSET AS SHOWN IN INSPECTOR
        this._birdSound = this._audioSources[1];
        this._coinSound = this._audioSources[2];
    }

    // Update is called once per frame
    void Update()
    {

    }


    //PUBLIC METHODS
    public void OnTriggerEnter2D(Collider2D otherGameObject)
    {

        if (otherGameObject.gameObject.CompareTag("Coin"))
        {
            this._coinSound.Play();    // To play the coin sound when ballon collides with the coin
            this.gameController.ScoreValue += 100; // to increase the score of balloon by 100 
        }
        if (otherGameObject.gameObject.CompareTag("Bird"))
        {
            this._birdSound.Play();    // To play the hit and hurt sound when ballon collides with the birds
            this.gameController.LivesValue -= 1;  // To decrease the life of ballon by 1 when hit by bird
        }
    }
}
