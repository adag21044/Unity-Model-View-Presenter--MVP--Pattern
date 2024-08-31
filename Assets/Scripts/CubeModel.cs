using UnityEngine;

public class CubeModel 
{
    public int Value { get; private set; }
    public int Score { get; private set; }
    public int Health { get; private set; }

    public CubeModel()
    {
        Value = 0;
        Score = 0;
        Health = 100;
    }

    public void SetValue(int value) => Value = value;

    public void AddScore(int amount) => Score += amount;
     
    public void TakeDamage(int amount) => Health = Mathf.Max(Health - amount, 0);

    

}
