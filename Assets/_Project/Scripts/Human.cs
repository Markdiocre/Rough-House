using UnityEngine;

public class Human : Throwable, IThrowable
{
    public void ActivatePower()
    {
        
    }

    public void Throw()
    {

    }
    
    public void OnMouseDown()
    {
        GameManager.Instance.MakeCurrent(this);
    }
}
