using Shouldly;

namespace Mnemonic.Tests;

public class MnemonicGeneratorTests
{
    [Fact]
    public void Should_Generate_Two_Words()
    {
        // Given, When
        var result = MnemonicGenerator.Generate();

        // Then
        var parts = result.Split('-');
        parts.Length.ShouldBe(2);
    }

    [Theory]
    [InlineData('_')]
    [InlineData('*')]
    public void Should_Include_Specified_Separator(char separator)
    {
        var result = MnemonicGenerator.Generate(new MnemonicSettings
        {
            Separator = separator,
        });

        var parts = result.Split(separator);
        parts.Length.ShouldBe(2);
    }
}