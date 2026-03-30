using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public bool isGameOver = false;
    public GameObject panelUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) return;
        Time.timeScale = 1f;
        float move = Input.GetAxis("Horizontal");
        this.transform.Translate(move * speed * Time.deltaTime, 0, 0);
        float x = Mathf.Clamp(transform.position.x, -8f, 8f);
        this.transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            panelUI.SetActive(true);
            isGameOver = true;
            Time.timeScale = 0f;
        }
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
