//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.builder.conf {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class ClassLoaderCacheOption : global::java.lang.Object, global::org.drools.builder.conf.SingleValueKnowledgeBuilderOption, global::org.drools.conf.SingleValueKnowledgeBaseOption {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getPropertyName0;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf1;
        
        internal static global::net.sf.jni4net.jni.MethodId _values2;
        
        internal static global::net.sf.jni4net.jni.MethodId _isClassLoaderCacheEnabled3;
        
        internal static global::net.sf.jni4net.jni.FieldId _ENABLED4;
        
        internal static global::net.sf.jni4net.jni.FieldId _DISABLED5;
        
        internal static global::net.sf.jni4net.jni.FieldId _PROPERTY_NAME6;
        
        protected ClassLoaderCacheOption(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lorg/drools/builder/conf/ClassLoaderCacheOption;")]
        public static global::org.drools.builder.conf.ClassLoaderCacheOption ENABLED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::org.drools.builder.conf.ClassLoaderCacheOption>(@__env, @__env.GetStaticObjectFieldPtr(global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass, global::org.drools.builder.conf.ClassLoaderCacheOption._ENABLED4));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lorg/drools/builder/conf/ClassLoaderCacheOption;")]
        public static global::org.drools.builder.conf.ClassLoaderCacheOption DISABLED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::org.drools.builder.conf.ClassLoaderCacheOption>(@__env, @__env.GetStaticObjectFieldPtr(global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass, global::org.drools.builder.conf.ClassLoaderCacheOption._DISABLED5));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/String;")]
        public static global::java.lang.String PROPERTY_NAME {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.GetStaticObjectFieldPtr(global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass, global::org.drools.builder.conf.ClassLoaderCacheOption._PROPERTY_NAME6));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass = @__class;
            global::org.drools.builder.conf.ClassLoaderCacheOption._getPropertyName0 = @__env.GetMethodID(global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass, "getPropertyName", "()Ljava/lang/String;");
            global::org.drools.builder.conf.ClassLoaderCacheOption._valueOf1 = @__env.GetStaticMethodID(global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass, "valueOf", "(Ljava/lang/String;)Lorg/drools/builder/conf/ClassLoaderCacheOption;");
            global::org.drools.builder.conf.ClassLoaderCacheOption._values2 = @__env.GetStaticMethodID(global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass, "values", "()[Lorg/drools/builder/conf/ClassLoaderCacheOption;");
            global::org.drools.builder.conf.ClassLoaderCacheOption._isClassLoaderCacheEnabled3 = @__env.GetMethodID(global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass, "isClassLoaderCacheEnabled", "()Z");
            global::org.drools.builder.conf.ClassLoaderCacheOption._ENABLED4 = @__env.GetStaticFieldID(global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass, "ENABLED", "Lorg/drools/builder/conf/ClassLoaderCacheOption;");
            global::org.drools.builder.conf.ClassLoaderCacheOption._DISABLED5 = @__env.GetStaticFieldID(global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass, "DISABLED", "Lorg/drools/builder/conf/ClassLoaderCacheOption;");
            global::org.drools.builder.conf.ClassLoaderCacheOption._PROPERTY_NAME6 = @__env.GetStaticFieldID(global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass, "PROPERTY_NAME", "Ljava/lang/String;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getPropertyName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.conf.ClassLoaderCacheOption._getPropertyName0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Lorg/drools/builder/conf/ClassLoaderCacheOption;")]
        public static global::org.drools.builder.conf.ClassLoaderCacheOption valueOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::org.drools.builder.conf.ClassLoaderCacheOption>(@__env, @__env.CallStaticObjectMethodPtr(global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass, global::org.drools.builder.conf.ClassLoaderCacheOption._valueOf1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Lorg/drools/builder/conf/ClassLoaderCacheOption;")]
        public static org.drools.builder.conf.ClassLoaderCacheOption[] values() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<org.drools.builder.conf.ClassLoaderCacheOption[], global::org.drools.builder.conf.ClassLoaderCacheOption>(@__env, @__env.CallStaticObjectMethodPtr(global::org.drools.builder.conf.ClassLoaderCacheOption.staticClass, global::org.drools.builder.conf.ClassLoaderCacheOption._values2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isClassLoaderCacheEnabled() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.builder.conf.ClassLoaderCacheOption._isClassLoaderCacheEnabled3)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.builder.conf.ClassLoaderCacheOption(@__env);
            }
        }
    }
    #endregion
}
