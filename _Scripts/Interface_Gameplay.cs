using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Interface_Gameplay : MonoBehaviour {

    public Text Text_Score;
    public Text Text_TimeLimit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Text_Score.text = "Score Yea Sure!: " + GameManager.GameScore;
        Text_TimeLimit.text = "Remaining Time: " + (int)GameManager.GameRemainingTime;
	}
}
