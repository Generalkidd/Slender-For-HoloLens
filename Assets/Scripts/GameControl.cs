using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour
{
    GameObject slender;
    int count = 0;
    Time gameTime;
	// Use this for initialization
	void Start ()
    {
        //slender = (GameObject)Instantiate(GameObject.Find("Slenderman"), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 3.5f), new Quaternion(0,0,0,0));
        
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(this.transform.rotation.y > 90 || this.transform.rotation.y < -90)
        {
            //slender = (GameObject)Instantiate(GameObject.Find("Slenderman"), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 3.5f), new Quaternion(0, 0, 0, 0));
            //slender.SetActive(false);
            Destroy(slender);
            count = 0;
        }
        else if(count < 2 && Time.time > 30)
        {
            count++;
            slender = (GameObject)Instantiate(GameObject.Find("Slenderman"), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 3.5f), new Quaternion(0, 0, 0, 0));
            //slender.SetActive(true);
            //slender.gameObject.GetComponent<Renderer>().enabled = true;
        }
        
	}
}
