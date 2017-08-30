using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using UnitTestingDemoPart1.Services.Contracts;

namespace UnitTestingDemoPart1.Tests
{
    [TestClass]
    public class FileServiceTests
    {

        [TestMethod]
        public void ReadFile_WhenPathIsGiven_ReturnsNoneEmptyText()
        {
            //Arrange
            IFileService _fileService = MockRepository.GenerateMock<IFileService>();
            _fileService.Path = "drive:/somefolder/anotherfolder/somefile.text";
            _fileService.Expect(x => x.FileExists()).Return(true);
            _fileService.Expect(x => x.ReadFile()).Return("Welcome to unit testing!");

            //Act
            var text = _fileService.ReadFile();
            
            //Assert            
            Assert.IsFalse(String.IsNullOrEmpty(text), "Successful file read must return a none empty string.");
        }
    }
}
