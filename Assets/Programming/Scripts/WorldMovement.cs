using UnityEngine;
using System.Collections;

public class WorldMovement : MonoBehaviour {

	public float WorldSpeed = 25;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector2(0, -WorldSpeed) * Time.deltaTime);
	}
}
