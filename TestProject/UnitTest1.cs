using Length;
using Xunit;
namespace TestProject

{
    public class LengthHelperTest
    {
        [Fact]
        public void shouldReturnStringLengthAs0()
        {   
          
            LengthHelper lp = new LengthHelper();
            string data = "";

            int len = lp.findLength(data);

            Assert.Equal(0, len);
        }
        [Fact]
        public void shouldReturnStringLengthAs12()
        {
            string data = "123456789010";

            LengthHelper lh = new LengthHelper();
            int len = lh.findLength(data);

            Assert.Equal(12, len);
        }
        [Fact]
        public void testNullString()
        {
            LengthHelper lh1 = new LengthHelper();
            string testString = null;
            var error = Assert.Throws<ArgumentException>(() => lh1.findLength(testString));
            Assert.Equal("string cannot be null", error.Message);
        }
    }
}