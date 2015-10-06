using UnityEngine;
using System.Collections;

public class ObstacleGeneratorScript : MonoBehaviour {

    public GameObject ObstacleObject;

    private Vector3 ObstacleOffsetPoint;
    private int numObstacles = 100;
    private float spacerX = 1.1f;
    private float spacerY = 1.1f;

	// Use this for initialization
	void Start () {

        //Generate obstacles in a grid formation
        for (int i = 0; i < numObstacles; i++)
        {
            GameObject obj = Instantiate(ObstacleObject);

            if (i % 10 == 0)
            {
                //create a new column when 'x' grows past 10
                ObstacleOffsetPoint.x += spacerX;
            }

            //assign the position of the obstacle
            obj.transform.position = this.transform.position + ObstacleOffsetPoint + new Vector3(0, ((i % 10) * spacerY));

            //make the obstacle a child of the ObstracleGenerator object
            obj.transform.SetParent(this.transform);
        }
	}

    // Update is called once per frame
    void Update()
    {
	
	}
}
