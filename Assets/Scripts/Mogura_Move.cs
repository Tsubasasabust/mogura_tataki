using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mogura_Move : MonoBehaviour {
    private float speed;
    private float timer;
    // Use this for initialization
    void Start () {
        //speed = Random.Range(6f, 7f);
        speed = 6.0f;
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer <= 1.0f)
        {
            transform.position += new Vector3(0f, 1f * speed * Time.deltaTime, 0f);
            //transform.position += new Vector3(0f, 1f * speed , 0f);
        }

        if (timer >= 1.1f)
        {
            transform.position -= new Vector3(0f, 1f * speed * Time.deltaTime, 0f);
        }
        if (transform.position.y <= -3)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Stage")){
            Debug.Log(collision.collider.name);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Beat"))
        {
            Destroy(gameObject);
        }

    }
}
