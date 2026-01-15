using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0DF@FLAGJPAA@?$FO?$FO?$FOFull?5match?5Len?5?$CFu?5Dist?5?$CFu?0?5Sl@")]
[DemangledName("\"^^^Full match Len %u Dist %u, Sl\"...")]
[CleanName("String")]
internal static partial class String_486qas
{
	public unsafe static InlineArray53_SByte* __pointer;

	public unsafe static InlineArray53_SByte Value
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

	unsafe static String_486qas()
	{
		__pointer = unchecked((InlineArray53_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray53_SByte))));
		Value = InlineArrayHelper.Create<InlineArray53_SByte, byte>("^^^Full match Len %u Dist %u, Slot %u, ExtraBits: %u\0"u8);
	}
}
