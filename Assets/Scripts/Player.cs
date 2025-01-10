using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _plantCountUI.UpdateSeeds(5, 0);
    }

    private void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        input = Vector3.Normalize(input);
        _playerTransform.Translate(input * _speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && _numSeeds > 0)
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        GameObject instantiatedPlant = Instantiate(_plantPrefab);
        instantiatedPlant.transform.position = transform.position;
        _numSeeds--;
        _plantCountUI.UpdateSeeds(_numSeeds, 5 - _numSeeds);
    }
}
