using UnityEngine;
using System.Collections;

public class IPspawn : MonoBehaviour {

	string[] ipAddresses = new string[100];
	string[] fileSize = new string[20];
	string[] origin = new string[20];
	string[] fileType = new string[20];
	public GameObject endLevel1;
	public GameObject endLevel2;
	public GameObject endLevel3;
	public GameObject endLevel4;
	int levelCount = 0;
	public static int loop = 0;
	// Use this for initialization
	void Start () {
		// this is messy but it wouldn't let me delcare it normally up there ^
		// as in string[] array = new string{ "blah", "blah", blah" };
		// it kept throwing errors that make no sense
		// feel free to try again
		fileSize [0] = "156kB"; fileSize [1] = "756kB"; fileSize [2] = "645kB"; fileSize [3] = "134kB"; fileSize [4] = "317kB"; fileSize [5] = "498kB"; fileSize [6] = "401kB"; fileSize [7] = "320kB"; fileSize [8] = "569kB"; fileSize [9] = "731kB"; fileSize [10] = "351kB"; fileSize [11] = "368kB"; fileSize [12] = "479kB"; fileSize [13] = "428kB"; fileSize [14] = "600kB"; fileSize [15] = "641kB"; fileSize [16] = "527kB"; fileSize [17] = "264mB"; fileSize [18] = "480mB"; fileSize [19] = "398mB";
		origin [0] = "Luxembourg"; origin [1] = "Minsk"; origin [2] = "Mexico City"; origin [3] = "Monaco"; origin [4] = "Ottawa"; origin [5] = "Athens"; origin [6] = "Bern"; origin [7] = "Calcutta"; origin [8] = "Mumbai"; origin [9] = "Adelaide"; origin [10] = "Tokyo"; origin [11] = "Beijing"; origin [12] = "Berlin"; origin [13] = "Paris"; origin [14] = "Chicago"; origin [15] = "New York"; origin [16] = "London"; origin [17] = "Pyongyang"; origin [18] = "Dodgy Place"; origin [19] = "Sesame Street"; 
		fileType [0] = "Text"; fileType [1] = "PNG"; fileType [2] = "JPEG"; fileType [3] = "GIF"; fileType [4] = "MP3"; fileType [5] = "FLV"; fileType [6] = "CS"; fileType [7] = "WAV"; fileType [8] = "APK"; fileType [9] = "ZIP"; fileType [10] = "ISO"; fileType [11] = "EXE"; fileType [12] = "PDF"; fileType [13] = "PUB"; fileType [14] = "VCD"; fileType [15] = "SQL"; fileType [16] = "IMAGE"; fileType [17] = "D64"; fileType [18] = "DPI"; fileType [19] = "Not Suspicious";

		string address = "";
		for (int i = 0; i < 100; i++) {
			for (int x = 0; x < 4; x++) {
				int three = Random.Range(0, 1000);
				string threeGroup = three.ToString();
				if (three < 100 && three >= 10) {
					threeGroup = threeGroup + "0";
				}
				else if (three < 10) {
					threeGroup = threeGroup + "00";
				}
				if (x < 3) {
					address = address + threeGroup + ".";
				}
				else {
					address = address + threeGroup;;
				}
			}
			ipAddresses[i] = address;
			address = "";
		}

	}

	void Remake () {
		string address = "";
		for (int i = 0; i < 100; i++) {
			for (int x = 0; x < 4; x++) {
				int three = Random.Range(0, 1000);
				string threeGroup = three.ToString();
				if (three < 100 && three >= 10) {
					threeGroup = threeGroup + "0";
				}
				else if (three < 10) {
					threeGroup = threeGroup + "00";
				}
				if (x < 3) {
					address = address + threeGroup + ".";
				}
				else {
					address = address + threeGroup;;
				}
			}
			ipAddresses[i] = address;
			address = "";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Timer.timeLeft <= 0 && loop == 0) {
		levelCount++;
		loop++;
		switch(levelCount){
			case 1:
				GameObject text = Instantiate(endLevel1, new Vector3(380, 400, 50), Quaternion.identity) as GameObject;
				text.transform.parent = GameObject.Find("Canvas").transform;
				break;
			case 2:
				GameObject text2 = Instantiate(endLevel2, new Vector3(380, 400, 50), Quaternion.identity) as GameObject;
				text2.transform.parent = GameObject.Find("Canvas").transform;
				break;
			case 3:
				GameObject text3 = Instantiate(endLevel4, new Vector3(380, 400, 50), Quaternion.identity) as GameObject;
				text3.transform.parent = GameObject.Find("Canvas").transform;
				break;
			case 4:
				GameObject text4 = Instantiate(endLevel4, new Vector3(400, 400, 50), Quaternion.identity) as GameObject;
				text4.transform.parent = GameObject.Find("Canvas").transform;
				break;

			default:
				break;
		}
		Remake ();
	}

	}

	public string get(int rand, int array){
		switch (array) {
		case 1:
			return ipAddresses[rand];
			break;
		case 2:
			return fileSize[rand];
			break;
		case 3:
			return origin[rand];
			break;
		case 4:
			return fileType[rand];
			break;

		default:
			return ipAddresses[rand];
			break;
		}
	}
}
