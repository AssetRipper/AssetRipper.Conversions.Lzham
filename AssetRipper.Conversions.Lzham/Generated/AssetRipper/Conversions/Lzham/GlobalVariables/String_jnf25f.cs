using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BC@JPMPDMAN@Rep0?5Len1?5stats?3?6?$AA@")]
[DemangledName("\"Rep0 Len1 stats:\\n\"")]
[CleanName("String")]
internal static partial class String_jnf25f
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

	unsafe static String_jnf25f()
	{
		__pointer = unchecked((InlineArray18_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray18_SByte))));
		Value = InlineArrayHelper.Create<InlineArray18_SByte, byte>("Rep0 Len1 stats:\n\0"u8);
	}
}
