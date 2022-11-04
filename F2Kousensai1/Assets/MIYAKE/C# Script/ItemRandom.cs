using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System;

public class ItemRandom : MonoBehaviour
{
    MeshRenderer mr;
    public float nowPosi;
    public MeshRenderer node_id9_1;
    public MeshRenderer node_id9_2;
    public MeshRenderer node_id9_3;
    // public MeshRenderer node_id7_1;
    public GameObject banana;
    public GameObject AccelPoint_shortcut;
    public GameObject AccelPoint_ogura;
    public GameObject shortcut;
    public GameObject Crystal;
    // public float nowPosi;
    // Start is called before the first frame update

    public string[] a = new string[4] {"キノコ","バナナ","障害物","ショートカット"};
    // public int r1 = UnityEngine.Random.Range(0, 2);

    void Start()
    {
        // System.Random r1 = new System.Random();
        // GameObject g = GameObject.FindWithTag("banana");
        // SetMatColor1(node_id7_1, new Color32(0,0,0,255));   // バナナ消す
        nowPosi = this.transform.position.y;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time, 0.3f), transform.position.z);
    }
    IEnumerator Defeat() {
        SetMatColor1(node_id9_1, new Color32(0,0,0,255));
        SetMatColor1(node_id9_2, new Color32(0,0,0,255));
        SetMatColor1(node_id9_3, new Color32(0,0,0,255));
        
        yield return new WaitForSeconds(4);
        
        SetMatColor2(node_id9_1, new Color32(0,0,0,255));
        SetMatColor2(node_id9_2, new Color32(0,0,0,255));
        SetMatColor2(node_id9_3, new Color32(0,0,0,255));
    }

    public void OnTriggerEnter(Collider other)
    {
        // int rank;
        // if(rank == 1){
        //     int r1 = UnityEngine.Random.Range(0, 3);
        // }else{
        //     int r1 = UnityEngine.Random.Range(0, 4);
        // }
        int r1 = UnityEngine.Random.Range(0, 4);
        IEnumerator defeat = Defeat();
        if(a[r1]=="キノコ"){
            other.gameObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, 10), ForceMode.VelocityChange);
        }
        else if(a[r1]=="バナナ"){
            // Instantiate(banana,new Vector3(15.4f, -8.56f, -5.5f), Quaternion.identity);   // バナナを出現
            banana.SetActive (true);
        }
        else if(a[r1]=="ショートカット"){
            // Instantiate(AccelPoint_shortcut,new Vector3(17.73f, -7.82f, -12.1f), Quaternion.Euler(10,230,0));
            // Instantiate(AccelPoint_ogura,new Vector3(12.24f, -8.76f, -17.19f), Quaternion.Euler(0,230,0));
            // Instantiate(shortcut,new Vector3(15.76f, -8.36f, -13.8f), Quaternion.Euler(-10,50,0));
            AccelPoint_shortcut.SetActive(true);
            AccelPoint_ogura.SetActive(true);
            shortcut.SetActive(true);
        }
        else if(a[r1]=="障害物"){
            // Instantiate(Obstacle,new Vector3(22.83f, -8.19f, -3.25f), Quaternion.Euler(0,-30,0));
            Crystal.SetActive (true);
        }
        StartCoroutine(defeat);

        // IEnumerator defeat = Defeat();
        // StartCoroutine(defeat);
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
