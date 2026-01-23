using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0DF@FLAGJPAA@?$FO?$FO?$FOFull?5match?5Len?5?$CFu?5Dist?5?$CFu?0?5Sl@")]
[DemangledName("\"^^^Full match Len %u Dist %u, Sl\"...")]
[CleanName("String")]
internal static partial class String_486qas
{
	[FixedAddressValueType]
	private static InlineArray53_SByte __value;

	public unsafe static InlineArray53_SByte* Pointer => unchecked((InlineArray53_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray53_SByte Value
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

	unsafe static String_486qas()
	{
		Value = InlineArrayHelper.Create<InlineArray53_SByte, byte>("^^^Full match Len %u Dist %u, Slot %u, ExtraBits: %u\0"u8);
		PointerIndices.Register(Pointer);
	}
}
