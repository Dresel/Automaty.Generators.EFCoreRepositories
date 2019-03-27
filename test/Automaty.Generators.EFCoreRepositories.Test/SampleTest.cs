namespace Automaty.Generators.EFCoreRepositories.Test
{
	using System.Collections.Generic;
	using System.IO;
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

			string sourceFilePath = Path.Combine("Repositories", "Host.cs");

			ICollection<string> generatedFilePaths = new[]
			{
				"AlbumRepository.generated.cs", "ArtistGenreRepository.generated.cs",
				"ArtistRepository.generated.cs", "CartItemRepository.generated.cs", "GenreRepository.generated.cs",
				"MusicRepository.generated.cs", "OrderDetailRepository.generated.cs", "OrderRepository.generated.cs"
			};

			Helper.AssertSampleProjectDirectoryPathExists(sampleProjectDirectoryPath);

			foreach (string generatedFilePath in generatedFilePaths)
			{
				Helper.AssertGeneratedFileDoesNotExist(sampleProjectDirectoryPath,
					Path.Combine("Repositories", generatedFilePath));
			}

			Helper.DotNetRestore(sampleProjectDirectoryPath, projectFilePath);
			Helper.AutomatyRun(sampleProjectDirectoryPath, $"{sourceFilePath} --project {projectFilePath}");

			foreach (string generatedFilePath in generatedFilePaths)
			{
				Helper.AssertGeneratedFileExists(sampleProjectDirectoryPath,
					Path.Combine("Repositories", generatedFilePath));
			}
		}
	}
}