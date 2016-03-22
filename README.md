# scriptjsc
Power of scriptcs in a Java VM.

This project is a proof of concept that C# can be run from within a JVM.

Currently there is no variable passing from JVM side, or vice versa. The C# code runs from within CLR, so both JVM and .Net must be installed.

## What is being used


[scriptcs](https://github.com/mfyuce/scriptcs)

[jni4net](https://github.com/jni4net/jni4net)


## How to Install

cd --PATH_TO_SCRIPTJCS_HOME--\ScriptCs.Embedded.Binaries

"--PATH_TO_JNI4NET_HOME--\bin\proxygen.exe" "ScriptCs.Embedded.dll" -cp  "ScriptCs.Contracts.dll" "ScriptCs.Core.dll" "ScriptCs.Embedded.dll" "ScriptCs.Engine.Common.dll" "ScriptCs.Engine.Mono.dll" "ScriptCs.Engine.Roslyn.dll" "ScriptCs.Hosting.dll" "System.Collections.Immutable.dll" "System.Reflection.Metadata.dll" "WebDriver.dll" "WebDriver.Support.dll" "Autofac.dll" "Autofac.Integration.Mef.dll" "Common.Logging.dll" "Common.Logging.Core.dll" "FluentAutomation.Core.dll" "FluentAutomation.SeleniumWebDriver.dll" "ICSharpCode.NRefactory.dll" "ICSharpCode.NRefactory.CSharp.dll" "Microsoft.CodeAnalysis.dll" "Microsoft.CodeAnalysis.CSharp.dll" "Microsoft.CodeAnalysis.Desktop.dll" "Microsoft.CodeAnalysis.Scripting.dll" "Microsoft.CodeAnalysis.Scripting.CSharp.dll" "Microsoft.Web.XmlTransform.dll" "Mono.Cecil.dll" "Mono.CSharp.dll" "Newtonsoft.Json.dll" "NuGet.Core.dll" "PowerArgs.dll" -dp  "ScriptCs.Contracts.dll" "ScriptCs.Core.dll" "ScriptCs.Embedded.dll" "ScriptCs.Engine.Common.dll" "ScriptCs.Engine.Mono.dll" "ScriptCs.Engine.Roslyn.dll" "ScriptCs.Hosting.dll" "System.Collections.Immutable.dll" "System.Reflection.Metadata.dll" "WebDriver.dll" "WebDriver.Support.dll" "Autofac.dll" "Autofac.Integration.Mef.dll" "Common.Logging.dll" "Common.Logging.Core.dll" "FluentAutomation.Core.dll" "FluentAutomation.SeleniumWebDriver.dll" "ICSharpCode.NRefactory.dll" "ICSharpCode.NRefactory.CSharp.dll" "Microsoft.CodeAnalysis.dll" "Microsoft.CodeAnalysis.CSharp.dll" "Microsoft.CodeAnalysis.Desktop.dll" "Microsoft.CodeAnalysis.Scripting.dll" "Microsoft.CodeAnalysis.Scripting.CSharp.dll" "Microsoft.Web.XmlTransform.dll" "Mono.Cecil.dll" "Mono.CSharp.dll" "Newtonsoft.Json.dll" "NuGet.Core.dll" "PowerArgs.dll"

http://stackoverflow.com/a/36031226/1290868
