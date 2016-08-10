using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class settings : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void closeSettings(){
		// hide pop up canvas
		transform.GetComponent<Canvas>().enabled = false;

		// allow camera/planchette movement
	}
}
