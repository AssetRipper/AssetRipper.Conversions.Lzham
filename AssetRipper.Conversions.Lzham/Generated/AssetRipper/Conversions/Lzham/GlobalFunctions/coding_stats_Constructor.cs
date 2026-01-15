using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0coding_stats@lzcompressor@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzcompressor::coding_stats::coding_stats(void)")]
internal static partial class coding_stats_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			tracked_stat_Constructor.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_context_stats);
			tracked_stat_Constructor.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_lit_stats);
			tracked_stat_Constructor.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_delta_lit_stats);
			lzham_lzcompressor_tracked_stat* rep_stats = (lzham_lzcompressor_tracked_stat*)(&((lzham_lzcompressor_coding_stats*)@this)->m_rep_stats);
			lzham_lzcompressor_tracked_stat* ptr = rep_stats + 4L;
			lzham_lzcompressor_tracked_stat* intPtr = rep_stats;
			while (true)
			{
				void* ptr2 = intPtr;
				tracked_stat_Constructor.Invoke(ptr2);
				lzham_lzcompressor_tracked_stat* ptr3 = (lzham_lzcompressor_tracked_stat*)ptr2 + 1;
				if (ptr3 == ptr)
				{
					break;
				}
				intPtr = ptr3;
			}
			tracked_stat_Constructor.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len1_stats);
			tracked_stat_Constructor.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len2_plus_stats);
			lzham_lzcompressor_tracked_stat* full_match_stats = (lzham_lzcompressor_tracked_stat*)(&((lzham_lzcompressor_coding_stats*)@this)->m_full_match_stats);
			lzham_lzcompressor_tracked_stat* ptr4 = full_match_stats + 258L;
			lzham_lzcompressor_tracked_stat* intPtr2 = full_match_stats;
			while (true)
			{
				void* ptr5 = intPtr2;
				tracked_stat_Constructor.Invoke(ptr5);
				lzham_lzcompressor_tracked_stat* ptr6 = (lzham_lzcompressor_tracked_stat*)ptr5 + 1;
				if (ptr6 == ptr4)
				{
					break;
				}
				intPtr2 = ptr6;
			}
			clear_mcufyu.Invoke(@this);
			return @this;
		}
	}
}
