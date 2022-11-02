using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRandom : MonoBehaviour
{
    MeshRenderer mr;
    public MeshRenderer node_id9_1;
    public MeshRenderer node_id9_2;
    public MeshRenderer node_id9_3;
    public MeshRenderer node_id7_1;
    // public float nowPosi;
    // Start is called before the first frame update
    void Start()
    {
        GameObject g = GameObject.FindWithTag("banana");
        SetMatColor1(node_id7_1, new Color32(0,0,0,255));   // バナナ消す
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Defeat() {
        // gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(10, 0, 0), ForceMode.VelocityChange);
        // mr.material.color = mr.material.color - new Color32(0,0,0,255);
        SetMatColor1(node_id9_1, new Color32(0,0,0,255));
        SetMatColor1(node_id9_2, new Color32(0,0,0,255));
        SetMatColor1(node_id9_3, new Color32(0,0,0,255));
        SetMatColor2(node_id7_1, new Color32(0,0,0,255));   // バナナを出現
        
        yield return new WaitForSeconds(4);
        // mr.material.color = mr.material.color + new Color32(0,0,0,255);
        SetMatColor2(node_id9_1, new Color32(0,0,0,255));
        SetMatColor2(node_id9_2, new Color32(0,0,0,255));
        SetMatColor2(node_id9_3, new Color32(0,0,0,255));
    }

    private void OnTriggerEnter(Collider other)
    {
            other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(10, 0, 0), ForceMode.VelocityChange);
            IEnumerator defeat = Defeat();
            StartCoroutine(defeat);
    }

    void SetMatColor1(MeshRenderer mesh,Color col )
    {
        mesh.material.color = mesh.material.color - col; //meshのmaterialの色を変える
    }
    void SetMatColor2(MeshRenderer mesh,Color col )
    {
        mesh.material.color = mesh.material.color + col; //meshのmaterialの色を変える
    }
}
