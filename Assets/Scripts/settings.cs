using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class settings : MonoBehaviour {

	public finderMovement fm;
	public Camera mainCamera;

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
        fm.pause = false;
	}

	public void recenter(){
		mainCamera.transform.position = new Vector3(5.96f, 1.0f, -10.0f);

		closeSettings();
	}
}
