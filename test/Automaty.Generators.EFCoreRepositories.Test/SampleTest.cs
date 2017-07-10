namespace Automaty.Generators.EFCoreRepositories.Test
{
	using System.Collections.Generic;
	using Automaty.Core;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class SampleTest
	{
		protected const string ProjectDirectoryPath = "./samples/Automaty.Generators.EFCoreRepositories.Sample/";

		protected const string ProjectFilePath = "Automaty.Generators.EFCoreRepositories.Sample.csproj";

		[TestMethod]
		public void AutomatyGeneratorsEFCoreRepositoriesGenerateFiles()
		{
			string sampleProjectDirectoryPath = SampleTest.ProjectDirectoryPath.ToPlatformSpecificPath();
			string projectFilePath = SampleTest.ProjectFilePath;

			string sourceFilePath = "Repositories.cs";

			ICollection<string> generatedFilePaths = new[]
			{
				"Repositories.Album.generated.cs", "Repositories.Artist.generated.cs", "Repositories.CartItem.generated.cs",
				"Repositories.Genre.generated.cs", "Repositories.Music.generated.cs", "Repositories.Order.generated.cs",
				"Repositories.OrderDetail.generated.cs"
			};

			Helper.AssertSampleProjectDirectoryPathExists(sampleProjectDirectoryPath);

			foreach (string generatedFilePath in generatedFilePaths)
			{
				Helper.AssertGeneratedFileDoesNotExist(sampleProjectDirectoryPath, generatedFilePath);
			}

			Helper.DotNetRestore(sampleProjectDirectoryPath, projectFilePath);
			Helper.AutomatyRun(sampleProjectDirectoryPath, $"{sourceFilePath} --project {projectFilePath}");

			foreach (string generatedFilePath in generatedFilePaths)
			{
				Helper.AssertGeneratedFileExists(sampleProjectDirectoryPath, generatedFilePath);
			}
		}
	}
}