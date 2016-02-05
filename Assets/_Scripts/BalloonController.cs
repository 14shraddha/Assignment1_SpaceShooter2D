//BalloonController

/*  Developed by Shraddhaben Patel 300821026
    Last Modified by Shraddhaben Patel
    Last Modified Date: Feb 4,2016
    This file is used for the balloon colision detection and do the necessary function */


using UnityEngine;
using System.Collections;

public class BalloonController : MonoBehaviour {

    //Private Instances
    private float _playerInput;
    private Transform _transform;
    private Vector2 _currentPosition;

    //public Instances
    public float speed = 5;

    // Use this for initialization
    void Start()
    {
        //small gameobject refers to the componennt attached to
        this._transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;

        //to fetch the y position of the balloon
        this._playerInput = Input.GetAxis("Vertical");
        //Positive movement move up
        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(0, this.speed);

        }
        //Negative movement move downs
        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(0, this.speed);
        }
        this._checkBounds();
    }
    //***************PRIVATE METHODS******************************************************************
    private void _checkBounds()
    {
        //checked if the plane goes out of boundary and keep it inside
        if (this._currentPosition.y <-77)
        {
            this._currentPosition.y = -77;
        }
        if (this._currentPosition.y > 177)
        {
            this._currentPosition.y= 177;
        }

        this._transform.position = this._currentPosition;
    }


}
