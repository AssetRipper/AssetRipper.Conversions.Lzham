using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0lzham_timer@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzham_timer::lzham_timer(void)")]
[CleanName("lzham_timer_Constructor")]
internal static partial class lzham_timer_Constructor_yuikg8
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((lzham_lzham_timer*)@this)->field_0 = 0L;
			((lzham_lzham_timer*)@this)->field_1 = 0L;
			sbyte* field_ = &((lzham_lzham_timer*)@this)->field_2;
			*field_ = (sbyte)((*field_ & -2) | 0);
			sbyte* field_2 = &((lzham_lzham_timer*)@this)->field_2;
			*field_2 = (sbyte)((*field_2 & -3) | 0);
			if (!NumericHelper.IsUnorderedOrNotEquals(g_inv_freq.Value, 0.0))
			{
				init_ptjsy3.Invoke();
			}
			return @this;
		}
	}
}
