using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	// public Material[] myMaterials;
	public Material mat1;
	public Material mat2;
	public Material mat3;
	Renderer rend;
	public float period = 0.0f;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = mat1;
	}
	
	// Update is called once per frame
	void Update () {
		if (period < 10) {
			rend.sharedMaterial = mat1;
		} else if (period > 10 && period < 20) {
			rend.sharedMaterial = mat3;
		} else if (period > 20 && period < 30) {
			rend.sharedMaterial = mat2;
		} else if (period > 30) {
			period = 0;
		}
		period += UnityEngine.Time.deltaTime;
	}
}
