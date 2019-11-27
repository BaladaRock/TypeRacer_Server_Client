using System;
using TypeRacer_Server;
using Xunit;

namespace TypeRacer_Facts
{
    public class TextFacts
    {
        [Fact]
        public void Should_Read_from_File_Random_Paragraph()
        {
            //Given
            var textReader = new ContestText();
            //When
            string text = textReader.GetText();
            //Then
            Assert.NotEmpty(text);
        }
    }
}
