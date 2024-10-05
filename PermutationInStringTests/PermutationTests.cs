using FluentAssertions;
using PermutationInString;

namespace PermutationInStringTests
{
    public class PermutationTests
    {
        [Fact]
        public void Test1()
        {
            string s1 = "ab";
            string s2 = "eidbaooo";

            var result = Permutation.CheckInclusion(s1, s2);

            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            string s1 = "ab";
            string s2 = "eidbaooo";

            var result = Permutation.CheckInclusion(s1, s2);

            result.Should().BeFalse();
        }
    }
}