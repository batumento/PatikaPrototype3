using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float m_Speed = 10f;
    private float leftBound = -13f;
    private PlayerController m_Controller;
    void Start()
    {
         m_Controller = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        DestroyObstacle();
        if (m_Controller.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * m_Speed);
        }
    }
    private void DestroyObstacle()
    {
        if (gameObject.CompareTag("Obstacle") && transform.position.x <= leftBound)
        {
            Destroy(gameObject);
        }
    }
}
