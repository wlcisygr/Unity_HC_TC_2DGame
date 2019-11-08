using UnityEngine;      // 引用 Unity API

// 類別 類別名稱
public class First : MonoBehaviour
{
    // 程式內容
    // 宣告變數 - 定義欄位 Field
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // 私人 - 隱藏 private (預設)
    // 公開 - 顯示 public
    [Header("金幣")]
    [Range(0, 99999)]
    public int coin = 999;                  // 整數 - 0
    [Header("速度"), Range(0.1f, 99.5f)]
    public float speed = 1.5f;              // 浮點數 - 0
    [Tooltip("這是喝了不會補血的藥水")]
    public string prop = "紅色藥水";        // 字串 - ""
    public bool dead = true;                // 布林值 - false

    // 事件：在特定時間點已指定次數執行
    // 開始：遊戲播放時執行一次
    private void Start()
    {
        // 輸出("訊息");
        print("哈囉，沃德~");
    }
}
