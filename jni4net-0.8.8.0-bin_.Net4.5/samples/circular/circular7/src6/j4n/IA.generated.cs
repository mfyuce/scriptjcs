//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace j4n {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface IA {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void m1();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class IA_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::j4n.@__IA.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::j4n.IA), typeof(global::j4n.IA_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::j4n.IA), typeof(global::j4n.IA_))]
    internal sealed partial class @__IA : global::java.lang.Object, global::j4n.IA {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_m10;
        
        private @__IA(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::j4n.@__IA.staticClass = @__class;
            global::j4n.@__IA.j4n_m10 = @__env.GetMethodID(global::j4n.@__IA.staticClass, "m1", "()V");
        }
        
        public void m1() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::j4n.@__IA.j4n_m10);
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IA);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "m1", "m10", "()V"));
            return methods;
        }
        
        private static void m10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::j4n.IA @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::j4n.IA>(@__env, @__obj);
            @__real.m1();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::j4n.@__IA(@__env);
            }
        }
    }
    #endregion
}
