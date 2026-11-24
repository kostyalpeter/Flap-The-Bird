using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class BirdMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public int power;
    bool Asked;
    public TMP_Text text;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame || Keyboard.current.wKey.wasPressedThisFrame)
        {
            Asked = true;
        }
        if(Keyboard.current.rKey.wasPressedThisFrame)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("SampleScene");
        }
        
    }
    void FixedUpdate()
    {
        if (Asked)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            rb.AddForce(Vector2.up * power, ForceMode2D.Impulse);
            Asked = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Object"))
        {
            text.text = "Game Over";
            Time.timeScale = 0f;
        }
    }
}   