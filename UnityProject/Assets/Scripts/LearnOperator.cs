using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 10, b = 3;

    public int c = 20, d = 7;

    public int coin;
    public int gold;

    private void Start()
    {
        #region 數學運算子
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);
        
        // = 指定符號，右邊先運算
        a = a + 1;
        print(a);

        print(a++); // 先輸出 a 在執行遞增
        print(++a); // 先執行遞增在輸出 a

        a = a + 10;
        a += 10;        // += -= *= /= %=
        print(a);
        #endregion

        #region 比較運算子
        print(c > d);       // true     大於
        print(c < d);       // false    小於
        print(c >= d);      // true     大於等於
        print(c <= d);      // false    小於等於
        print(c == d);      // false    等於
        print(c != d);      // true     不等於
        #endregion

        #region 邏輯運算子
        // && 並且 shift + 7
        // 只要有一個 false 結果就是 false
        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);

        // || 或者 shift + \
        // 只要有一個 true 結果就是 true
        print(true || true);    // t
        print(true || false);   // t
        print(false || true);   // t
        print(false || false);  // f

        // 相反 !
        print(!true);

        // 需要 10 個硬幣 或者 5 個金幣
        // true > 過關，false > 還沒過關
        print(coin >= 10 || gold >= 5);
        #endregion
    }
}
