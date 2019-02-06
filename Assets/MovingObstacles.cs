using UnityEngine;
using System.Collections;

public class MovingObstacles : MonoBehaviour {

    public float moveSpeed=5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
	}
}
