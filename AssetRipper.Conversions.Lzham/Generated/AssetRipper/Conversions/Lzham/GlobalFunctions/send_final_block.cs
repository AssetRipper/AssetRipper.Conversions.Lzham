using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?send_final_block@lzcompressor@lzham@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl lzham::lzcompressor::send_final_block(void)")]
internal static partial class send_final_block
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		unchecked
		{
			bool flag = start_encoding.Invoke(&((lzham_lzcompressor*)@this)->field_6, 16);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			if (((lzham_lzcompressor*)@this)->field_12 == 0 && !send_configuration.Invoke(@this))
			{
				return false;
			}
			bool flag2 = encode_bits.Invoke(&((lzham_lzcompressor*)@this)->field_6, 3, 2);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			bool flag3 = encode_align_to_byte.Invoke(&((lzham_lzcompressor*)@this)->field_6);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag3)
			{
				return false;
			}
			bool flag4 = encode_bits.Invoke(&((lzham_lzcompressor*)@this)->field_6, ((lzham_lzcompressor*)@this)->field_4, 32);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag4)
			{
				return false;
			}
			bool flag5 = stop_encoding.Invoke(&((lzham_lzcompressor*)@this)->field_6, support_arith: true);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag5)
			{
				return false;
			}
			if (empty.Invoke(&((lzham_lzcompressor*)@this)->field_9))
			{
				swap_ufmqqg.Invoke(&((lzham_lzcompressor*)@this)->field_9, Get_encoding_buf.Invoke(&((lzham_lzcompressor*)@this)->field_6));
			}
			else
			{
				bool flag6 = append_9ee93x.Invoke(&((lzham_lzcompressor*)@this)->field_9, Get_encoding_buf.Invoke(&((lzham_lzcompressor*)@this)->field_6));
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag6)
				{
					return false;
				}
			}
			((lzham_lzcompressor*)@this)->field_12++;
			return true;
		}
	}
}
