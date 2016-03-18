package com.scriptjcs.firstsample;

import net.sf.jni4net.Bridge;

import java.io.IOException;

import static scriptcs.embedded.ExecutionManager.*;

public class Main {

    public static void main(String[] args) {
        // create bridge, with default setup
        // it will lookup jni4net.n.dll next to jni4net.j.jar
        Bridge.setVerbose(true);
        Bridge.setDebug(true);

        try {
            Bridge.init();
        } catch (IOException e) {
            e.printStackTrace();
        }
        try {
            Bridge.LoadAndRegisterAssemblyFrom(new java.io.File("ScriptCs.Embedded.Binaries\\ScriptCs.Embedded.j4n.dll"));
            Bridge.LoadAndRegisterAssemblyFrom(new java.io.File("ScriptCs.Embedded.Binaries\\ScriptCs.Embedded.dll"));
        } catch (Exception e) {
            e.printStackTrace();
        }

        // here you go!
        //Console.WriteLine("Hello .NET world!\n");
        //System.loadLibrary("ScriptCs.Embedded");

        InitRuntime();

        System.out.println("Result of 1+2 =" + ExecuteText("1+2"));

        DestroyRuntime();

    }
}
