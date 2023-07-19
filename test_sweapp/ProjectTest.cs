using sweapp.Models;

namespace test_sweapp
{
    public class ProjectTest

    {
        Project project = new Project();

        [Fact]
        public void TestLinkUrlProperty()
        {
            // Arrange
            project.LinkUrl = "demo";
            var expected = "Link NOT provided!";

            // Act
            var actual = project.LinkUrl;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestImageUrlProperty()
        {
            // Arrange
            project.ImageUrl = "";
            var expected = "Link NOT provided!";

            // Act
            var actual = project.ImageUrl;

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}