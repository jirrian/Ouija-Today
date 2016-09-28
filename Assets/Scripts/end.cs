using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour {

	public Button menuTrigger;
	public Text goodbye;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// end game
	void OnTriggerEnter(Collider planchette) {
        StartCoroutine(fadeToBlack(menuTrigger));
    }

    // fade to black
	IEnumerator fadeToBlack(Button sprite){

		menuTrigger.GetComponent<Button>().interactable = false;
       float f = 0f;
       while(f < 1f) {
            f += 0.1f;
            Color color = sprite.transform.GetComponent<Image>().color;
            color.a = f;
            sprite.transform.GetComponent<Image>().color = color;
            
            yield return new WaitForSeconds(.1f);
        }
        goodbye.enabled = true;

        yield return new WaitForSeconds(5f);

        //load scene
		SceneManager.LoadScene("Start");
        
    }

}
