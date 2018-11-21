using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mogura_Maker : MonoBehaviour {
    public GameObject Mogura;
    private int Hole;
    public int flag1,flag2,flag3,flag4,flag5,flag6,flag7,flag8,flag9;
    // Use this for initialization
    void Start () {
        //InvokeRepeating("MoguraPokopoko", 0.3f, 1.8f);
        //InvokeRepeating("MoguraPokopoko2", 0.4f, 1.7f);
        //InvokeRepeating("MoguraPokopoko3", 0.2f, 1.9f);
        InvokeRepeating("MoguraPokopoko4", 0.2f, 0.5f);
        flag1 = 0;
        flag2 = 0;
        flag3 = 0;
        flag4 = 0;
        flag5 = 0;
        flag6 = 0;
        flag7 = 0;
        flag8 = 0;
        flag9 = 0;

    }

    private void MoguraPokopoko(){
        Hole = Random.Range(1, 4);
        //Instantiate(Mogura, new Vector3(Random.Range(3f, 5f), transform.position.y, transform.position.z), transform.rotation);
        if (Hole == 1)
        {
            Instantiate(Mogura, new Vector3(5f, transform.position.y, transform.position.z), transform.rotation);
        }
        if (Hole == 2)
        {
            Instantiate(Mogura, new Vector3(-5f, transform.position.y, transform.position.z), transform.rotation);
        }
        if (Hole == 3)
        {
            Instantiate(Mogura, new Vector3(0f, transform.position.y, transform.position.z), transform.rotation);
        }

    }
    private void MoguraPokopoko2()
    {
        Hole = Random.Range(1, 4);
        //Instantiate(Mogura, new Vector3(Random.Range(3f, 5f), transform.position.y, transform.position.z), transform.rotation);
        if (Hole == 1)
        {
            Instantiate(Mogura, new Vector3(5f, transform.position.y, 5f), transform.rotation);
        }
        if (Hole == 2)
        {
            Instantiate(Mogura, new Vector3(-5f, transform.position.y, 5f), transform.rotation);
        }
        if (Hole == 3)
        {
            Instantiate(Mogura, new Vector3(0, transform.position.y, 5f), transform.rotation);
        }

    }
    private void MoguraPokopoko3()
    {
        Hole = Random.Range(1, 4);
        //Instantiate(Mogura, new Vector3(Random.Range(3f, 5f), transform.position.y, transform.position.z), transform.rotation);
        if (Hole == 1)
        {
            Instantiate(Mogura, new Vector3(5f, transform.position.y, -5f), transform.rotation);
        }
        if (Hole ==2)
        {
            Instantiate(Mogura, new Vector3(-5f, transform.position.y, -5f), transform.rotation);
        }
        if (Hole == 3)
        {
            Instantiate(Mogura, new Vector3(0, transform.position.y, -5f), transform.rotation);
        }


    }
    private void MoguraPokopoko4()
    {
        Hole = Random.Range(1, 10);
        //Instantiate(Mogura, new Vector3(Random.Range(3f, 5f), transform.position.y, transform.position.z), transform.rotation);
        if (Hole == 1)
        {
            if (flag1 == 0)
            {
                Instantiate(Mogura, new Vector3(5f, transform.position.y, 0f), transform.rotation);
                flag1 = 1;
                //FindObjectOfType<Beat>().resetFlag(1);
                Mogura.tag = "mogura1";
            }
        }
        if (Hole == 2)
        {
            if (flag2 == 0)
            {
                Instantiate(Mogura, new Vector3(-5f, transform.position.y, 0f), transform.rotation);
                flag2 = 1;
                Mogura.tag = "mogura2";
            }
        }
        if (Hole == 3)
        {
            if (flag3 == 0)
            {
                Instantiate(Mogura, new Vector3(0f, transform.position.y, 0f), transform.rotation);
                flag3 = 1;
                Mogura.tag = "mogura3";
            }
        }
        if (Hole == 4)
        {
            if (flag4 == 0)
            {
                Instantiate(Mogura, new Vector3(5f, transform.position.y, 5f), transform.rotation);
                flag4 = 1;
                Mogura.tag = "mogura4";
            }
        }
        if (Hole == 5)
        {
            if (flag5 == 0)
            {
                Instantiate(Mogura, new Vector3(-5f, transform.position.y, 5f), transform.rotation);
                flag5 = 1;
                Mogura.tag = "mogura5";
            }
        }
        if (Hole == 6)
        {
            if (flag6 == 0)
            {
                Instantiate(Mogura, new Vector3(0, transform.position.y, 5f), transform.rotation);
                flag6 = 1;
                Mogura.tag = "mogura6";
            }
        }
        if (Hole == 7)
        {
            if (flag7 == 0)
            {
                Instantiate(Mogura, new Vector3(5f, transform.position.y, -5f), transform.rotation);
                flag7 = 1;
                Mogura.tag = "mogura7";
            }
        }
        if (Hole == 8)
        {
            if (flag8 == 0)
            {
                Instantiate(Mogura, new Vector3(-5f, transform.position.y, -5f), transform.rotation);
                flag8 = 1;
                Mogura.tag = "mogura8";
            }
        }
        if (Hole == 9)
        {
            if (flag9 == 0)
            {
                Instantiate(Mogura, new Vector3(0, transform.position.y, -5f), transform.rotation);
                flag9 = 1;
                Mogura.tag = "mogura9";
            }
        }

    }
    // Update is called once per frame
    void Update () {
		
	}
}
