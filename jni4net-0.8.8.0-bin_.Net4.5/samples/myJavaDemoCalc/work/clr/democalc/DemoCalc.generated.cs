//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace democalc {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class DemoCalc : global::java.lang.Object, global::democalc.ICalc {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_MySuperSmartFunctionIDontHaveInJava0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorDemoCalc1;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public DemoCalc() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::democalc.DemoCalc.staticClass, global::democalc.DemoCalc.j4n__ctorDemoCalc1, this);
            }
        }
        
        protected DemoCalc(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::democalc.DemoCalc.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::democalc.DemoCalc.staticClass = @__class;
            global::democalc.DemoCalc.j4n_MySuperSmartFunctionIDontHaveInJava0 = @__env.GetMethodID(global::democalc.DemoCalc.staticClass, "MySuperSmartFunctionIDontHaveInJava", "(Ljava/lang/String;)I");
            global::democalc.DemoCalc.j4n__ctorDemoCalc1 = @__env.GetMethodID(global::democalc.DemoCalc.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)I")]
        public virtual int MySuperSmartFunctionIDontHaveInJava(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((int)(@__env.CallIntMethod(this, global::democalc.DemoCalc.j4n_MySuperSmartFunctionIDontHaveInJava0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::democalc.DemoCalc(@__env);
            }
        }
    }
    #endregion
}
