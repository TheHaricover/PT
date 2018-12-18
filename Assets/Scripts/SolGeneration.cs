using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolGeneration : MonoBehaviour {

	public GameObject Sol;
	public GameObject Terrain;
	private GameObject InfoPanel;

	public int seed = 0;
	int nbSols = 100;
	int nbLignes = 25;
	int nbColonnes = 25;

	List<List<float>> waterList = new List<List<float>>();
	List<List<float>> fertilizerList = new List<List<float>>();

	// Use this for initialization
	void Start () {

		genSoils ();

		//Instantiation et positionnement des sols sur la scene.
		for (int i = 0;i<=nbLignes; i++){
			for (int j = 0; j<=nbColonnes; j++){
				GameObject sol = Instantiate(Sol);
				sol.transform.SetParent (Terrain.transform);
				sol.transform.position = new Vector3((-10+i)*0.5f,0.0f,(-6+j)*0.5f);
				sol.GetComponent<ProprietesSol> ().eau = waterList[i][j];
				sol.GetComponent<ProprietesSol> ().matiereOrganique = fertilizerList[i][j];
				sol.GetComponent<Renderer>().material.color = new Color(1.0f * waterList[i][j], 1.0f, 1.0f * fertilizerList[i][j]);
				sol.SetActive(true);
			}
		}

		//Sol.SetActive(false);
		//Debug.Log(nbLignes*nbColonnes);

		/*InfoPanel = GameObject.Find("InfosPlanteSol");
		if (InfoPanel.activeSelf){
			InfoPanel.gameObject.SetActive(false);
		}*/
	}

	void genSoils () {
		//Instantiation de la graine aléatoire.
		if (seed == 0) {
			seed = Random.Range (0, 100);
		}
		//Remplit les listes waterList et fertilizerList en appliquant un bruit aléatoire.
		for (int i = 0; i <= nbLignes; i++) {
			waterList.Add(new List<float>());
			fertilizerList.Add(new List<float>());
			for (int j = 0; j <= nbColonnes; j++) {
				float randWater = Random.value;
				waterList[i].Add(randWater);
				float randFertilizer = Random.value;
				fertilizerList[i].Add(randFertilizer);
			}
		}
		for (int i = 0; i < 3; i++) {
			smoothProperties ();
		}

	}

	void smoothProperties() {
		//Adoucit le bruit dans les listes waterList et fertilizerList (sauf bords des listes).
		//On calcule la moyenne de la case courrante et ses cases voisines.
		for (int i = 1; i < nbLignes; i++) {
			for (int j = 1; j < nbColonnes; j++) {
				waterList [i] [j] = (waterList [i] [j] + waterList [i - 1] [j] + waterList [i + 1] [j] + waterList [i] [j - 1] + waterList [i] [j + 1]) / 5.0f;
				fertilizerList [i] [j] = (fertilizerList [i] [j] + fertilizerList [i - 1] [j] + fertilizerList [i + 1] [j] + fertilizerList [i] [j - 1] + fertilizerList [i] [j + 1]) / 5.0f;
			}
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
