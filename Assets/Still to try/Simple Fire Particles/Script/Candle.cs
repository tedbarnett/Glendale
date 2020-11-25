using UnityEngine;
using System.Collections;

public class Candle : MonoBehaviour {
	public float amount = 5;
	Vector3 originalEulers;

	Vector3 newEulers;
	// Use this for initialization
	void Start () {
		originalEulers = transform.eulerAngles;

	}
	
	// Update is called once per frame
	void Update () {
		newEulers = originalEulers;
		newEulers.x = Random.Range(-amount,amount)+originalEulers.x;
		newEulers.z = Random.Range(-amount,amount)+originalEulers.z;
		transform.eulerAngles = newEulers+originalEulers;
		
	}
}
