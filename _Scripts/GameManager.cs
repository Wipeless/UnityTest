using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static int GameScore = 0;
    public static float GameRemainingTime;

    private int maxPoints = 100;
    private int timeLimit = 30;     //in seconds

	// Use this for initialization
	void Start () {
        GameRemainingTime = timeLimit;
	}
	
	// Update is called once per frame
	void Update () {

        //check current score
        if (GameScore > maxPoints)
        {
            ResetScene(); 
        }

        //check time limit
        GameRemainingTime = timeLimit - Time.timeSinceLevelLoad;
        if (GameRemainingTime <= 0)
        {
            ResetScene();
        }

	}

    private void ResetScene()
    {
        GameRemainingTime = timeLimit;
        GameScore = 0;
        Application.LoadLevel(0);
    }
}
