using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour {
	public float minSize = 1f;
	public float maxSize = 4f;
	public float GrowingSpeed = 1f ;
	private bool growing ;
	private bool shrinking ;

	// Use this for initialization
	void Start () {
		growing = true;
	}
	
	// Update is called once per frame
	void Update () {

//		Debug.Log (gameObject.transform.localScale);
		if (growing) {
			StopCoroutine("Shrink");
			StartCoroutine ("Grow");
//			Debug.Log("growing");
		}else{
			StopCoroutine("Grow");
			StartCoroutine("Shrink");
//			Debug.Log("Shrinking");
		}
	}


	IEnumerator Grow(){
		float timeLerped = 0f;
		while (timeLerped < 1.0) {
			timeLerped += Time.deltaTime * GrowingSpeed  ;
			gameObject.transform.localScale = Vector3.Lerp (gameObject.transform.localScale, new Vector3 (maxSize, maxSize, maxSize), timeLerped);

			yield return null;
		}
		growing = false ;
		shrinking = true ;

	}

	IEnumerator Shrink(){
		float timeLerped = 0f;
		while (timeLerped < 1.0) {
			timeLerped += Time.deltaTime * GrowingSpeed  ;
			gameObject.transform.localScale = Vector3.Lerp (gameObject.transform.localScale, new Vector3 (minSize, minSize, minSize), timeLerped);
			yield return null ;
		}
		growing = true ;
		shrinking = false ;



	}
}
