using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class theScore : MonoBehaviour {

	public static int score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Text text = GetComponent<Text> ();

		if (Timer.timeLeft <= 0) {
			text.text = "";
		} else {
			text.text = "Score:\n\n" + score.ToString();
		}

	}
}
