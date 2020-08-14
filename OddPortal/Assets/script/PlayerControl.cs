using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject Camera_Obj;
    public float Walkspeed;
    public float rotatonspeed;
    public bool inv;
    public Transform distence;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    private void FixedUpdate()
    {

        Vector3 p_Velocity = new Vector3();
        Vector3 R_R = new Vector3();
        if (Input.GetKey(KeyCode.W))
        {
            p_Velocity += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            p_Velocity += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            p_Velocity += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            p_Velocity += new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            R_R += new Vector3(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            R_R -= new Vector3(0, 1, 0);
        }


        Vector3 nowpos = this.GetComponent<Transform>().position;
        if (inv == false)
        {
            nowpos += p_Velocity * Walkspeed * Time.deltaTime;
        }
        else
        {
            nowpos -= p_Velocity * Walkspeed * Time.deltaTime;
        }
        this.transform.position = nowpos;
        this.transform.Rotate(R_R * rotatonspeed * Time.deltaTime);

    }
}
