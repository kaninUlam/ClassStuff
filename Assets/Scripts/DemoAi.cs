using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DemoAi : MonoBehaviour
{
    //AI
    NavMeshAgent agent = null;
    public GameObject targetpoint = null;

    //RayCast
    public float dist = 10f;
    public LayerMask mask = 0;
/*    GameObject hitTarget = null;*/

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        /* targetpoint = new GameObject("target");*/
        /*hitTarget = targetpoint;*/
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 direction = new Vector3(Mathf.Sin(Time.time), 0, 1);
        agent.Move(direction * Time.deltaTime * 5);*/


        /*RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * dist, Color.green);
        if (Physics.Raycast(transform.position, transform.forward, out hit, dist, mask))
        {
            hitTarget = hit.transform.gameObject;
            
        }*/
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousepos = Input.mousePosition;
            Debug.Log(mousepos.x);
            Debug.Log(mousepos.y);

        }

       /* agent.SetDestination(mousepos);*/
    }
}
