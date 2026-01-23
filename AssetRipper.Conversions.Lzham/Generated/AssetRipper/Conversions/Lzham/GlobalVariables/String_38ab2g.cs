using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0O@BNNCBLEN@out?5of?5memory?$AA@")]
[DemangledName("\"out of memory\"")]
[CleanName("String")]
internal static partial class String_38ab2g
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

	unsafe static String_38ab2g()
	{
		Value = InlineArrayHelper.Create<InlineArray14_SByte, byte>("out of memory\0"u8);
		PointerIndices.Register(Pointer);
	}
}
