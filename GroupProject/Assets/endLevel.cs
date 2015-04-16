using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class endLevel : MonoBehaviour {
	public GameObject nextLevel;
	float currentTime = 0.0f;
	// Use this for initialization
	void Start () {

		Text text = GetComponent<Text> ();
		text.text = "LEVEL COMPLETE!\n\nSCORE:\n\n" + theScore.score + "\n\nGet ready for the next level...";
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if (currentTime > 7) {
			GameObject level = Instantiate(nextLevel, new Vector3(635, 800, 49), Quaternion.identity) as GameObject;
			Timer.timeLeft = 120;
			IPspawn.loop = 0;
			Destroy (gameObject);
		}
	}
}
