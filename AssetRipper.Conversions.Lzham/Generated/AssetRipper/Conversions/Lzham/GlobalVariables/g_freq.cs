using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?g_freq@lzham_timer@lzham@@0_KA")]
[DemangledName("private: static unsigned __int64 lzham::lzham_timer::g_freq")]
internal static partial class g_freq
{
	public unsafe static long* __pointer;

	public unsafe static long Value
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

	unsafe static g_freq()
	{
		__pointer = unchecked((long*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(long))));
		Value = 0L;
	}
}
