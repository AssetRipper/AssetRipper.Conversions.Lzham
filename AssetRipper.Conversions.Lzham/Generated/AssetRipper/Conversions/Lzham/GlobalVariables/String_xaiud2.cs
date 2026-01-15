using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_00CNPNBAHC@?$AA@")]
[DemangledName("\"\"")]
[CleanName("String")]
internal static partial class String_xaiud2
{
	public unsafe static InlineArray1_SByte* __pointer;

	public unsafe static InlineArray1_SByte Value
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

	unsafe static String_xaiud2()
	{
		__pointer = unchecked((InlineArray1_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray1_SByte))));
		Value = default(InlineArray1_SByte);
	}
}
