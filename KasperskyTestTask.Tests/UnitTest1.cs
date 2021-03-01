using Xunit;
using System.IO;
using System;

namespace KasperskyTestTask.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CantParseTest()
        {
            FileProcessor fileProcessor = new FileProcessor();

            IFileSource fileSource = new XMLSource();

            Assert.False(fileSource.CanProcess("disk:\\folder\\file"));
        }

        [Fact]
        public void OkayXMLTest()
        {
            FileProcessor fileProcessor = new FileProcessor();

            IFileSource fileSource = new XMLSource();

            Assert.True(fileSource.CanProcess("disk:\\folder\\file.xml"));
        }

        [Fact]
        public void BadXMLTest()
        {
            FileProcessor fileProcessor = new FileProcessor();

            IFileSource fileSource = new XMLSource();

            Assert.False(fileSource.CanProcess("disk:\\folder\\file.html"));
        }

        [Fact]
        public void OkayJSONTest()
        {
            FileProcessor fileProcessor = new FileProcessor();

            IFileSource fileSource = new JSONSource();

            Assert.True(fileSource.CanProcess("disk:\\folder\\file.json"));
        }

        [Fact]
        public void BadJSONTest()
        {
            FileProcessor fileProcessor = new FileProcessor();

            IFileSource fileSource = new JSONSource();

            Assert.False(fileSource.CanProcess("disk:\\folder\\file.xml"));
        }
    }
}
