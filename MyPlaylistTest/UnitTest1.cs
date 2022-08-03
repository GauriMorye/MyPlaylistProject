global using Xunit;
using MyPlaylistLibrary;

namespace MyPlaylistTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int option;
            Assert.Throws<FormatException>(
                () => option = Convert.ToInt32("c")
                ) ;
        }
        

    }
}