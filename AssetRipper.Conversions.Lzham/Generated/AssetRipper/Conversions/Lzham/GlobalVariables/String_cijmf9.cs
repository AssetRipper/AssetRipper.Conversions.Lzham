using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0EO@EKBIAOLA@Match?5?$CFu?3?5Total?3?5?$CFu?0?5Cost?3?5?$CFf?5?$CI?$CF@")]
[DemangledName("\"Match %u: Total: %u, Cost: %f (%\"...")]
[CleanName("String")]
internal static partial class String_cijmf9
{
	public unsafe static InlineArray78_SByte* __pointer;

	public unsafe static InlineArray78_SByte Value
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

	unsafe static String_cijmf9()
	{
		__pointer = unchecked((InlineArray78_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray78_SByte))));
		Value = InlineArrayHelper.Create<InlineArray78_SByte, byte>("Match %u: Total: %u, Cost: %f (%f bytes), Ave: %f StdDev: %f Min: %f Max: %f\n\0"u8);
	}
}
