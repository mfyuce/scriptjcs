// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.builder.help;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class DroolsJaxbHelperProvider_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.builder.help.DroolsJaxbHelperProvider_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.builder.help.DroolsJaxbHelperProvider_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __DroolsJaxbHelperProvider extends system.Object implements org.drools.builder.help.DroolsJaxbHelperProvider {
    
    protected __DroolsJaxbHelperProvider(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/io/Resource;Lorg/drools/builder/KnowledgeBuilder;Ljava/lang/Object;Ljava/lang/String;)[Ljava/lang/String;")
    public native java.lang.String[] addXsdModel(org.drools.io.Resource par0, org.drools.builder.KnowledgeBuilder par1, com.sun.tools.xjc.Options par2, java.lang.String par3);
    
    @net.sf.jni4net.attributes.ClrMethod("([Ljava/lang/String;Ljava/util/Map;Lorg/drools/KnowledgeBase;)Ljava/lang/Object;")
    public native javax.xml.bind.JAXBContext newJAXBContext(java.lang.String[] par0, java.util.Map par1, org.drools.KnowledgeBase par2);
}
//</generated-proxy>
