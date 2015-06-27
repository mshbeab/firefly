using UnityEngine;
using System.Collections;

public class HoverAnimation : MonoBehaviour {

	private Animator starAnimator;
	// Use this for initialization
	void Start () {
	
		starAnimator = GetComponent<Animator> ();

	}
	
 

	private void OnMouseEnter()
	{

        starAnimator.SetBool("MouseIsHovering", true);
        //Debug.Log("Star Animation begins");
	}

    private void OnMouse()
    {

        starAnimator.SetBool("MouseIsHovering", true);
    }



    private void OnMouseExit()
    {

        starAnimator.SetBool("MouseIsHovering", false);
    }


}
