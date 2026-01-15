using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0O@DBJNBDBM@add_bytes_end?$AA@")]
[DemangledName("\"add_bytes_end\"")]
[CleanName("String")]
internal static partial class String_dmyz8f
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

	unsafe static String_dmyz8f()
	{
		__pointer = unchecked((InlineArray14_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray14_SByte))));
		Value = InlineArrayHelper.Create<InlineArray14_SByte, byte>("add_bytes_end\0"u8);
	}
}
