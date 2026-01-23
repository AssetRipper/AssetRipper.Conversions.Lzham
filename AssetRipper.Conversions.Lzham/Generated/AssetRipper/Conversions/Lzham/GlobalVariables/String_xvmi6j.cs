using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BE@EKDGPGEN@queuing?5parse?5tasks?$AA@")]
[DemangledName("\"queuing parse tasks\"")]
[CleanName("String")]
internal static partial class String_xvmi6j
{
	[FixedAddressValueType]
	private static InlineArray20_SByte __value;

	public unsafe static InlineArray20_SByte* Pointer => unchecked((InlineArray20_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray20_SByte Value
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

	unsafe static String_xvmi6j()
	{
		Value = InlineArrayHelper.Create<InlineArray20_SByte, byte>("queuing parse tasks\0"u8);
		PointerIndices.Register(Pointer);
	}
}
