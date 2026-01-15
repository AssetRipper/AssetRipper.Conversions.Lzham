using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BJ@OODKALFN@?9?9?9Regular?5lit?3?5?$CFu?5?8?$CFc?8?6?$AA@")]
[DemangledName("\"---Regular lit: %u \\'%c\\'\\n\"")]
[CleanName("String")]
internal static partial class String_fadq34
{
	public unsafe static InlineArray25_SByte* __pointer;

	public unsafe static InlineArray25_SByte Value
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

	unsafe static String_fadq34()
	{
		__pointer = unchecked((InlineArray25_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray25_SByte))));
		Value = InlineArrayHelper.Create<InlineArray25_SByte, byte>("---Regular lit: %u '%c'\n\0"u8);
	}
}
