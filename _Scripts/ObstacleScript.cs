using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {

    private bool isAlreadyTouched = false;

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && isAlreadyTouched == false)
        {
            //only increment points if this obstacle hasn't been touched yet
            GameManager.GameScore++;
            isAlreadyTouched = true;

            //change the obstacle's color
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
