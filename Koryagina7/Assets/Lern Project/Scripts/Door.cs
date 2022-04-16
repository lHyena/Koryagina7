using UnityEngine;


public class Door : MonoBehaviour
{
    [SerializeField] private Transform _rotatePoint;
    [SerializeField] private Animator _anim;

    private bool _isStopped;
    private readonly int IsOpen = Animator.StringToHash("IsOpen"); // данный код оптимизирует процесс анимации

    private void Awake()
    {
        _anim = GetComponent<Animator>();

    }


    private void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("Player") && !_isStopped)
      {
            _anim.SetBool(IsOpen, true);
          //_rotatePoint.Rotate(Vector3.up, 90);
      }
    }


    private void OnTriggerExit(Collider other)
    {
      if (other.CompareTag("Player") && !_isStopped)
      {
            _anim.SetBool(IsOpen, false);
            //_rotatePoint.Rotate(Vector3.up, -90);
        }

    }    
    private void OnTriggerStay(Collider other)
    {
       if (other.CompareTag("Player"))
       {
         if (Input.GetKeyDown(KeyCode.E))
                _anim.enabled = false; // выключаем аниматор
          //_isStopped = true;
       }

    }
}


    






