using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BH@CIFPAAMN@?$CB?$CB?$CBRep?5?$CFu?5full?5len?5?$CFu?6?$AA@")]
[DemangledName("\"!!!Rep %u full len %u\\n\"")]
[CleanName("String")]
internal static partial class String_sitzh3
{
	[FixedAddressValueType]
	private static InlineArray23_SByte __value;

	public unsafe static InlineArray23_SByte* Pointer => unchecked((InlineArray23_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray23_SByte Value
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

	unsafe static String_sitzh3()
	{
		Value = InlineArrayHelper.Create<InlineArray23_SByte, byte>("!!!Rep %u full len %u\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
