using UnityEngine;
using UnityEngine.UI;

public class SafeAreaTest : MonoBehaviour
{
    [SerializeField]
    private Text safeAreaLabel;

    private void Update()
    {
        safeAreaLabel.text = "Safe area rect: " + Screen.safeArea;
    }
}
