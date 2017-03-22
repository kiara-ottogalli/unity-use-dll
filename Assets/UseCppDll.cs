using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System;

public class UseCppDll : MonoBehaviour {

	[DllImport("CppDll")]
	static extern IntPtr TestClass_Create(int n);
	[DllImport("CppDll")]
	static extern int TestClass_getNum(System.IntPtr t);
	[DllImport("CppDll")]
	static extern void TestClass_setNum(System.IntPtr t, int n);

	void Start () {
		Debug.Log ("Trying to use dll");

		System.IntPtr t = TestClass_Create(22);
		Debug.Log(TestClass_getNum(t));
		TestClass_setNum(t, 31);
		Debug.Log(TestClass_getNum(t));

	}

}
