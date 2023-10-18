using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.F0077
{
	[FunctionalityMarker]
	public partial interface IPublishOperator : IFunctionalityMarker
	{
		/// <summary>
		/// Publishes a project file to an output directory.
		/// This method will use the MSBuild publish operation if any recursive COM references are detected for the project.
		/// Otherwise the dotnet publish operation will be used.
		/// </summary>
		public async Task Publish(
			string projectFilePath,
			string outputDirectoryPath)
        {
			var hasAnyRecursiveCOMReferences = await Instances.ProjectReferencesOperator.HasAnyRecursiveCOMReferences(projectFilePath);
			if (hasAnyRecursiveCOMReferences)
			{
				// Need to use MSBuild.
				Instances.MSBuildPublishOperator.Publish_Synchronous(
					projectFilePath,
					outputDirectoryPath);
			}
			else
			{
				// Use dotnet.
				Instances.DotnetPublishOperator.Publish(
					projectFilePath,
					outputDirectoryPath);
			}
		}
	}
}