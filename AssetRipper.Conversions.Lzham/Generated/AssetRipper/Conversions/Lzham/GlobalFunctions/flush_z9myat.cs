using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?flush@lzcompressor@lzham@@QEAA_NW4lzham_flush_t@@@Z")]
[DemangledName("public: bool __cdecl lzham::lzcompressor::flush(enum lzham_flush_t)")]
[CleanName("flush")]
internal static partial class flush_z9myat
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("enum lzham_flush_t")] int flush_type)
	{
		unchecked
		{
			if ((((lzham_lzcompressor*)@this)->field_13 & 1) == 1)
			{
				return false;
			}
			sbyte b = 1;
			if (size_s5xcpk.Invoke(&((lzham_lzcompressor*)@this)->field_8) != 0)
			{
				bool flag = compress_block.Invoke(buf_len: size_s5xcpk.Invoke(&((lzham_lzcompressor*)@this)->field_8), @this: @this, pBuf: Get_ptr_cpjzjc.Invoke(&((lzham_lzcompressor*)@this)->field_8));
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				b = (flag ? ((sbyte)1) : ((sbyte)0));
				try_resize_m9x9dy.Invoke(&((lzham_lzcompressor*)@this)->field_8, 0, grow_hint: false);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			if ((b & 1) == 1)
			{
				bool flag2 = send_sync_block.Invoke(@this, flush_type);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				b = (flag2 ? ((sbyte)1) : ((sbyte)0));
				if (3 == flush_type)
				{
					flush_t8im8c.Invoke(&((lzham_lzcompressor*)@this)->field_5);
					reset_2sucmm.Invoke(&((lzham_lzcompressor*)@this)->field_16);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
				}
			}
			lzham_flush_buffered_printf.Invoke();
			return (b & 1) == 1;
		}
	}
}
