using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BE@EKDGPGEN@queuing?5parse?5tasks?$AA@")]
[DemangledName("\"queuing parse tasks\"")]
[CleanName("String")]
internal static partial class String_xvmi6j
{
	public unsafe static InlineArray20_SByte* __pointer;

	public unsafe static InlineArray20_SByte Value
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

	unsafe static String_xvmi6j()
	{
		__pointer = unchecked((InlineArray20_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray20_SByte))));
		Value = InlineArrayHelper.Create<InlineArray20_SByte, byte>("queuing parse tasks\0"u8);
	}
}
