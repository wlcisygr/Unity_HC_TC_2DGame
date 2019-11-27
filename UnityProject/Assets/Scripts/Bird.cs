using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(50, 1500)]
    public int jump = 100;
    [Header("旋轉角度")]
    public float angle = 5;
    [Header("是否死亡"), Tooltip("判斷角色是否死亡")]
    public bool isDead;

    public GameObject goScore, goGM;
    public Rigidbody2D r2d;     // 2D 剛體

    private void Update()
    {
        Jump();
    }

    // 碰撞開始事件：物件碰撞開始時執行一次 (紀錄碰撞物件資訊)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 碰撞.遊戲物件.名稱
        print(collision.gameObject.name);
    }

    /// <summary>
    /// 小雞跳躍功能。
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            goScore.SetActive(true);
            goGM.SetActive(true);

            r2d.Sleep();                            // 2D 剛體.睡著() 重設所有物理資料
            r2d.gravityScale = 1;                   // 2D 剛體.地心引力 = 1
            r2d.AddForce(new Vector2(0, jump));     // 2D 剛體.推力(二為向量)
        }

        r2d.SetRotation(angle * r2d.velocity.y);       // 2D 剛體.設定角度(角度)
        //print(r2d.velocity);
    }

    /// <summary>
    /// 小雞死亡功能。
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 通過水管。
    /// </summary>
    private void PassPipe()
    {

    }
}
