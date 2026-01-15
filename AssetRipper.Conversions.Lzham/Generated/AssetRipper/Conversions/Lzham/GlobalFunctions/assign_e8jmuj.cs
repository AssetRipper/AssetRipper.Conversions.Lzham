using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?assign@decoder_tables@prefix_coding@lzham@@QEAA_NAEBV123@@Z")]
[DemangledName("public: bool __cdecl lzham::prefix_coding::decoder_tables::assign(class lzham::prefix_coding::decoder_tables const &)")]
[CleanName("assign")]
internal static partial class assign_e8jmuj
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("class lzham::prefix_coding::decoder_tables const &")] void* rhs)
	{
		if (@this == rhs)
		{
			return true;
		}
		unchecked
		{
			void* lookup = ((lzham_prefix_coding_decoder_tables*)@this)->m_lookup;
			void* sorted_symbol_order = ((lzham_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order;
			llvm_memcpy_p0_p0_i64.Invoke(@this, rhs, 192L, isVolatile: false);
			if (lookup != null && sorted_symbol_order != null && ((lzham_prefix_coding_decoder_tables*)rhs)->m_cur_lookup_size == ((lzham_prefix_coding_decoder_tables*)@this)->m_cur_lookup_size && ((lzham_prefix_coding_decoder_tables*)rhs)->m_cur_sorted_symbol_order_size == ((lzham_prefix_coding_decoder_tables*)@this)->m_cur_sorted_symbol_order_size)
			{
				((lzham_prefix_coding_decoder_tables*)@this)->m_lookup = lookup;
				((lzham_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order = sorted_symbol_order;
				llvm_memcpy_p0_p0_i64.Invoke(((lzham_prefix_coding_decoder_tables*)@this)->m_lookup, ((lzham_prefix_coding_decoder_tables*)rhs)->m_lookup, 4L * (long)(uint)((lzham_prefix_coding_decoder_tables*)@this)->m_cur_lookup_size, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(((lzham_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order, ((lzham_prefix_coding_decoder_tables*)rhs)->m_sorted_symbol_order, 2L * (long)(uint)((lzham_prefix_coding_decoder_tables*)@this)->m_cur_sorted_symbol_order_size, isVolatile: false);
			}
			else
			{
				lzham_delete_array_g5z2nn.Invoke(lookup);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				((lzham_prefix_coding_decoder_tables*)@this)->m_lookup = null;
				if (((lzham_prefix_coding_decoder_tables*)rhs)->m_lookup != null)
				{
					void* lookup2 = lzham_new_array_qrkyp9.Invoke(((lzham_prefix_coding_decoder_tables*)@this)->m_cur_lookup_size);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					((lzham_prefix_coding_decoder_tables*)@this)->m_lookup = lookup2;
					if (((lzham_prefix_coding_decoder_tables*)@this)->m_lookup == null)
					{
						return false;
					}
					llvm_memcpy_p0_p0_i64.Invoke(((lzham_prefix_coding_decoder_tables*)@this)->m_lookup, ((lzham_prefix_coding_decoder_tables*)rhs)->m_lookup, 4L * (long)(uint)((lzham_prefix_coding_decoder_tables*)@this)->m_cur_lookup_size, isVolatile: false);
				}
				lzham_delete_array_i9xite.Invoke(sorted_symbol_order);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				((lzham_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order = null;
				if (((lzham_prefix_coding_decoder_tables*)rhs)->m_sorted_symbol_order != null)
				{
					void* sorted_symbol_order2 = lzham_new_array_sb2tu4.Invoke(((lzham_prefix_coding_decoder_tables*)@this)->m_cur_sorted_symbol_order_size);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					((lzham_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order = sorted_symbol_order2;
					if (((lzham_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order == null)
					{
						return false;
					}
					llvm_memcpy_p0_p0_i64.Invoke(((lzham_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order, ((lzham_prefix_coding_decoder_tables*)rhs)->m_sorted_symbol_order, 2L * (long)(uint)((lzham_prefix_coding_decoder_tables*)@this)->m_cur_sorted_symbol_order_size, isVolatile: false);
				}
			}
			return true;
		}
	}
}
