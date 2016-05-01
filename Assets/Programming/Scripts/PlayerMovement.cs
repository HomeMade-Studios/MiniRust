using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float XSpeed = 0;
	public float YSpeed = 25;
	Vector2 movement;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		movement = new Vector2(XSpeed, YSpeed);
        transform.Translate (movement* Time.deltaTime);
	}
}
