using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparency : MonoBehaviour
{   
    MeshRenderer mr;
    public float nowPosi;
    public GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {
        
        mr = GetComponent<MeshRenderer>();
        nowPosi = this.transform.position.y;
        // mr.material.color = mr.material.color - new Color32(0,0,0,255);
    }


     void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player1"))
        {
            IEnumerator defeat = Defeat();
             StartCoroutine(defeat);
            

        }
    }
    IEnumerator Defeat() {
        mr.material.color = mr.material.color - new Color32(0,0,0,255);
        // GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // GameObject obj = (GameObject)Resources.Load ("Cube");
        Instantiate(Cube,new Vector3(25, -8f, -7f), Quaternion.identity);
        // obj.transform.position = new Vector3(25, -8f, -7f);
        // Instantiate (obj, new Vector3(0.0f,2.0f,0.0f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        // Destroy (obj);
        mr.material.color = mr.material.color + new Color32(0,0,0,255);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time, 0.3f), transform.position.z);
    }
}
