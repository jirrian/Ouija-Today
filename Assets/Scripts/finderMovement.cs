using UnityEngine;
using System.Collections;

public class finderMovement : MonoBehaviour {

	public bool pause;

	// Use this for initialization
	void Start () {
		pause = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(!pause){
			// move camera/planchette with screen tilt
			transform.Translate(Input.acceleration.x * 0.3f, Input.acceleration.y * 0.3f, 0);
		}
	}
}
