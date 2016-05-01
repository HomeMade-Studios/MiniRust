using UnityEngine;
using System.Collections;

public class BulletsHandler : MonoBehaviour {

	public float speed;
	public Vector2 direction;
	float sin;
	float cos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Transform bullet in transform) {
			Vector2 inside= Camera.main.WorldToViewportPoint(bullet.position);
            if ((inside.x>1|| inside.x<0) || (inside.y > 1 || inside.y < 0)) {
				Destroy(bullet.gameObject);
			}
			float sin = Mathf.Sin(Mathf.Deg2Rad * bullet.rotation.eulerAngles.z);
			float cos = Mathf.Cos(Mathf.Deg2Rad * bullet.rotation.eulerAngles.z);
			direction = new Vector2(-sin, cos);
			bullet.Translate(direction * speed * Time.deltaTime, Space.World);
		}
	}
}
