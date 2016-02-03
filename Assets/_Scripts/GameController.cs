using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    //Public instance
    public int birdNumber = 3;
    public BirdController bird;


    // Use this for initialization
    void Start () {
        this._intitialize();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    private void _intitialize()
    {
        //this._scoreValue = 0;
        //this._livesValue = 5;

        for (int birdCount = 0; birdCount < this.birdNumber; birdCount++)
        {
            Instantiate(bird.gameObject);
        }
    }
}
