using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    // 宣告方法 - 定義方法 Method
    // 修飾詞 傳回類型 方法名稱 () { 陳述式、演算法 }
    // private 只有此類別能使用此方法
    // public 
    // void 無傳回
    // 自訂方法：不會執行，需要呼叫

    private void Test()
    {
        print("測試方法!");
    }

    private void Start()
    {
        // 呼叫方法
        Test();
    }
}
