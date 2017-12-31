using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class Dialogue1 : MonoBehaviour {

	public AudioSource _audio;
	public string inputText;
	// Use this for initialization
	void Start () {
		_audio = gameObject.GetComponent<AudioSource> ();
		StartCoroutine (DownloadTheAudio());

		Debug.Log ("Speech Audio Start");
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator DownloadTheAudio() {
		Regex rgx = new Regex ("\\s+");
		string result = rgx.Replace (inputText,"+");
		inputText = "Hello+This+Is+Augmedu+Please+Choose+A+Character";
		string url = "http://api.voicerss.org/?key=8e709a28eee14dbd85ddbcac32f60707&hl=en-gb&r=-4&f=24khz_16bit_mono&src="+inputText;
		WWW www = new WWW (url);
		yield return www;
		_audio.clip = www.GetAudioClip (false, true, AudioType.MPEG);
		_audio.Play ();
	}
}
