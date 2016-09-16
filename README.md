# Log4Any
Custom Portable logger that uses log4net.

## Bugs ##
 * methods Trace and Verbose doesn't work
     * They doesn't work due to fact a portable app doesn't contain mscorlib. 
     * Missing mscorlib causes that, Type.DeclaringType will throw InvalidOperationException.
    
