using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
    public void IrParaCenaComecar()
    {
        SceneManager.LoadScene("Começar");
    }
}

