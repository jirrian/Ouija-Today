using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start : MonoBehaviour {

    void Start(){
        foreach(Transform elem in transform){
            StartCoroutine(fadeInText(elem.GetComponent<Text>()));
        }
    }

	// fade text away and load next scene
	public void loadGame(){
		// fade out text
		foreach(Transform elem in transform){
			StartCoroutine(fadeOutText(elem.GetComponent<Text>()));
		}
	}

	// fade out text
	IEnumerator fadeOutText(Text text){
       float f = 1f;
       while(f >= 0f) {
            Color c = text.color;
            c.a = f;
            text.color = c;
            f -= 0.1f;
            yield return new WaitForSeconds(.1f);
        }
        text.enabled = false;

        //load scene
		SceneManager.LoadScene("Game");
     }

    // fade in text
    IEnumerator fadeInText(Text text){
       float f = 0f;
       while(f < 1f) {
            Color c = text.color;
            c.a = f;
            text.color = c;
            f += 0.1f;
            yield return new WaitForSeconds(.1f);
        }
        text.enabled = true;

     }

}
