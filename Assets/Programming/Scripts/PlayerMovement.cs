using UnityEngine;
using System.Collections;
using CnControls;

public class PlayerMovement : MonoBehaviour {

	public float XSpeed = 0;
	public float YSpeed = 50;
	Vector2 movement;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 axis = new Vector2(CnInputManager.GetAxis("Horizontal")*1.5f, CnInputManager.GetAxis("Vertical"));
		movement = new Vector2(XSpeed, YSpeed);
        transform.Translate ((axis*1.5f) + movement * Time.deltaTime);
		Debug.Log(CnInputManager.GetAxis("Horizontal"));
	}
}
