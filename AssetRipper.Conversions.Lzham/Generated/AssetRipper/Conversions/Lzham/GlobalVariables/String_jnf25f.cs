using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BC@JPMPDMAN@Rep0?5Len1?5stats?3?6?$AA@")]
[DemangledName("\"Rep0 Len1 stats:\\n\"")]
[CleanName("String")]
internal static partial class String_jnf25f
{
	[FixedAddressValueType]
	private static InlineArray18_SByte __value;

	public unsafe static InlineArray18_SByte* Pointer => unchecked((InlineArray18_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray18_SByte Value
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

	unsafe static String_jnf25f()
	{
		Value = InlineArrayHelper.Create<InlineArray18_SByte, byte>("Rep0 Len1 stats:\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
