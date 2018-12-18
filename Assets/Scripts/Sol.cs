using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental;

public class Sol : MonoBehaviour {

	private ProprietesSol proprietesSol;
	private string proprietesPlantes = "Propriétés de la plante";

	private GameObject Canvas;
	private GameObject InfoPanel;
	private GameObject InfosPlanteSolText;
	private GameObject market;

	private Text txt;
	private Sprite sprite;
	public GameObject[] allGameObjects;

	// Use this for initialization
	void Start () {
		proprietesSol = GetComponent<ProprietesSol>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		allGameObjects = FindObjectsOfType<GameObject>();

		foreach (GameObject go in allGameObjects){
			if(go.name == "infoPanelSol"){
				Destroy(go);
			}
		}

		market = GameObject.Find("marketPanel");

		if (market == null || !market.activeSelf){
			if (InfoPanel == null) {

				Canvas = GameObject.Find("UI");
				InfoPanel = new GameObject("Panel");

				InfoPanel.AddComponent<CanvasRenderer>();
				InfoPanel.name = "infoPanelSol";

				Image img = InfoPanel.AddComponent<Image>();
				sprite = Resources.Load("Sprites/cadre", typeof(Sprite)) as Sprite;
				img.sprite = sprite;

				InfoPanel.transform.SetParent(Canvas.transform);
				InfoPanel.transform.position = new Vector3(160f,0f,0f);
				InfoPanel.transform.localScale = new Vector3(1,1,0);
				RectTransform rt = InfoPanel.GetComponent<RectTransform>();
				rt.sizeDelta = new Vector2(300, 500);

				InfosPlanteSolText = new GameObject("Text");
				txt = InfosPlanteSolText.AddComponent<Text>() as Text;
				txt.font = Resources.Load<Font>("Fonts/films.bradybun");
				txt.fontSize = 20;
				txt.color = Color.black;
				InfosPlanteSolText.transform.SetParent(InfoPanel.transform);
				InfosPlanteSolText.transform.position = InfoPanel.transform.position;
				txt.text = "Propriétés du sol : " + "\n" + proprietesSol.stringify() + "\n" + "Propriétés de la plante : " + "\n" + proprietesPlantes;
				txt.transform.localPosition = new Vector3(-50,130,0);
				txt.verticalOverflow = VerticalWrapMode.Overflow;
				txt.horizontalOverflow = HorizontalWrapMode.Overflow;
				txt.transform.localScale = new Vector3(0.75f,0.75f,0f);
			}else {
					Destroy(InfoPanel);
			}
		}
}
}
