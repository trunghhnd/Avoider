using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float baseSpeed = 3f;
    float growth = 0.1f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = baseSpeed + growth * Time.time;
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if(this.transform.position.y < -5.5f)
        {
            gameObject.SetActive(false);
            ScoreManage.Instance.AddScore(1);
        }
        
    }
}
