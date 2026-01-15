using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0L@FNAOCBOG@stream?5end?$AA@")]
[DemangledName("\"stream end\"")]
[CleanName("String")]
internal static partial class String_hn7j2s
{
	public unsafe static InlineArray11_SByte* __pointer;

	public unsafe static InlineArray11_SByte Value
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

	unsafe static String_hn7j2s()
	{
		__pointer = unchecked((InlineArray11_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray11_SByte))));
		Value = InlineArrayHelper.Create<InlineArray11_SByte, byte>("stream end\0"u8);
	}
}
