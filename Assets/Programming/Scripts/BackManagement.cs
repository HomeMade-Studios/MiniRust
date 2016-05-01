using UnityEngine;
using System.Collections;

public class BackManagement : MonoBehaviour {

	public int limit = 512;
	public Vector2 pos;
	public Object prefab;

	// Use this for initialization
	void Start () {
		//transform.position = new Vector2(transform.position.x, Mathf.Round(transform.position.y));
		int yPos = Mathf.FloorToInt(transform.localPosition.y / 512) * 512;
        transform.localPosition = new Vector2(transform.localPosition.x, yPos);
		this.name = "Background_" + ((transform.localPosition.y / 512));
	}

	// Update is called once per frame
	void FixedUpdate () {
		pos = transform.position;
		if (pos.y < -limit) {
			GameObject obj=(GameObject)Instantiate(this.gameObject,new Vector3(0, limit * 2, 0),Quaternion.identity);
			obj.transform.parent=transform.parent;
			obj.transform.position =new Vector2(0, Mathf.Round(limit * 2));
			Destroy(this.gameObject);
		}
	}
}
