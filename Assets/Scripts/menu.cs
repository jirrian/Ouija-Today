using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class menu : MonoBehaviour {

	public Button menuTrigger;
    public Canvas popUpCanvas;

    public finderMovement fm;

	// Use this for initialization
	void Start () {
		StartCoroutine(fadeOutBlack(menuTrigger));
	   
	}

    // fade from black
	IEnumerator fadeOutBlack(Button sprite){
       float f = 1f;
       while(f >= 0f) {
            f -= 0.1f;
            Color color = sprite.transform.GetComponent<Image>().color;
            color.a = f;
            sprite.transform.GetComponent<Image>().color = color;
            
            yield return new WaitForSeconds(.1f);
        }

        menuTrigger.GetComponent<Button>().interactable = true;
    }

    // on click event when screen is tapped anywhere
    public void spawnMenu(){
        // show pop up
        popUpCanvas.GetComponent<Canvas>().enabled = true;

        // stop camera/planchette movement
        fm.pause = true;

    }
}
