using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public float Speed = 1f;


	private Rigidbody2D player;



	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		GameObject star = null;
		bool playerMoving = false; 


		if (hit.collider != null) {
			// Animate Star to show mouse hover
			if (hit.collider.gameObject.tag == "Star") {
				star = hit.collider.gameObject;
				star.transform.localScale = new Vector3 (2f, 2f, 2f);
			}
			if(Input.GetMouseButtonDown(0)){
				playerMoving = true ; 
				StartCoroutine("MovePlayer",star);
			}


		} else {
			// Rest the Stars to normal state
//			GameObject[] Stars  = GameObject.FindGameObjectsWithTag("Star");
//			foreach(GameObject s in Stars){
//				s.transform.localScale = new Vector3(1f,1f,1f);
//			}
		}
	}

	IEnumerator MovePlayer(GameObject star){
		float timeLerped = 0f;
		while(timeLerped < 1.0) {
			timeLerped += Time.deltaTime * Speed ;
			transform.position = Vector2.Lerp(player.transform.position, star.transform.position, timeLerped );
			yield return new WaitForEndOfFrame ();
		}
	}
}
