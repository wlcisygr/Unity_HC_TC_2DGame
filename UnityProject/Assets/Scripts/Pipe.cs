// : 繼承 類別，可以享有繼承類別的成員
public class Pipe : Ground
{
    

    
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 5f);
    }
    private void OnBecameVisible()
    {
        
    }
}



