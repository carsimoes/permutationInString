using FluentAssertions;
using PermutationInString;

namespace PermutationInString_Tests
{
    public class PermutationTests
    {
        [Fact]
        public void Test1()
        {
            string s1 = "ab";
            string s2 = "eidbaooo";

            var result = Permutation.CheckInclusionMethod1(s1, s2);

            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            string s1 = "ab";
            string s2 = "eidboaoo";

            var result = Permutation.CheckInclusionMethod1(s1, s2);

            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            string s1 = "test";
            string s2 = "ttew";

            var result = Permutation.CheckInclusionMethod1(s1, s2);

            result.Should().BeTrue();
        }

    }
}