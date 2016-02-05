//BirdController
/*  Developed by Shraddhaben Patel 300821026
    Last Modified by Shraddhaben Patel
    Last Modified Date: Feb 4,2016
    Birdcontroller is the script that is used for the Birds(Enemy) in tha game.
    here the code for the random position of the birds are provided*/

using UnityEngine;
using System.Collections;

public class BirdController : MonoBehaviour {


    // PRIVATE INSTANCES
    private Transform _transform;
    private Vector2 _currentPosition;
    private float frontbound = Random.Range(-3195f,-3000f); // to start the bird entry in game through random positions
    private float backbound = -3811f;
    private float upbound = 194f;
    private float downbound = -84f;
    private float _horizontalSpeed;
    private float _verticalDrift;


    //PUBLIC INSTANCES
    public float minHspeed = 4f;
    public float maxHspeed = 7f;
    public float minVspeed = -1f;
    public float maxVspeed = 1f;



    // Use this for initialization
    void Start()
    {
        //make refrence to transform componnt in unity
        this._transform = gameObject.GetComponent<Transform>();
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._horizontalSpeed, this._verticalDrift); 
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= backbound)
        {
            this.Reset();
        }
    }


    // PUBLIC METHODS
    public void Reset()
    {

        this._horizontalSpeed = Random.Range(this.minHspeed, this.maxHspeed);
        this._verticalDrift = Random.Range(this.maxVspeed, this.minVspeed);

        float yPosition = Random.Range(downbound, upbound);
        this._transform.position = new Vector2(frontbound, yPosition);// to create the position randomlu

    }
}

