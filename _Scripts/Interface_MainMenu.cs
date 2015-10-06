using UnityEngine;
using System.Collections;

public class Interface_MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GoToGameplay()
    {
        Application.LoadLevel(1);
    }
}
