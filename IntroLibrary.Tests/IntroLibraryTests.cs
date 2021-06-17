using System;
using Xunit;

namespace IntroLibrary.Tests
{
    public class IntroLibraryTests
    {
        [Fact]
        public void PersonModel_GetFullName_ExpectedResults()
        {

            var person = new PersonModel();
            person.FirstName = "Ray";
            person.LastName = "Ventoso";

            //Act
            var sut = person.BuildFullName();
            
            //Assert
            Assert.Equal("Ray Ventoso", sut);
        }
    }
}
