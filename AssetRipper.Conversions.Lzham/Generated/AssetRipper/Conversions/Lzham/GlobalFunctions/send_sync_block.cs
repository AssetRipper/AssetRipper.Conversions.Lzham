using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?send_sync_block@lzcompressor@lzham@@AEAA_NW4lzham_flush_t@@@Z")]
[DemangledName("private: bool __cdecl lzham::lzcompressor::send_sync_block(enum lzham_flush_t)")]
internal static partial class send_sync_block
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("enum lzham_flush_t")] int flush_type)
	{
		unchecked
		{
			reset_jag9x3.Invoke(&((lzham_lzcompressor*)@this)->field_6);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			bool flag = start_encoding.Invoke(&((lzham_lzcompressor*)@this)->field_6, 128);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			bool flag2 = encode_bits.Invoke(&((lzham_lzcompressor*)@this)->field_6, 0, 2);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			int bits = 0;
			switch (flush_type)
			{
			case 3:
				bits = 2;
				break;
			case 10:
				bits = 1;
				break;
			case 2:
				bits = 3;
				break;
			case 0:
			case 4:
				bits = 0;
				break;
			}
			bool flag3 = encode_bits.Invoke(&((lzham_lzcompressor*)@this)->field_6, bits, 2);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag3)
			{
				return false;
			}
			bool flag4 = encode_align_to_byte.Invoke(&((lzham_lzcompressor*)@this)->field_6);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag4)
			{
				return false;
			}
			bool flag5 = encode_bits.Invoke(&((lzham_lzcompressor*)@this)->field_6, 0, 16);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag5)
			{
				return false;
			}
			bool flag6 = encode_bits.Invoke(&((lzham_lzcompressor*)@this)->field_6, 65535, 16);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag6)
			{
				return false;
			}
			bool flag7 = stop_encoding.Invoke(&((lzham_lzcompressor*)@this)->field_6, support_arith: true);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag7)
			{
				return false;
			}
			bool flag8 = append_9ee93x.Invoke(&((lzham_lzcompressor*)@this)->field_9, Get_encoding_buf.Invoke(&((lzham_lzcompressor*)@this)->field_6));
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag8)
			{
				return false;
			}
			((lzham_lzcompressor*)@this)->field_12++;
			return true;
		}
	}
}
