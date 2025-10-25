using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;
    float speed = 5;
    public string nextLevel = "Scene_2";
    public SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SpriteRenderer.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SpriteRenderer.color = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SpriteRenderer.color = Color.blue;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Death":
                string currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(currentScene);
                break;
            case "Finish":
                SceneManager.LoadScene(nextLevel);
                break;
        }
}
}
