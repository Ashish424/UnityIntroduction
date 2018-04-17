using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour {


	public void helloFromScript2(){
		Debug.Log("hello");
	}
	private HelloWorld hello;
	// Use this for initialization
	void Start () {
		hello = GetComponent<HelloWorld>();


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
