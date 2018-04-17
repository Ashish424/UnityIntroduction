using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {



	private Script2 sc;
	// Use this for initialization
	void Start () {
		sc = GetComponent<Script2>();
		sc.helloFromScript2();

		var gr = GameObject.Find("ground");

		if(gr!=null){
			Debug.Log("found game object");
		}
		else{
			Debug.Log("not found");
		}

		Transform cubeTrans = transform.Find("Cube");
		if(cubeTrans!=null){
			Debug.Log("cube is not null " +cubeTrans.gameObject.name);

		}

	


		
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log(this.gameObject.name);



		if(Input.GetKey(KeyCode.UpArrow)){
			transform.position += new Vector3(0,1,0);
		}


		if(Input.GetKey(KeyCode.DownArrow)){
			transform.position += new Vector3(0,-1,0);
		}


		if(Input.GetKey(KeyCode.RightArrow)){
			transform.position += new Vector3(1,0,0);
		}


		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.position += new Vector3(-1,0,0);
		}




		
	}
}
