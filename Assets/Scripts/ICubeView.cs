public interface ICubeView 
{
    int Value { get; set;}
    int Score { get; set;}
    int Health { get; set;}

    void RegisterUpdateValueButtonClickListener(System.Action<int> onClick);
    void RegisterAddScoreButtonClickListener(System.Action<int> onClick);
    void RegisterTakeDamageButtonClickListener(System.Action<int> onClick);    
}