using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
  public float moveSpeed = 5f;
  public float rotationSpeed = 720;
  public Rigidbody2D rb;

  public bool canMove = true;
  Vector2 movement;

  // Update is called once per frame
  void Update()
  {
    movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");

    // Reload scene
    if (Input.GetKeyDown(KeyCode.R))
      SceneManager.LoadScene("Main");

    // Exit game

    if (Input.GetKeyDown(KeyCode.Escape))
      Application.Quit();
  }

  void FixedUpdate()
  {
    if (canMove)
      rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    //Vector2 movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

    //if (movementDirection != Vector2.zero)
    //{
    //  Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
    //  transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
    //}

  }
}
