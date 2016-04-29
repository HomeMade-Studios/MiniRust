using UnityEngine;
using System.Collections;

public class BackManagement : MonoBehaviour {

	public float limit = 32;
	public Vector2 pos;
	public Object prefab;

	// Use this for initialization
	void Start () {
		transform.position = new Vector2(0, limit * 2);
		transform.SetParent(transform.parent);
	}
	
	// Update is called once per frame
	void Update () {
		pos = transform.position;
		if (pos.y < -limit) {
			GameObject obj=(GameObject)Instantiate(prefab);
			///obj.transform.SetParent(transform.parent);
			Destroy(this.gameObject);
		}
	}
}
