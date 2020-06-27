using UnityEngine;
using System.Collections;
public class ai_script : MonoBehaviour {
    public GameObject target;
    void Start () {
    }
    void Update () {
        this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = target.transform.position;
    }
}