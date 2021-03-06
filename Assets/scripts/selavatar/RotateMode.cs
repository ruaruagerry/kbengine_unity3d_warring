using UnityEngine;  
using System.Collections;  
  
public class RotateMode : MonoBehaviour {  
  
    public float speed = 0.0F;  
    
    // Use this for initialization  
    void Start () {  
    }  

    // Update is called once per frame  
    void Update () 
    {
        if(Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
        	speed -= Mathf.Abs(Mathf.Pow(Input.GetAxis("Mouse X"), 1.0f)) * Mathf.Sign(Input.GetAxis("Mouse X")) * 50.0f;
	    }
	    else if(Input.GetMouseButtonUp(0) && Input.GetMouseButtonUp(1))
		{
		}
		
		speed = Mathf.Lerp(speed, 0.0f, Time.deltaTime * 5.0f);
		this.transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }  
}  