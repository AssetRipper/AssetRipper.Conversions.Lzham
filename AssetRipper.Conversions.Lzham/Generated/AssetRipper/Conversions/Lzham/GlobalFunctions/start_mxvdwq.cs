using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?start@lzham_timer@lzham@@QEAAX_K@Z")]
[DemangledName("public: void __cdecl lzham::lzham_timer::start(unsigned __int64)")]
[CleanName("start")]
internal static partial class start_mxvdwq
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned __int64")] long start_ticks)
	{
		unchecked
		{
			((lzham_lzham_timer*)@this)->field_0 = start_ticks;
			sbyte* field_ = &((lzham_lzham_timer*)@this)->field_2;
			*field_ = (sbyte)((*field_ & -2) | 1);
			sbyte* field_2 = &((lzham_lzham_timer*)@this)->field_2;
			*field_2 = (sbyte)((*field_2 & -3) | 0);
		}
	}
}
