using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CubeView cubeView;

    private void Start()
    {
        CubeModel model = new CubeModel();
        CubePresenter presenter = new CubePresenter(cubeView, model);
    }
}
