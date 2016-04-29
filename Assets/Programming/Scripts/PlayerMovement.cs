using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float XSpeed = 0;
	public float YSpeed = 25;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector2(XSpeed, YSpeed) * Time.deltaTime);
	}
}
