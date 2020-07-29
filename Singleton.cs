using UnityEngine;

public class Singleton<T>
    : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }
    public new bool DontDestroyOnLoad;
    public virtual void Awake()
    {
        if (Instance == null)
        {
            Instance = this as T;
            if (transform.root == transform && DontDestroyOnLoad)
                DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.LogError($"Existing instance found when initialising Singleton<{typeof(T).Name}>. Destroying this.", this);
        }
    }
}