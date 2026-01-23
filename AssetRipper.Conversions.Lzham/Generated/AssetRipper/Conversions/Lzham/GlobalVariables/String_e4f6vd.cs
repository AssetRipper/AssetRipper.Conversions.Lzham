using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0CK@CBMIELDM@?$CClzham?3?3vector?5operator?$DN?3?5Out?5of@")]
[DemangledName("\"\\\"lzham::vector operator=: Out of\"...")]
[CleanName("String")]
internal static partial class String_e4f6vd
{
	[FixedAddressValueType]
	private static InlineArray42_SByte __value;

	public unsafe static InlineArray42_SByte* Pointer => unchecked((InlineArray42_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray42_SByte Value
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

	unsafe static String_e4f6vd()
	{
		Value = InlineArrayHelper.Create<InlineArray42_SByte, byte>("\"lzham::vector operator=: Out of memory!\"\0"u8);
		PointerIndices.Register(Pointer);
	}
}
