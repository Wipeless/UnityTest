using UnityEngine;
using System.Collections;

public class CameraOrbit : MonoBehaviour {

    public Transform TargetTransform;
    public float OrbitSpeed = 0.25f;
    public float OrbitRadius = 10f;

    private Vector3 startingPosition;

	// Use this for initialization
	void Start () {
        startingPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = startingPosition + new Vector3(Mathf.Sin(Time.time * OrbitSpeed) * OrbitRadius, 0, Mathf.Cos(Time.time * OrbitSpeed) * OrbitRadius);
        this.transform.LookAt(TargetTransform);
    }
}
