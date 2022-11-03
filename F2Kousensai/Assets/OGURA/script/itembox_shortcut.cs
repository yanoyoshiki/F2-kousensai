using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itembox_shortcut : MonoBehaviour
{   
    MeshRenderer mr;
    public float nowPosi;
    public MeshRenderer node_id9_1;
    public MeshRenderer node_id9_2;
    public MeshRenderer node_id9_3;
    public GameObject AccelPoint_shortcut;
    public GameObject AccelPoint_ogura;
    public GameObject shortcut;

    // Start is called before the first frame update
    void Start()
    {
        
        // mr = GetComponent<MeshRenderer>();
        nowPosi = this.transform.position.y;
        // mr.material.color = mr.material.color - new Color32(0,0,0,255);
    }


     void OnTriggerEnter(Collider hit)
    {
        IEnumerator defeat = Defeat();
        StartCoroutine(defeat);
    }
    IEnumerator Defeat() {
        SetMatColor1(node_id9_1, new Color32(0,0,0,255));
        SetMatColor1(node_id9_2, new Color32(0,0,0,255));
        SetMatColor1(node_id9_3, new Color32(0,0,0,255));
        // Instantiate(AccelPoint_shortcut,new Vector3(-582.81f, 132.38f, 764.81f), Quaternion.Euler(10,180,0));
        // Instantiate(AccelPoint_ogura,new Vector3(-582.981f, 133.4f, 772.13f), Quaternion.Euler(0,180,0));
        Instantiate(AccelPoint_shortcut,new Vector3(-582.981f, 133.4f, 772.13f), Quaternion.Euler(10,180,0));
        Instantiate(AccelPoint_ogura,new Vector3(-582.81f, 132.38f, 764.81f), Quaternion.Euler(0,180,0));
        Instantiate(shortcut,new Vector3(-583.07f, 132.92f, 769.7f), Quaternion.Euler(-10,0,0));
        yield return new WaitForSeconds(4);
        SetMatColor2(node_id9_1, new Color32(0,0,0,255));
        SetMatColor2(node_id9_2, new Color32(0,0,0,255));
        SetMatColor2(node_id9_3, new Color32(0,0,0,255));
    }
    void SetMatColor1(MeshRenderer mesh,Color col )
    {
        mesh.material.color = mesh.material.color - col; //meshのmaterialの色を変える
    }
    void SetMatColor2(MeshRenderer mesh,Color col )
    {
        mesh.material.color = mesh.material.color + col; //meshのmaterialの色を変える
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time, 0.3f), transform.position.z);
    }
}
