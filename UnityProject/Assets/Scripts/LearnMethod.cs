using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    // 宣告方法 - 定義方法 Method
    // 修飾詞 傳回類型 方法名稱 () { 陳述式、演算法 }
    // private 只有此類別能使用此方法
    // public 

    // 自訂方法：不會執行，需要呼叫

    // void 無傳回
    private void Test()
    {
        print("測試方法!");
    }

    // 有傳回方法
    // 傳回類型可以是：int、float、string 或 bool
    private int Ten()
    {
        return 10;  // 傳回方法一定要有關鍵字 return 並且傳回相同類型資料
    }

    private string Hi()
    {
        return "嗨~";
    }


    private void Start()
    {
        // 呼叫方法
        Test();

        // 使用區域欄位存放有傳回整數的整數
        int a = Ten();
        print("有傳回方法：" + a);

        // 也可以將有傳回整數的方法當作整數使用
        print("有傳回方法：" + Ten());

        print("有傳回字串方法：" + Hi());
    }
}
