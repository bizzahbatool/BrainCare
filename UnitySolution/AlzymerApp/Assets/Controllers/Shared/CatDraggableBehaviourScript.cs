using System.Collections;
using System.Diagnostics;
using UnityEngine;
namespace UnityApp
{
    public class CatDraggableBehaviourScript : MonoBehaviour
    {

        float OffsetXAxis;
        float OffsetYAxis;
        Stopwatch stopwatch= new Stopwatch();
        // Use this for initialization
        void Start()
        {
            stopwatch.Start();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void BeginDrag()
        {
            OffsetXAxis = transform.position.x - Input.mousePosition.x;
            OffsetYAxis = transform.position.y - Input.mousePosition.y;
        }

        public void OnDrag()
        {
            transform.position = new Vector3(
                OffsetXAxis + Input.mousePosition.x,
                OffsetYAxis + Input.mousePosition.y
                );
        }
    }
}