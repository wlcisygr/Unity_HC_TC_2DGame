using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(50, 1500)]
    public int jump = 100;
    [Header("是否死亡"), Tooltip("判斷角色是否死亡")]
    public bool isDead;

    public GameObject goScore, goGM;
    public Rigidbody2D r2d;     // 2D 剛體

    private void Update()
    {
        Jump();
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

        r2d.SetRotation(30);                        // 2D 剛體.設定角度(角度)
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
