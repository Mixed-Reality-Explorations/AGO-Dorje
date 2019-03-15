using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectsController : MonoBehaviour {

	public GameObject[] effects;
	public Text text;

	private int index = 0;

	void Start(){
		text.text = (index+1) + "/" + effects.Length;
	}

	public void next(){

		effects [index].SetActive (false);

		if (index == (effects.Length - 1)) {
			index = 0;
		} else {
			index++;
		}

		effects [index].SetActive (true);
		text.text = (index+1) + "/" + effects.Length;
	}

	public void previous(){

		effects [index].SetActive (false);

		if (index == 0) {
			index = effects.Length - 1;
		} else {
			index--;
		}

		effects [index].SetActive (true);
		text.text = (index+1) + "/" + effects.Length;
	}
}
