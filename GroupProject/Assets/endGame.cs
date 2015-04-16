using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class endGame : MonoBehaviour {

	float currentTime = 0.0f;

	// Use this for initialization
	void Start () {
		Text text = GetComponent<Text> ();
		text.text = "GAME COMPLETE!\n\nFINAL SCORE:\n\n" + theScore.score + "\n\nSee if you can do better next time!";
	
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if (currentTime > 7) {
			Application.LoadLevel ("Main Menu");
		}
	}
}
