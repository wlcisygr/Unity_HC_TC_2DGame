using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int score;
    [Header("最佳分數")]
    public int scoreHeight;
    [Header("水管群組")]
    public GameObject pipe; // GameObject 可以存場景上的物件也可以存專案內的預製物

    /// <summary>
    /// 加分
    /// </summary>
    /// <param name="add">要添加的分數，預設為 1</param>
    private void AddScore(int add = 1)
    {

    }

    /// <summary>
    /// 設定最佳分數。
    /// </summary>
    private void SetHeightScore()
    {

    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    private void GameOver()
    {

    }

    /// <summary>
    /// 生成水管的方法。
    /// </summary>
    private void SpawnPipe()
    {
        // 實例化 - 生成 (物件)
        Object.Instantiate(pipe);
    }

    private void Start()
    {
        SpawnPipe();
        SpawnPipe();
    }
}
