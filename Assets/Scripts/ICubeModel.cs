public interface ICubeModel
{
    int Value { get; }
    int Score { get; }
    int Health { get; }

    void SetValue(int value);
    void AddScore(int amount);
    void TakeDamage(int amount);
}
