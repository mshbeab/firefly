using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour {
	public float minSize = 1f;
	public float maxSize = 4f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (gameObject.transform.localScale);
		StartCoroutine("ChangeSize");
	}


	IEnumerator ChangeSize(){
		if (gameObject.transform.localScale.x < maxSize) {
			gameObject.transform.localScale = Vector3.Lerp(gameObject.transform.localScale,new Vector3(maxSize,maxSize,maxSize),Time.deltaTime);

		} else {
			gameObject.transform.localScale = Vector3.Lerp(gameObject.transform.localScale,new Vector3(minSize,minSize,minSize),Time.deltaTime);
		}
		yield return new WaitForEndOfFrame ();
	}
}
