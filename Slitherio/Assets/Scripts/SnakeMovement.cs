using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeMovement : MonoBehaviour 
{
    public float speed;
    public float rotationSpeed;
    public float z_offset = 0.7f;
    public List<GameObject> tailObjects = new List<GameObject>();
    public GameObject TailPrefab;
    public Text ScoreText;
    public int score = 0;

	// Use this for initialization
	void Start ()
    {
        tailObjects.Add(gameObject);
	}
	
	// Update is called once per frame
	void Update () 
    {
        ScoreText.text = score.ToString();
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if(Input.GetKey("right"))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(Vector3.up*-1 * rotationSpeed * Time.deltaTime);
        }
	}

    public void AddTail()
    {
        score++;
        Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
        newTailPos.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab,newTailPos, Quaternion.identity) as GameObject);
    }
}
