using System;using R5T.T0064;


namespace R5T.Larissa.Configuration
{[ServiceDefinitionMarker]
    public interface ISvnExecutableFilePathProvider:IServiceDefinition
    {
        string GetSvnExecutableFilePath();
    }
}
