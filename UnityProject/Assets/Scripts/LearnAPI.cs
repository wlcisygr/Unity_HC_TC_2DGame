using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("一般!");
        Debug.LogWarning("警告!");
        Debug.LogError("錯誤!");

        Debug.Log(Mathf.PI);

        // 靜態屬性 static properties
        Debug.Log(Random.value);
        // 靜態方法 static method 
        Debug.Log(Random.Range(1, 10));
    }
}
