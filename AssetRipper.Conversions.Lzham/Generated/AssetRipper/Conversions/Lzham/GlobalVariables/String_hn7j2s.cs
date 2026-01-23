using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0L@FNAOCBOG@stream?5end?$AA@")]
[DemangledName("\"stream end\"")]
[CleanName("String")]
internal static partial class String_hn7j2s
{
	[FixedAddressValueType]
	private static InlineArray11_SByte __value;

	public unsafe static InlineArray11_SByte* Pointer => unchecked((InlineArray11_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray11_SByte Value
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

	unsafe static String_hn7j2s()
	{
		Value = InlineArrayHelper.Create<InlineArray11_SByte, byte>("stream end\0"u8);
		PointerIndices.Register(Pointer);
	}
}
