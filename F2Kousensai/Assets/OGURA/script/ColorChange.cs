using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ColorChange : MonoBehaviour
{   
    MeshRenderer mr;
    public float nowPosi;
    public GameObject Cube;
    public MeshRenderer node_id9_1;
    public MeshRenderer node_id9_2;
    public MeshRenderer node_id9_3;
    // public float nowPosi;
    // Start is called before the first frame update
    void Start()
    {
        // mr = GetComponent<MeshRenderer>();
        // mr = GetComponent<MeshRenderer>();
        nowPosi = this.transform.position.y;

        // nowPosi = this.transform.position.z;
        // mr.material.color = mr.material.color - new Color32(0,0,0,255);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time, 0.3f), transform.position.z);
    }
    IEnumerator Defeat() {
        // gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(10, 0, 0), ForceMode.VelocityChange);
        // mr.material.color = mr.material.color - new Color32(0,0,0,255);
        SetMatColor1(node_id9_1, new Color32(0,0,0,255));
        SetMatColor1(node_id9_2, new Color32(0,0,0,255));
        SetMatColor1(node_id9_3, new Color32(0,0,0,255));
        Instantiate(Cube,new Vector3(13f, -8f, -11f), Quaternion.identity);
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