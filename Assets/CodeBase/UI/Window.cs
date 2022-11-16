using UnityEngine;

namespace CodeBase.UI
{
    public class Window : MonoBehaviour
    {
        public void Close() => 
            gameObject.SetActive(false);

        public void Open() =>
            gameObject.SetActive(true);
    }
}