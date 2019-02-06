using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour {


    public float speed = 10.0f;
    Rigidbody rb;
    public Text Score;
   
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "GroundOb")
        {
            Score.text = "Game Over!";
            Time.timeScale = 0;
        }
    }
}
