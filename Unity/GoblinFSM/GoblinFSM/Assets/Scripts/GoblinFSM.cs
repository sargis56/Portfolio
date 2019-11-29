using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GoblinFSM : MonoBehaviour {
    public enum GoblinState { Idle, Investigate, Attack, Taunt, Retreat, Heal};
    public GoblinState currentState;
    public GameObject enemy;
    public float health = 100;
    public float speed = 1;

    // Use this for initialization
    void Start () {
        currentState = GoblinState.Idle;
    }

    // Update is called once per frame
    void Update() {

        UpdateState();

        if (enemy != null)
        { 
            if (Input.GetKeyDown("space"))
            {
                health = health - 15;
                ChangeState(GoblinState.Attack);
            }
        }

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void ChangeState(GoblinState toState)
    {
        currentState = toState;
    }

    void UpdateState()
    {
        switch (currentState)
        {
            case GoblinState.Idle:
                print("In GoblinState.Idle");
                Idle();
                break;

            case GoblinState.Investigate:
                print("In GoblinState.Investigate");
                Investigate();
                break;

            case GoblinState.Attack:
                print("In GoblinState.Attack");
                Attack();
                break;

            case GoblinState.Taunt:
                print("In GoblinState.Taunt");
                Taunt();
                break;

            case GoblinState.Retreat:
                print("In GoblinState.Retreat");
                Retreat();
                break;

            case GoblinState.Heal:
                print("In GoblinState.Heal");
                Heal();
                break;

        }
    }

    void Idle()
    {
        if (enemy != null)
        {
            ChangeState(GoblinState.Investigate);
        }

        if (health != 100)
        {
            ChangeState(GoblinState.Heal);
        }

    }

    void Investigate()
    {
        if (enemy != null)
        {
            Vector3 p0 = transform.position;
            Vector3 p1 = enemy.transform.position;
            Vector3 newPos = transform.position + speed * Time.deltaTime * (p1 - p0).normalized;
            transform.position = newPos;

            RaycastHit hit;

            Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
            Vector3 back = transform.TransformDirection(Vector3.back) * 10;
            Vector3 right = transform.TransformDirection(Vector3.right) * 10;
            Vector3 left = transform.TransformDirection(Vector3.left) * 10;
            Debug.DrawRay(transform.position, forward, Color.blue);
            Debug.DrawRay(transform.position, back, Color.blue);
            Debug.DrawRay(transform.position, right, Color.blue);
            Debug.DrawRay(transform.position, left, Color.blue);

            if (Physics.Raycast(transform.position, forward, out hit))
            {
                if (hit.collider.tag == "Player")
                {
                    ChangeState(GoblinState.Attack);
                }
            }
            if (Physics.Raycast(transform.position, back, out hit))
            {
                if (hit.collider.tag == "Player")
                {
                    ChangeState(GoblinState.Attack);
                }
            }
            if (Physics.Raycast(transform.position, left, out hit))
            {
                if (hit.collider.tag == "Player")
                {
                    ChangeState(GoblinState.Attack);
                }
            }
            if (Physics.Raycast(transform.position, right, out hit))
            {
                if (hit.collider.tag == "Player")
                {
                    ChangeState(GoblinState.Attack);
                }
            }
        }
            
    }

    void Attack()
    {
        if (enemy != null)
        {
            Vector3 p0 = transform.position;
            Vector3 p1 = enemy.transform.position;
            Vector3 newPos = transform.position + (speed + 5) * Time.deltaTime * (p1 - p0).normalized;
            transform.position = newPos;
        }
        else
        {
            ChangeState(GoblinState.Idle);
        }

        if (health <= 25)
        {
            ChangeState(GoblinState.Retreat);
        }

    }

    void Taunt()
    {
        GetComponent<Rigidbody>().AddForce(5,0,5);

        System.Random rnd = new System.Random();
        int y = rnd.Next(0, 3); 
        Vector3 newPos;
        newPos.x = transform.position.x;
        newPos.y = y;
        newPos.z = transform.position.z;
        transform.position = newPos;
    }

    void Retreat()
    {
        if (enemy != null)
        {
            Vector3 p0 = transform.position;
            Vector3 p1 = enemy.transform.position;
            Vector3 newPos = transform.position - (speed + 5) * Time.deltaTime * (p1 - p0).normalized;
            transform.position = newPos;
        }
    }

    void Heal()
    {
        health++;


        RaycastHit hit;

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Vector3 back = transform.TransformDirection(Vector3.back) * 10;
        Vector3 right = transform.TransformDirection(Vector3.right) * 10;
        Vector3 left = transform.TransformDirection(Vector3.left) * 10;

        if (Physics.Raycast(transform.position, forward, out hit))
        {
            if ((hit.collider.tag == "Player") && (health >= 50))
            {
                ChangeState(GoblinState.Attack);
            }
        }
        if (Physics.Raycast(transform.position, back, out hit))
        {
            if ((hit.collider.tag == "Player") && (health >= 50))
            {
                ChangeState(GoblinState.Attack);
            }
        }
        if (Physics.Raycast(transform.position, left, out hit))
        {
            if ((hit.collider.tag == "Player") && (health >= 50))
            {
                ChangeState(GoblinState.Attack);
            }
        }
        if (Physics.Raycast(transform.position, right, out hit))
        {
            if ((hit.collider.tag == "Player") && (health >= 50))
            {
                ChangeState(GoblinState.Attack);
            }
        }

        if (health >= 100)
        {
            health = 100;
            ChangeState(GoblinState.Idle);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ChangeState(GoblinState.Heal);
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            ChangeState(GoblinState.Taunt);
        }
    }
}
