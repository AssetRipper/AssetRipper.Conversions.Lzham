using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_03COAJHJPB@buf?$AA@")]
[DemangledName("\"buf\"")]
[CleanName("String")]
internal static partial class String_xra7zt
{
	public unsafe static InlineArray4_SByte* __pointer;

	public unsafe static InlineArray4_SByte Value
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

	unsafe static String_xra7zt()
	{
		__pointer = unchecked((InlineArray4_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray4_SByte))));
		Value = InlineArrayHelper.Create<InlineArray4_SByte, byte>("buf\0"u8);
	}
}
