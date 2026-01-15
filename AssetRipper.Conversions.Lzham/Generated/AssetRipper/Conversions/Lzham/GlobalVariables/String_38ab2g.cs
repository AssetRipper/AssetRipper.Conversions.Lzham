using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0O@BNNCBLEN@out?5of?5memory?$AA@")]
[DemangledName("\"out of memory\"")]
[CleanName("String")]
internal static partial class String_38ab2g
{
	public unsafe static InlineArray14_SByte* __pointer;

	public unsafe static InlineArray14_SByte Value
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

	unsafe static String_38ab2g()
	{
		__pointer = unchecked((InlineArray14_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray14_SByte))));
		Value = InlineArrayHelper.Create<InlineArray14_SByte, byte>("out of memory\0"u8);
	}
}
