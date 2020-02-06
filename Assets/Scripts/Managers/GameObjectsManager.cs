using GameObjects.Ball;
using GameObjects.Field;
using GameObjects.Racket;
using UnityEngine;

namespace Managers
{
    public class GameObjectsManager : MonoBehaviour
    {
        public Transform GameObjectsContainerPrefab;
        public FieldView FieldViewPrefab;
        public RacketView RacketViewPrefab;
        public BallView BallViewPrefab;

        private Transform _gameObjectsContainerInstance;
        private FieldView _fieldViewInstance;
        private RacketView _topRacketViewInstance;
        private RacketView _bottomRacketViewInstance;
        private BallView _ballViewInstance;

        public void Initialize()
        {
            _gameObjectsContainerInstance = Instantiate(GameObjectsContainerPrefab);

            _fieldViewInstance = Instantiate(FieldViewPrefab, _gameObjectsContainerInstance.gameObject.transform);

            _topRacketViewInstance = Instantiate(RacketViewPrefab, _fieldViewInstance.gameObject.transform);
            _topRacketViewInstance.gameObject.transform.position = new Vector3(0, 4.5f, 0);
            _bottomRacketViewInstance = Instantiate(RacketViewPrefab, _fieldViewInstance.gameObject.transform);
            _bottomRacketViewInstance.gameObject.transform.position = new Vector3(0, -4.5f, 0);

            _ballViewInstance = Instantiate(BallViewPrefab, _fieldViewInstance.gameObject.transform);
        }
    }
}
