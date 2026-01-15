using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0O@PMPMJFCA@stop_encoding?$AA@")]
[DemangledName("\"stop_encoding\"")]
[CleanName("String")]
internal static partial class String_siua9a
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

	unsafe static String_siua9a()
	{
		__pointer = unchecked((InlineArray14_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray14_SByte))));
		Value = InlineArrayHelper.Create<InlineArray14_SByte, byte>("stop_encoding\0"u8);
	}
}
