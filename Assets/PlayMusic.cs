using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour {

	public AudioSource backgroundNoise;
	public AudioSource musicToPlay;

	bool oneClick = false;
	float timerClick1;
	float timerClick2;

	float delay=1;
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) {

			// if first click
			if (!oneClick) {
				oneClick = true;
				timerClick1 = Time.time;
			} 

			// else if second click
			else {
				oneClick = false;
				timerClick2 = Time.time;

				// if time from last click is greater than delay consider it the first click
				if (timerClick2 - timerClick1 > delay) {
					oneClick = true;
					timerClick1 = Time.time;
				} 
				// else consider is double click
				else {
					Debug.Log ("Double clicked");

					// if music isn't play it then start it
					if (!musicToPlay.isPlaying) {
						backgroundNoise.Pause ();
						musicToPlay.Play ();
					} 
					// else stop it
					else {
						backgroundNoise.UnPause ();
						musicToPlay.Stop ();
					}
				}

			}
		}
	}
}
