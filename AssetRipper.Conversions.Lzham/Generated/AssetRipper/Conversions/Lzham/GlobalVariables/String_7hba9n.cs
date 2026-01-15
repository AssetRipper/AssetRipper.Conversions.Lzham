using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BC@GGLBIONJ@bit?5?$DN?$DN?5sym?4m_bits?$AA@")]
[DemangledName("\"bit == sym.m_bits\"")]
[CleanName("String")]
internal static partial class String_7hba9n
{
	public unsafe static InlineArray18_SByte* __pointer;

	public unsafe static InlineArray18_SByte Value
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

	unsafe static String_7hba9n()
	{
		__pointer = unchecked((InlineArray18_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray18_SByte))));
		Value = InlineArrayHelper.Create<InlineArray18_SByte, byte>("bit == sym.m_bits\0"u8);
	}
}
