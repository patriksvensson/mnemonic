namespace Mnemonic;

public sealed class MnemonicSettings
{
    internal static MnemonicSettings Default { get; } = new();

    public char Separator { get; init; } = '-';
}