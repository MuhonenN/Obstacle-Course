using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	float xValue = 0.01f;
	[SerializeField] float yValue = 0f;
	float zValue = 0f;
	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		transform.Translate(xValue, yValue, zValue);

	}
}
