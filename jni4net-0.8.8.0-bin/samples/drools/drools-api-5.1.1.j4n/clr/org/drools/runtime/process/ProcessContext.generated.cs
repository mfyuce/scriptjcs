//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.runtime.process {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface ProcessContext : global::org.drools.runtime.KnowledgeContext {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/drools/runtime/process/ProcessInstance;")]
        global::org.drools.runtime.process.ProcessInstance getProcessInstance();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Object;")]
        global::java.lang.Object getVariable(global::java.lang.String par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/drools/runtime/process/NodeInstance;")]
        global::org.drools.runtime.process.NodeInstance getNodeInstance();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Object;)V")]
        void setVariable(global::java.lang.String par0, global::java.lang.Object par1);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class ProcessContext_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.runtime.process.@__ProcessContext.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.runtime.process.ProcessContext), typeof(global::org.drools.runtime.process.ProcessContext_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.runtime.process.ProcessContext), typeof(global::org.drools.runtime.process.ProcessContext_))]
    internal sealed partial class @__ProcessContext : global::java.lang.Object, global::org.drools.runtime.process.ProcessContext {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getKnowledgeRuntime0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProcessInstance1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getVariable2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getNodeInstance3;
        
        internal static global::net.sf.jni4net.jni.MethodId _setVariable4;
        
        private @__ProcessContext(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.runtime.process.@__ProcessContext.staticClass = @__class;
            global::org.drools.runtime.process.@__ProcessContext._getKnowledgeRuntime0 = @__env.GetMethodID(global::org.drools.runtime.process.@__ProcessContext.staticClass, "getKnowledgeRuntime", "()Lorg/drools/runtime/KnowledgeRuntime;");
            global::org.drools.runtime.process.@__ProcessContext._getProcessInstance1 = @__env.GetMethodID(global::org.drools.runtime.process.@__ProcessContext.staticClass, "getProcessInstance", "()Lorg/drools/runtime/process/ProcessInstance;");
            global::org.drools.runtime.process.@__ProcessContext._getVariable2 = @__env.GetMethodID(global::org.drools.runtime.process.@__ProcessContext.staticClass, "getVariable", "(Ljava/lang/String;)Ljava/lang/Object;");
            global::org.drools.runtime.process.@__ProcessContext._getNodeInstance3 = @__env.GetMethodID(global::org.drools.runtime.process.@__ProcessContext.staticClass, "getNodeInstance", "()Lorg/drools/runtime/process/NodeInstance;");
            global::org.drools.runtime.process.@__ProcessContext._setVariable4 = @__env.GetMethodID(global::org.drools.runtime.process.@__ProcessContext.staticClass, "setVariable", "(Ljava/lang/String;Ljava/lang/Object;)V");
        }
        
        public global::org.drools.runtime.KnowledgeRuntime getKnowledgeRuntime() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.KnowledgeRuntime>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.process.@__ProcessContext._getKnowledgeRuntime0));
            }
        }
        
        public global::org.drools.runtime.process.ProcessInstance getProcessInstance() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.ProcessInstance>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.process.@__ProcessContext._getProcessInstance1));
            }
        }
        
        public global::java.lang.Object getVariable(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.process.@__ProcessContext._getVariable2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        public global::org.drools.runtime.process.NodeInstance getNodeInstance() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.NodeInstance>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.process.@__ProcessContext._getNodeInstance3));
            }
        }
        
        public void setVariable(global::java.lang.String par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.process.@__ProcessContext._setVariable4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ProcessContext);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getKnowledgeRuntime", "getKnowledgeRuntime0", "()Lorg/drools/runtime/KnowledgeRuntime;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getProcessInstance", "getProcessInstance1", "()Lorg/drools/runtime/process/ProcessInstance;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getVariable", "getVariable2", "(Ljava/lang/String;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getNodeInstance", "getNodeInstance3", "()Lorg/drools/runtime/process/NodeInstance;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setVariable", "setVariable4", "(Ljava/lang/String;Ljava/lang/Object;)V"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getKnowledgeRuntime0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/runtime/KnowledgeRuntime;
            // ()Lorg/drools/runtime/KnowledgeRuntime;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.process.ProcessContext @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.ProcessContext>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.KnowledgeRuntime>(@__env, ((global::org.drools.runtime.KnowledgeContext)(@__real)).getKnowledgeRuntime());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getProcessInstance1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/runtime/process/ProcessInstance;
            // ()Lorg/drools/runtime/process/ProcessInstance;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.process.ProcessContext @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.ProcessContext>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.process.ProcessInstance>(@__env, @__real.getProcessInstance());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getVariable2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/String;)Ljava/lang/Object;
            // (Ljava/lang/String;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.process.ProcessContext @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.ProcessContext>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, @__real.getVariable(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getNodeInstance3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/runtime/process/NodeInstance;
            // ()Lorg/drools/runtime/process/NodeInstance;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.process.ProcessContext @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.ProcessContext>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.process.NodeInstance>(@__env, @__real.getNodeInstance());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void setVariable4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Ljava/lang/String;Ljava/lang/Object;)V
            // (Ljava/lang/String;Ljava/lang/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.process.ProcessContext @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.ProcessContext>(@__env, @__obj);
            @__real.setVariable(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.runtime.process.@__ProcessContext(@__env);
            }
        }
    }
    #endregion
}
