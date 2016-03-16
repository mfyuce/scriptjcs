@echo off
if not exist target mkdir target
if not exist target\classes mkdir target\classes


echo compile classes
javac -nowarn -d target\classes -sourcepath jvm -cp "C:\TFS2\plugs\jnifornet\jni4net-0.8.8.0-bin\samples\myJavaDemoCalc\work\myJavaDemoCalc.jar";"c:\tfs2\plugs\jnifornet\jni4net-0.8.8.0-bin\lib\jni4net.j-0.8.8.0.jar"; "jvm\democalc\ICalc_.java" "jvm\democalc\DemoCalc_.java" 
IF %ERRORLEVEL% NEQ 0 goto end


echo myJavaDemoCalc.j4n.jar 
jar cvf myJavaDemoCalc.j4n.jar  -C target\classes "democalc\ICalc_.class"  -C target\classes "democalc\__ICalc.class"  -C target\classes "democalc\DemoCalc_.class"  > nul 
IF %ERRORLEVEL% NEQ 0 goto end


echo myJavaDemoCalc.j4n.dll 
csc /nologo /warn:0 /t:library /out:myJavaDemoCalc.j4n.dll /recurse:clr\*.cs  /reference:"C:\TFS2\plugs\jnifornet\jni4net-0.8.8.0-bin\lib\jni4net.n-0.8.8.0.dll"
IF %ERRORLEVEL% NEQ 0 goto end


:end
