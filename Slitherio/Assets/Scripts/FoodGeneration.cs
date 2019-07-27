using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour 
{

    public GameObject foodPrefab;
    public GameObject curFood;

    public float XSize = 8;
    public float ZSize = 8;

    private Vector3 curPos;
	// Use this for initialization
	void AddNewFood () 
    {
        RandomPosition();
		curFood=GameObject.Instantiate(foodPrefab,curPos,Quaternion.identity) as GameObject;
	}

    void RandomPosition()
    {
        curPos=new Vector3(Random.Range(-1*XSize,XSize),0.5f,Random.Range(-1*ZSize,ZSize));
    }
	// Update is called once per frame
	void Update ()
    {
        if (!curFood)
        {
            AddNewFood();
        }
        else
            return;
	}
}
