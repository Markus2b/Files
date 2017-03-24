using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	float speed = 2.0f;

	void Start () {
	
	}
	

	void Update () {
		transform.position += transform.forward * speed * Time.deltaTime;

	}
}
