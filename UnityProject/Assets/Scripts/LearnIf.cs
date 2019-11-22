using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool open;

    public int score;

    private void Start()
    {
        // 判斷式 if
        // if (布林值) { 當布林值為 true 才執行 }

        if (true)
        {
            print("嗨~");
        }

        // 當布林值為 true 才執行 if {}
        if (open)
        {
            print("開門~");
        }
        // 當布林值為 false 才執行 else {}
        else
        {
            print("關門~");
        }

        if (score >= 60)
        {
            print("及格~");
        }
        else if (score >= 40)
        {
            print("補考");
        }
        else
        {
            print("你被當了!");
        }
    }
}
