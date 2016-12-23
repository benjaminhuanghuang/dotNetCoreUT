using System;
using Xunit;

using Library;

namespace CharacterCounterTests
{
    public class GetCountForLetter
    {
        [Fact]
        public void should_return_a_count_of_1_if_there_is_a_single_letter_to_parse() 
        {
            CharacterCounter counter = new CharacterCounter();
            counter.ParseString("a");

            Assert.Equal(2, counter.GetCountForLetter('a'));
        }
    }
}
