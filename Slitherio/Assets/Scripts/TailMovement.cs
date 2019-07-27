using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public int indx;

    public Vector3 tailTarget;
    public GameObject tailTargetObj;
    public SnakeMovement mainSnake;
    void Start()
    {
        mainSnake=GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovement>();
        speed = mainSnake.speed+1.5f;
        tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count-2];
        indx = mainSnake.tailObjects.IndexOf(gameObject);
    }
	void Update ()
    {
        tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime*speed);
	}

   
}
