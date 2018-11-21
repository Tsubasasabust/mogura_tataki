using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour {
    // Use this for initialization
    public GameObject Mogura;
    private int Hole;

    public StartGame startGame;

    Camera m_camera;
    public float Count;
    private float Bspeed;
    public AudioClip[] clips;
    AudioSource audio;

    private float Frequency;
    // public bool flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8, flag9;

　　//public readonly static Beat Instance = new ();

    void Start () {
        Bspeed = 40.0f;
        Count = 0.0f;
        //startGame.Setlevel(0.8f);
        //Frequency = startGame.Lebelchange;
        Frequency = 0.8f;
        m_camera = Camera.main;
        this.transform.position = new Vector3(30.0f, 0f, 30.0f);
        audio = GetComponent<AudioSource>();
        Debug.Log(Frequency);
        InvokeRepeating("MoguraPokopoko4", 0.2f, Frequency);

        FlagManager.Instance.ResetFlags();

    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0)){
           
            Vector3 toushScreenPosition = Input.mousePosition;


            toushScreenPosition.z = 20.0f;
            Vector3 touchWorldPosition = Camera.main.ScreenToWorldPoint(toushScreenPosition);
            touchWorldPosition.y = 10.0f;

            if(touchWorldPosition.x >=  10.0f){
                touchWorldPosition.x = 10.0f;
            }
            if (touchWorldPosition.x <= -10.0f)
            {
                touchWorldPosition.x = -10.0f;
            }



            this.transform.position = touchWorldPosition; 

            Debug.Log(touchWorldPosition);

        }
        if(Input.GetMouseButton(0)){
            this.transform.position += new Vector3(0f, -2 * Bspeed * Time.deltaTime, 0f);
        }
        if(Input.GetMouseButtonUp(0)){
            this.transform.position = new Vector3(30.0f, 0f, 30.0f);
        }

       
    }

        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("mogura1"))
        {
            this.transform.position = new Vector3(30.0f, 0f, 30.0f);
           // this.transform.rotation = new Quaternion(0f, 0f, 0f, 1.0f);
            FindObjectOfType<Score>().AddPoint(1);
            Debug.Log(Count);
            audio.clip = clips[0];
            audio.Play();
            FlagManager.Instance.flags[0] = false;
        }
        if (collision.gameObject.CompareTag("mogura2"))
        {
            this.transform.position = new Vector3(30.0f, 0f, 30.0f);
            FindObjectOfType<Score>().AddPoint(1);
            audio.clip = clips[0];
            audio.Play();
            FlagManager.Instance.flags[1] = false;
        }
        if (collision.gameObject.CompareTag("mogura3"))
        {
            this.transform.position = new Vector3(30.0f, 0f, 30.0f);
            FindObjectOfType<Score>().AddPoint(1);
            audio.clip = clips[0];
            audio.Play();
            FlagManager.Instance.flags[2] = false;
        }
        if (collision.gameObject.CompareTag("mogura4"))
        {
            this.transform.position = new Vector3(30.0f, 0f, 30.0f);
            FindObjectOfType<Score>().AddPoint(1);
            audio.clip = clips[0];
            audio.Play();
            FlagManager.Instance.flags[3] = false;
        }
        if (collision.gameObject.CompareTag("mogura5"))
        {
            this.transform.position = new Vector3(30.0f, 0f, 30.0f);
            FindObjectOfType<Score>().AddPoint(1);
            audio.clip = clips[0];
            audio.Play();
            FlagManager.Instance.flags[4] = false;
        }
        if (collision.gameObject.CompareTag("mogura6"))
        {
            this.transform.position = new Vector3(30.0f, 0f, 30.0f);
            FindObjectOfType<Score>().AddPoint(1);
            audio.clip = clips[0];
            audio.Play();
            FlagManager.Instance.flags[5] = false;
        }
        if (collision.gameObject.CompareTag("mogura7"))
        {
            this.transform.position = new Vector3(30.0f, 0f, 30.0f);
            FindObjectOfType<Score>().AddPoint(1);
            audio.clip = clips[0];
            audio.Play();
            FlagManager.Instance.flags[6] = false;
        }
        if (collision.gameObject.CompareTag("mogura8"))
        {
            this.transform.position = new Vector3(30.0f, 0f, 30.0f);
            FindObjectOfType<Score>().AddPoint(1);
            audio.clip = clips[0];
            audio.Play();
            FlagManager.Instance.flags[7] = false;
        }
        if (collision.gameObject.CompareTag("mogura9"))
        {
            this.transform.position = new Vector3(30.0f, 0f, 30.0f);
            FindObjectOfType<Score>().AddPoint(1);
            audio.clip = clips[1];
            audio.Play();
            FlagManager.Instance.flags[8] = false;
        }
        if (collision.gameObject.CompareTag("Stage"))
        {
            this.transform.position = new Vector3(30.0f, 0f, 30.0f);
            audio.clip = clips[2];
            audio.Play();
        }
    }
    private void MoguraPokopoko4()
    {
        Hole = Random.Range(1, 10);
        //Instantiate(Mogura, new Vector3(Random.Range(3f, 5f), transform.position.y, transform.position.z), transform.rotation);
        if (Hole == 1)
        {
            if (FlagManager.Instance.flags[0] == false)
            {
                Instantiate(Mogura, new Vector3(5f, 0f, 0f), new Quaternion(0f, 90.0f, 0f,0f));
                FlagManager.Instance.flags[0] = true;
                //FindObjectOfType<Beat>().resetFlag(1);
                Mogura.tag = "mogura1";
            }
        }
        if (Hole == 2)
        {
            if (FlagManager.Instance.flags[1] == false)
            {
                Instantiate(Mogura, new Vector3(-5f, 0f, 0f), new Quaternion(0f, 90.0f, 0f,0f));
                FlagManager.Instance.flags[1] = true;
                Mogura.tag = "mogura2";

            }
        }
        if (Hole == 3)
        {
            if (FlagManager.Instance.flags[2] == false)
            {
                Instantiate(Mogura, new Vector3(0f, 0f, 0f), new Quaternion(0f, 90.0f, 0f,0f));
                FlagManager.Instance.flags[2] = true;
                Mogura.tag = "mogura3";
            }
        }
        if (Hole == 4)
        {
            if (FlagManager.Instance.flags[3] == false)
            {
                Instantiate(Mogura, new Vector3(5f, 0f, 5f), new Quaternion(0f, 90.0f, 0f,0f));
                FlagManager.Instance.flags[3] = true;
                Mogura.tag = "mogura4";
            }
        }
        if (Hole == 5)
        {
            if (FlagManager.Instance.flags[4] == false)
            {
                Instantiate(Mogura, new Vector3(-5f, 0f, 5f), new Quaternion(0f, 90.0f, 0f,0f));
                FlagManager.Instance.flags[4] = true;
                Mogura.tag = "mogura5";
            }
        }
        if (Hole == 6)
        {
            if (FlagManager.Instance.flags[5] == false)
            {
                Instantiate(Mogura, new Vector3(0, 0f, 5f), new Quaternion(0f, 90.0f, 0f,0f));
                FlagManager.Instance.flags[5] = true;
                Mogura.tag = "mogura6";
            }
        }
        if (Hole == 7)
        {
            if (FlagManager.Instance.flags[6] == false)
            {
                Instantiate(Mogura, new Vector3(5f, 0f, -5f), new Quaternion(0f, 90.0f, 0f,0f));
                FlagManager.Instance.flags[6] = true;
                Mogura.tag = "mogura7";
            }
        }
        if (Hole == 8)
        {
            if (FlagManager.Instance.flags[7] == false)
            {
                Instantiate(Mogura, new Vector3(-5f, 0f, -5f), new Quaternion(0f, 90.0f, 0f,0f));
                FlagManager.Instance.flags[7] = true;
                Mogura.tag = "mogura8";
            }
        }
        if (Hole == 9)
        {
            if (FlagManager.Instance.flags[8] == false)
            {
                Instantiate(Mogura, new Vector3(0, 0f, -5f), new Quaternion(0f, 90.0f, 0f,0f));
                FlagManager.Instance.flags[8] = true;
                Mogura.tag = "mogura9";
            }
        }

    }
    /* public void resetFlag(int flag1)
     {
         flag1 = 0;
     }*/

}
