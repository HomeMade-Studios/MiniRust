using UnityEngine;
using System.Collections;
using CnControls;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour { 

	public Vector2 speedOffset = new Vector2(0, 50);

	public float speed;
	int collisions = 0;
	public Text debug;

	void Start () {
		
	}
	
	void Update () {

		Vector2 axis = new Vector2(CnInputManager.GetAxis("Horizontal"), CnInputManager.GetAxis("Vertical"));
	
        transform.Translate (axis * speed * Time.deltaTime, Space.World);
		transform.Translate (speedOffset * Time.deltaTime, Space.World);

		//Debug.Log(axis);
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("Cose");
		if (collision.gameObject.tag=="Bullet") {
			collisions++;
			debug.text = "Collision: " + collisions;
        }
	}
}
