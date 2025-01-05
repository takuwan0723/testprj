
#define DEBUG_LOG

using Assets.Log;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed; // 速度はInspectorで調整できるようにする

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // 画面幅を取得し、speedを計算
        float screenWidth = Screen.width;
        speed = screenWidth / 5f; // 5秒で画面横断
        
        CustomLogger.LogPlayer("画面幅:" + screenWidth);
        CustomLogger.LogPlayer("移動速度:" + speed);
        
    }

    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        // Shift押下時に倍速移動
        float speedMultiplier = Input.GetKey(KeyCode.LeftShift) ? 2f : 1f;

        Vector2 movement = new Vector2(horizontalMove, verticalMove);
        rb.linearVelocity = speed * speedMultiplier * movement;
    }
}
