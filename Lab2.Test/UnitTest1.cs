using Lab2.Dictionary;

namespace Lab2.Test;

public class UnitTest1
{
    [Fact]
    public void Dictionary_ShouldBeZeroElement() {
        var dictionary = new dictionary();
        Assert.Equal(dictionary.ListWords().Count, 0);
    }
    
    [Theory]
    [InlineData("new word")]
    [InlineData("new word 2")]
    [InlineData("new word 3")]
    public void AddNewWord_ShouleBeAddANewWord_ReturnTrue(string word) {
        var dictionary = new dictionary();
        //слово не было
        Assert.False(dictionary.checkWord(word));
        if(dictionary.checkWord(word)) dictionary.AddNewWord(word);
        
        Assert.Equal(dictionary.ListWords().Count,1);
    }
    
    [Theory]
    [InlineData("new word")]
    [InlineData("new word 2")]
    [InlineData("new word 3")]
    public void AddNewWord_ShouleBeAddANewWord_ReturnFalse(string word) {
        var dictionary = new dictionary();
        dictionary.AddNewWord(word);
        //слово уже было
        Assert.True(dictionary.checkWord(word));
        dictionary.AddNewWord(word);

        Assert.Equal(dictionary.ListWords().Count,1);
    }
}