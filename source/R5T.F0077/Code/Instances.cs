using System;

using R5T.F0016.F001;
using R5T.F0027;
using R5T.F0076;


namespace R5T.F0077
{
    public static class Instances
    {
        public static IDotnetPublishOperator DotnetPublishOperator { get; } = F0027.DotnetPublishOperator.Instance;
        public static IMSBuildPublishOperator MSBuildPublishOperator { get; } = F0076.MSBuildPublishOperator.Instance;
        public static IProjectReferencesOperator ProjectReferencesOperator { get; } = F0016.F001.ProjectReferencesOperator.Instance;
    }
}