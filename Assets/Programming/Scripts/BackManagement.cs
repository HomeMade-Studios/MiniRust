using UnityEngine;
using System.Collections;

public class BackManagement : MonoBehaviour {

	public int limit = 512;
	public Vector2 pos;
	public Object prefab;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		pos = transform.position;
		if (pos.y < -limit) {
			GameObject obj=(GameObject)Instantiate(prefab,new Vector3(0, limit * 2, 0),Quaternion.Euler(Vector3.zero));
			obj.transform.SetParent(transform.parent);
			obj.transform.position =new Vector2(0, Mathf.Round(limit * 2));
			Destroy(this.gameObject);
		}
	}
}
