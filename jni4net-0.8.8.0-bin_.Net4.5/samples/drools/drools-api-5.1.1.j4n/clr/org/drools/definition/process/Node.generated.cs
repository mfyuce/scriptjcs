//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.definition.process {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Node {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getName();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        long getId();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Map;")]
        global::java.util.Map getMetaData();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Object;")]
        global::java.lang.Object getMetaData(global::java.lang.String par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/util/List;")]
        global::java.util.List getIncomingConnections(global::java.lang.String par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Map;")]
        global::java.util.Map getIncomingConnections();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/util/List;")]
        global::java.util.List getOutgoingConnections(global::java.lang.String par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Map;")]
        global::java.util.Map getOutgoingConnections();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/drools/definition/process/NodeContainer;")]
        global::org.drools.definition.process.NodeContainer getNodeContainer();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Node_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.definition.process.@__Node.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.definition.process.Node), typeof(global::org.drools.definition.process.Node_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.definition.process.Node), typeof(global::org.drools.definition.process.Node_))]
    internal sealed partial class @__Node : global::java.lang.Object, global::org.drools.definition.process.Node {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getId1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMetaData2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMetaData3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getIncomingConnections4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getIncomingConnections5;
        
        internal static global::net.sf.jni4net.jni.MethodId _getOutgoingConnections6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getOutgoingConnections7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getNodeContainer8;
        
        private @__Node(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.definition.process.@__Node.staticClass = @__class;
            global::org.drools.definition.process.@__Node._getName0 = @__env.GetMethodID(global::org.drools.definition.process.@__Node.staticClass, "getName", "()Ljava/lang/String;");
            global::org.drools.definition.process.@__Node._getId1 = @__env.GetMethodID(global::org.drools.definition.process.@__Node.staticClass, "getId", "()J");
            global::org.drools.definition.process.@__Node._getMetaData2 = @__env.GetMethodID(global::org.drools.definition.process.@__Node.staticClass, "getMetaData", "()Ljava/util/Map;");
            global::org.drools.definition.process.@__Node._getMetaData3 = @__env.GetMethodID(global::org.drools.definition.process.@__Node.staticClass, "getMetaData", "(Ljava/lang/String;)Ljava/lang/Object;");
            global::org.drools.definition.process.@__Node._getIncomingConnections4 = @__env.GetMethodID(global::org.drools.definition.process.@__Node.staticClass, "getIncomingConnections", "(Ljava/lang/String;)Ljava/util/List;");
            global::org.drools.definition.process.@__Node._getIncomingConnections5 = @__env.GetMethodID(global::org.drools.definition.process.@__Node.staticClass, "getIncomingConnections", "()Ljava/util/Map;");
            global::org.drools.definition.process.@__Node._getOutgoingConnections6 = @__env.GetMethodID(global::org.drools.definition.process.@__Node.staticClass, "getOutgoingConnections", "(Ljava/lang/String;)Ljava/util/List;");
            global::org.drools.definition.process.@__Node._getOutgoingConnections7 = @__env.GetMethodID(global::org.drools.definition.process.@__Node.staticClass, "getOutgoingConnections", "()Ljava/util/Map;");
            global::org.drools.definition.process.@__Node._getNodeContainer8 = @__env.GetMethodID(global::org.drools.definition.process.@__Node.staticClass, "getNodeContainer", "()Lorg/drools/definition/process/NodeContainer;");
        }
        
        public global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.process.@__Node._getName0));
            }
        }
        
        public long getId() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((long)(@__env.CallLongMethod(this, global::org.drools.definition.process.@__Node._getId1)));
            }
        }
        
        public global::java.util.Map getMetaData() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.process.@__Node._getMetaData2));
            }
        }
        
        public global::java.lang.Object getMetaData(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.process.@__Node._getMetaData3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        public global::java.util.List getIncomingConnections(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.process.@__Node._getIncomingConnections4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        public global::java.util.Map getIncomingConnections() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.process.@__Node._getIncomingConnections5));
            }
        }
        
        public global::java.util.List getOutgoingConnections(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.process.@__Node._getOutgoingConnections6, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        public global::java.util.Map getOutgoingConnections() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.process.@__Node._getOutgoingConnections7));
            }
        }
        
        public global::org.drools.definition.process.NodeContainer getNodeContainer() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.process.NodeContainer>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.process.@__Node._getNodeContainer8));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Node);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getName", "getName0", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getId", "getId1", "()J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMetaData", "getMetaData2", "()Ljava/util/Map;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMetaData", "getMetaData3", "(Ljava/lang/String;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getIncomingConnections", "getIncomingConnections4", "(Ljava/lang/String;)Ljava/util/List;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getIncomingConnections", "getIncomingConnections5", "()Ljava/util/Map;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getOutgoingConnections", "getOutgoingConnections6", "(Ljava/lang/String;)Ljava/util/List;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getOutgoingConnections", "getOutgoingConnections7", "()Ljava/util/Map;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getNodeContainer", "getNodeContainer8", "()Lorg/drools/definition/process/NodeContainer;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getName0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.process.Node @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.process.Node>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getName());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static long getId1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()J
            // ()J
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            long @__return = default(long);
            try {
            global::org.drools.definition.process.Node @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.process.Node>(@__env, @__obj);
            @__return = ((long)(@__real.getId()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getMetaData2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Map;
            // ()Ljava/util/Map;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.process.Node @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.process.Node>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Map>(@__env, @__real.getMetaData());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getMetaData3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/String;)Ljava/lang/Object;
            // (Ljava/lang/String;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.process.Node @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.process.Node>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, @__real.getMetaData(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getIncomingConnections4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/String;)Ljava/util/List;
            // (Ljava/lang/String;)Ljava/util/List;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.process.Node @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.process.Node>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.List>(@__env, @__real.getIncomingConnections(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getIncomingConnections5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Map;
            // ()Ljava/util/Map;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.process.Node @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.process.Node>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Map>(@__env, @__real.getIncomingConnections());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getOutgoingConnections6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/String;)Ljava/util/List;
            // (Ljava/lang/String;)Ljava/util/List;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.process.Node @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.process.Node>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.List>(@__env, @__real.getOutgoingConnections(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getOutgoingConnections7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Map;
            // ()Ljava/util/Map;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.process.Node @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.process.Node>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Map>(@__env, @__real.getOutgoingConnections());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getNodeContainer8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/definition/process/NodeContainer;
            // ()Lorg/drools/definition/process/NodeContainer;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.process.Node @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.process.Node>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.definition.process.NodeContainer>(@__env, @__real.getNodeContainer());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.definition.process.@__Node(@__env);
            }
        }
    }
    #endregion
}
