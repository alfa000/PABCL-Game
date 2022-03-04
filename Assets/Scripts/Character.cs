using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private float speed = 10f;
    private float maxPos = 1.8f;
    Vector2 posistion;

    // Start is called before the first frame update
    void Start()
    {
        posistion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        posistion.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        posistion.x = Mathf.Clamp(posistion.x, -maxPos, maxPos);
        transform.position = posistion;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameManager._instance.ShowGameOver();
        }
    }
}
