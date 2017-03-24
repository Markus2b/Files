using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Valve.VR.InteractionSystem;


public class ValueFollow : MonoBehaviour {

	public LinearMapping linearMapping;
	public Slider slider;


	void Update () {
		slider.value = linearMapping.value;
	}
}
