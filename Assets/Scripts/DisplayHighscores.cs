using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayHighscores : MonoBehaviour {

	public Text[] highscoreFields;
	Highscores highscoresManager;
	public int n = 0;

	void Start() {
		//for (int i = 0; i < highscoreFields.Length; i ++) {
		//	highscoreFields[i].text = i+1 + ". Fetching...";
		//}


		highscoresManager = GetComponent<Highscores>();
		StartCoroutine("RefreshHighscores");
	}

	public void OnHighscoresDownloaded(Highscore[] highscoreList) {
		for (int i = (highscoreList.Length - 1); i >= 0; i--) {
			highscoreFields[i].text = i + 1 + ". ";
			if (n < highscoreFields.Length) {
				print (i + ": " + highscoreFields.Length );
				highscoreFields[i].text += highscoreList[n].username + " - " + highscoreList[n].score;
				n++;
			}
		}
	}

	IEnumerator RefreshHighscores() {
		while (true) {
			highscoresManager.DownloadHighscores();
			yield return new WaitForSeconds(30);
		}
	}
}