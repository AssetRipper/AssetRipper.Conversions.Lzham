using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0lzham_timer@lzham@@QEAA@_K@Z")]
[DemangledName("public: __cdecl lzham::lzham_timer::lzham_timer(unsigned __int64)")]
[CleanName("lzham_timer_Constructor")]
internal static partial class lzham_timer_Constructor_bpj5rd
{
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned __int64")] long start_ticks)
	{
		if (!NumericHelper.IsUnorderedOrNotEquals(g_inv_freq.Value, 0.0))
		{
			init_ptjsy3.Invoke();
		}
		unchecked
		{
			((lzham_lzham_timer*)@this)->field_0 = start_ticks;
			sbyte* field_ = &((lzham_lzham_timer*)@this)->field_2;
			*field_ = (sbyte)((*field_ & -2) | 1);
			sbyte* field_2 = &((lzham_lzham_timer*)@this)->field_2;
			*field_2 = (sbyte)((*field_2 & -3) | 0);
			return @this;
		}
	}
}
