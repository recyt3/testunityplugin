using UnityEngine;
using System.Collections;
using System;

public class helloworldPlugin : MonoBehaviour {

    public static String getHelloWorld_Static()
	{
#if UNITY_ANDROID
		AndroidJavaClass plugin = new AndroidJavaClass("plugin.unity.helloworld");
        String hello = plugin.CallStatic<String>("getHelloWorld_Static");
        return hello;
#endif
		return "";
    }
 
    public static String getHelloWorld()
    {
#if UNITY_ANDROID
		AndroidJavaObject plugin = new AndroidJavaObject("plugin.unity.helloworld");
        String hello = plugin.Call<String>("getHelloWorld");
        return hello;
#endif
		return "";
    }
}
