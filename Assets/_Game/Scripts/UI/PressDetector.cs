using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class PressDetector : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float timeDelay = .1f;
    public UnityEvent onPressedOverSeconds;

    private void Start() {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        onPressedOverSeconds.Invoke();
        // StartCoroutine(TrackTimePressed());
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerMovement.dirMove = 0;
        // StopAllCoroutines();
    }

    private IEnumerator TrackTimePressed()
    {
        WaitForSeconds delay = new WaitForSeconds(timeDelay);
        while (true)
        {
            yield return delay;
            onPressedOverSeconds.Invoke();
        }
    }

}