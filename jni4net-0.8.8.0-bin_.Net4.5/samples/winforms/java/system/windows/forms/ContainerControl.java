// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system.windows.forms;

@net.sf.jni4net.attributes.ClrType
public class ContainerControl extends system.windows.forms.ScrollableControl {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected ContainerControl(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("()V")
    public ContainerControl() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.windows.forms.ContainerControl.__ctorContainerControl0(this);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    private native static void __ctorContainerControl0(net.sf.jni4net.inj.IClrProxy thiz);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Windows/Forms/Control;")
    public native system.windows.forms.Control getActiveControl();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Windows/Forms/Control;)V")
    public native void setActiveControl(system.windows.forms.Control value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Windows/Forms/Control;)Z")
    public native boolean ActivateControl(system.windows.forms.Control active);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Drawing/SizeF;")
    public native system.drawing.SizeF getAutoScaleDimensions();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Drawing/SizeF;)V")
    public native void setAutoScaleDimensions(system.drawing.SizeF value);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Windows/Forms/AutoScaleMode;")
    public native system.windows.forms.AutoScaleMode getAutoScaleMode();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Windows/Forms/AutoScaleMode;)V")
    public native void setAutoScaleMode(system.windows.forms.AutoScaleMode value);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Windows/Forms/AutoValidate;")
    public native system.Enum getAutoValidate();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Windows/Forms/AutoValidate;)V")
    public native void setAutoValidate(system.Enum value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/EventHandler;)V")
    public native void addAutoValidateChanged(system.EventHandler value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/EventHandler;)V")
    public native void removeAutoValidateChanged(system.EventHandler value);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Drawing/SizeF;")
    public native system.drawing.SizeF getCurrentAutoScaleDimensions();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Windows/Forms/Form;")
    public native system.windows.forms.Form getParentForm();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void PerformAutoScale();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean Validate();
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)Z")
    public native boolean Validate(boolean checkAutoValidate);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean ValidateChildren();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Windows/Forms/ValidationConstraints;)Z")
    public native boolean ValidateChildren(system.Enum validationConstraints);
    
    public static system.Type typeof() {
        return system.windows.forms.ContainerControl.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.windows.forms.ContainerControl.staticType = staticType;
    }
    //</generated-proxy>
}
