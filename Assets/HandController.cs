using UnityEngine;

namespace DefaultNamespace
{
    
    public class HandController : MonoBehaviour
    {
        [SerializeField] private StarsController _starsController;
        [SerializeField] private Animals _animals;

        public void StarDelete()
        {
            _starsController.ChangeFillAmount(0);
        }

        public void StartPig()
        {
            _animals.Pig.SetTrigger("Start");
        }
        
        
    }
}