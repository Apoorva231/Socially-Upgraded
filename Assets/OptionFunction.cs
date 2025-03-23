using UnityEngine;

namespace Button{
    public class OptionFunction : MonoBehaviour
{
    public string option;
    public void Pressed(){
        FindObjectOfType<GameManager>().OptionPressed(option);
    }
}
}

