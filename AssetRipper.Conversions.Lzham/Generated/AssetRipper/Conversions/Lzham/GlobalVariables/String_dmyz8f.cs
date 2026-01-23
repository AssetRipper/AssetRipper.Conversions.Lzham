using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0O@DBJNBDBM@add_bytes_end?$AA@")]
[DemangledName("\"add_bytes_end\"")]
[CleanName("String")]
internal static partial class String_dmyz8f
{
	[FixedAddressValueType]
	private static InlineArray14_SByte __value;

	public unsafe static InlineArray14_SByte* Pointer => unchecked((InlineArray14_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray14_SByte Value
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

	unsafe static String_dmyz8f()
	{
		Value = InlineArrayHelper.Create<InlineArray14_SByte, byte>("add_bytes_end\0"u8);
		PointerIndices.Register(Pointer);
	}
}
