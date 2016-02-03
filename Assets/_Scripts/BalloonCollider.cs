using UnityEngine;
using System.Collections;

public class BalloonCollider : MonoBehaviour {

    private AudioSource[] _audioSources;
    private AudioSource _coinSound;
    private AudioSource _birdSound;

    public GameController gameController;

    // Use this for initialization
    void Start()
    {

        //Initialize audio source array
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._coinSound = this._audioSources[2];
        this._birdSound = this._audioSources[1];

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D otherGameObject)
    {

        if (otherGameObject.gameObject.CompareTag("Coin"))
        {
            this._coinSound.Play();
            this.gameController.ScoreValue += 100;
        }
        if (otherGameObject.gameObject.CompareTag("Bird"))
        {
            this._birdSound.Play();
            this.gameController.LivesValue -= 1;
        }
    }
}
