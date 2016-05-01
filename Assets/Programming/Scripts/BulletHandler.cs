using UnityEngine;
using System.Collections;

public class BulletHandler : MonoBehaviour {

	public float speed;
	public Vector2 direction;
	float sin;
	float cos;
	

	// Use this for initialization
	void Start () {
		sin = Mathf.Sin(Mathf.Deg2Rad * transform.rotation.eulerAngles.z);
		cos = Mathf.Cos(Mathf.Deg2Rad * transform.rotation.eulerAngles.z);
		direction = new Vector2(sin, cos);
    }
	
	// Update is called once per frame
	void Update () {
		transform.Translate( direction*speed * Time.deltaTime);
		Debug.Log(direction * speed);
	}
}
