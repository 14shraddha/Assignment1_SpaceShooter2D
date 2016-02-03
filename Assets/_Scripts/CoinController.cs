using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

    private Transform _transform;
    private Vector2 _currentPosition;
    public float speed = 5f;

    public float frontbound = -3194f;
    public float backbound = -3806f;
    public float upbound = 192f;
    public float downbound = -95f;

    // Use this for initialization
    void Start()
    {
        //make refrence to transform componnt in unity
        this._transform = gameObject.GetComponent<Transform>();

        // this._transform.position = new Vector2(0, 480f); // to create the position and always use vector to assign 

        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed,0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= backbound)
        {
            this.Reset();
        }
    }

    public void Reset()
    {
        float yPosition = Random.Range(downbound, upbound);
        this._transform.position = new Vector2(frontbound, yPosition);

    }
}

