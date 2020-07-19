using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemaslaYokOl : MonoBehaviour {

    public GameObject patlama;
    public GameObject playerPatlama;
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag!="Sınır")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(patlama, transform.position, transform.rotation);
        }
        if (col.tag=="Player")
        {
            Instantiate(patlama, col.transform.position,col.transform.rotation);
        }
    }


}
