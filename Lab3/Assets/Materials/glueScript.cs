using UnityEngine;
using System.Collections;

public class glueScript : MonoBehaviour {
    

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, 15) * Time.deltaTime);
	}

	void OnCollisionEnter(Rigidbody rb) {
        rb.GetComponent<Rigidbody>().transform.localRotation = Quaternion.identity;
        rb.GetComponent<Rigidbody>().transform.parent = transform;
        rb.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;

        //collision.transform.localPosition=Vector3.zero;

        /*
                float x = collision.gameObject.transform.parent.localScale.x;
                float y = collision.gameObject.transform.parent.localScale.y;
                float z = collision.gameObject.transform.parent.localScale.z;
        */

        /*
		collision.transform.localScale = new Vector3 (x / collision.gameObject.transform.parent.localScale.x,
		                                             y / collision.gameObject.transform.parent.localScale.y,
		                                             z / collision.gameObject.transform.parent.localScale.z);
*/
        rb.GetComponent<Rigidbody>().transform.localScale = new Vector3 ( .02f,.02f,0.02f);

	}
}
