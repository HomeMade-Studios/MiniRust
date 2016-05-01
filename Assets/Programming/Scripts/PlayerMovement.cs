using UnityEngine;
using System.Collections;
using CnControls;

public class PlayerMovement : MonoBehaviour {

	public Vector2 speedOffset = new Vector2(0, 50);

	public float speed;

	void Start () {
	
	}
	
	void Update () {

		Vector2 axis = new Vector2(CnInputManager.GetAxis("Horizontal"), CnInputManager.GetAxis("Vertical"));
	
        transform.Translate (axis * speed * Time.deltaTime, Space.World);
		transform.Translate (speedOffset * Time.deltaTime, Space.World);

		Debug.Log(CnInputManager.GetAxis("Horizontal"));
	}
}
