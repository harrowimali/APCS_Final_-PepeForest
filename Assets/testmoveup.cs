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
		transform.position += new Vector3 (0f, 0.1f, 0f);
		Application.LoadLevel ("demoScene_free");
		
	}
}
