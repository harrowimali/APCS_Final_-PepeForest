using UnityEngine;
using System.Collections;

public class testmoveup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void moveup(){
		transform.position += new Vector3 (0f, 0f, 2f);
		transform.position += new Vector3 (0f, 0f, -2f);

		transform.position += new Vector3 (0f, 0f, 1f);
		transform.position += new Vector3 (0f, 0f, -1f);

		transform.position += new Vector3 (0f, 0f, 1f);
		transform.position += new Vector3 (0f, 0f, -1f);

		transform.position += new Vector3 (0f, 0f, 1f);
		transform.position += new Vector3 (0f, 0f, -1f);
	
		forest();
	}

	public void forest(){
		Application.LoadLevel ("demoScene_free");
	}
}
