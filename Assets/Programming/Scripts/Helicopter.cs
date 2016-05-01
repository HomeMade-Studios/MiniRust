using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {

	public GameObject bullet;
	public float cone;
	public int spawn;
	public Transform BulletContainer;
	float random;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		random = Random.Range (0, spawn - 1);
		if(random==0) {
			GameObject bull = (GameObject)Instantiate(bullet, transform.position, Quaternion.Euler(new Vector3(0, 0, Random.Range(-cone, cone))));
			bull.transform.SetParent(BulletContainer);
		}
	}
}
