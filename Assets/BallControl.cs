using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallControl : MonoBehaviour {

    Rigidbody rb;
    bool onPaddle=true;
    [SerializeField]
    Text Score;
    int count;
    public float speed=0;

    // Use this for initialization
    void Start () {
        count = 0;
        rb = GetComponent<Rigidbody>();
        Score.text = "Score: 0";
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetMouseButtonDown(0) && onPaddle)
        {
            rb.velocity = new Vector3(rb.velocity.x, speed,rb.velocity.z);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Collectable")
        {
            other.gameObject.SetActive(false);
            count += 1;
            Score.text = "Score: " + count;
        }
        if (other.gameObject.tag == "Obstacle")
        {
            Score.text = "Game Over!";
            Time.timeScale = 0;
        }
    }
}
