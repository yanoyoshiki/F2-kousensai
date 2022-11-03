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
    public GameObject tunnel;
    
    


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
        Instantiate(AccelPoint_shortcut,new Vector3(-583.07f, 134.46f, 772.26f), Quaternion.Euler(20,180,0));
        Instantiate(AccelPoint_ogura,new Vector3(-583.33f, 132.38f, 765.2f), Quaternion.Euler(0,180,0));
        Instantiate(shortcut,new Vector3(-583.22f, 133.52f, 770.05f), Quaternion.Euler(-20,0,0));
        Instantiate(tunnel,new Vector3(-582.91f, 132.46f, 762.09f), Quaternion.Euler(-90,0,0));
        // Instantiate(wall_shortcut_L,new Vector3(-585.62f, 131.61f, 758.85f), Quaternion.Euler(0,0,-20));
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
