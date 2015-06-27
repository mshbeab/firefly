using UnityEngine;
using System.Collections;

public class CloudMovement : MonoBehaviour
{

    private bool gameisRunning = false;
    private GameMaster _gameMaster;
    private Vector2 uvOffset = Vector2.zero;
    public float Cloudspeed = 0.01f;

    private void Awake()
    {
        _gameMaster = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
    }

	

	private void LateUpdate () 
    {
      


        //Game is running?
	    if (_gameMaster.GameIsRunning)
	    {
	        uvOffset += new Vector2(Cloudspeed*Time.deltaTime,0);
            this.transform.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", uvOffset);
	    }
	}
}
