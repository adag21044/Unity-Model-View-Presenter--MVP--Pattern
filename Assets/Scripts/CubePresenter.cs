public class CubePresenter
{
    private readonly ICubeView _view;
    private readonly CubeModel _model;

    public CubePresenter(ICubeView view, CubeModel model)
    {
        _view = view;
        _model = model;

        _view.RegisterUpdateValueButtonClickListener(OnUpdateValueButtonClick);
        _view.RegisterAddScoreButtonClickListener(OnAddScoreButtonClick);
        _view.RegisterTakeDamageButtonClickListener(OnTakeDamageButtonClick);

        UpdateView();
    }

    private void OnUpdateValueButtonClick(int value)
    {
        _model.SetValue(value);
        UpdateView();
    }

    private void OnAddScoreButtonClick(int score)
    {
        _model.AddScore(score);
        UpdateView();
    }

    private void OnTakeDamageButtonClick(int damage)
    {
        _model.TakeDamage(damage);
        UpdateView();
    }

    private void UpdateView()
    {
        _view.Value = _model.Value;
        _view.Score = _model.Score;
        _view.Health = _model.Health;
    }
}
