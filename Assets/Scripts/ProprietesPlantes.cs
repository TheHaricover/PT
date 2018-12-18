using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProprietesPlantes : MonoBehaviour {

	public string typeSol;
	public int besoinEau;

	[Range(0.0f, 100.0f)]
	public float Acide = 0.0f;
	[Range(0.0f, 100.0f)]
	public float Azote = 0.0f;
	[Range(0.0f, 100.0f)]
	public float Phosphore = 0.0f;
	[Range(0.0f, 100.0f)]
	public float Potasse = 0.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	string stringify(){
		return "Type du sol : " + typeSol + "/n"
				 + "Besoin d'eau : " + besoinEau + "/n"
				 + "Acide : " + Acide + "/n"
				 + "Azote : " + Azote + "/n"
				 + "Phosphore : " + Phosphore + "/n"
				 + "Potasse : " + Potasse;
	}
}
