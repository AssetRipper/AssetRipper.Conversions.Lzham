using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0CK@CBMIELDM@?$CClzham?3?3vector?5operator?$DN?3?5Out?5of@")]
[DemangledName("\"\\\"lzham::vector operator=: Out of\"...")]
[CleanName("String")]
internal static partial class String_e4f6vd
{
	public unsafe static InlineArray42_SByte* __pointer;

	public unsafe static InlineArray42_SByte Value
	{
		get
		{
			return *__pointer;
		}
		set
		{
			*__pointer = value;
		}
	}

	unsafe static String_e4f6vd()
	{
		__pointer = unchecked((InlineArray42_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray42_SByte))));
		Value = InlineArrayHelper.Create<InlineArray42_SByte, byte>("\"lzham::vector operator=: Out of memory!\"\0"u8);
	}
}
