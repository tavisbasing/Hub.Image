using System;
using Xunit;
using Moq;
using Hub.Image.Generator;

namespace Hub.Image.Generator.Tests
{ 
    public class GenerateTests
    {
        private readonly IGenerate _generate;

        public GenerateTests(Generate generate)
        {
            _generate = generate;
        }

        [Fact]
        public void ReturnDefaultValueIfNull()
        {
            var result = _generate.Get(null, null, null, null, null, null);
            Assert.Equal("https://placehold.jp/150x150.png", result);
        }

        [Fact]
        public void ReturnDefaultValueIfEmpty()
        {
            var result = _generate.Get("", "", "", "", "", "");
            Assert.Equal("https://placehold.jp/150x150.png", result);
        }
    }
}
