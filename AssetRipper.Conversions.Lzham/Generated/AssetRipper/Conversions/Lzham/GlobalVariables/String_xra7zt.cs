using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_03COAJHJPB@buf?$AA@")]
[DemangledName("\"buf\"")]
[CleanName("String")]
internal static partial class String_xra7zt
{
	[FixedAddressValueType]
	private static InlineArray4_SByte __value;

	public unsafe static InlineArray4_SByte* Pointer => unchecked((InlineArray4_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray4_SByte Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static String_xra7zt()
	{
		Value = InlineArrayHelper.Create<InlineArray4_SByte, byte>("buf\0"u8);
		PointerIndices.Register(Pointer);
	}
}
