using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?reset@lzcompressor@lzham@@QEAA_NXZ")]
[DemangledName("public: bool __cdecl lzham::lzcompressor::reset(void)")]
[CleanName("reset")]
internal static partial class reset_j4w9gw
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		unchecked
		{
			if (((lzham_lzcompressor*)@this)->field_3 < 0L)
			{
				return false;
			}
			reset_zf86ia.Invoke(&((lzham_lzcompressor*)@this)->field_5);
			reset_jag9x3.Invoke(&((lzham_lzcompressor*)@this)->field_6);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			clear_mcufyu.Invoke(&((lzham_lzcompressor*)@this)->field_7);
			((lzham_lzcompressor*)@this)->field_3 = 0L;
			((lzham_lzcompressor*)@this)->field_4 = 1;
			try_resize_m9x9dy.Invoke(&((lzham_lzcompressor*)@this)->field_8, 0, grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			try_resize_m9x9dy.Invoke(&((lzham_lzcompressor*)@this)->field_9, 0, grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			((lzham_lzcompressor*)@this)->field_10 = 0;
			((lzham_lzcompressor*)@this)->field_13 = 0;
			((lzham_lzcompressor*)@this)->field_11 = 0;
			((lzham_lzcompressor*)@this)->field_12 = 0;
			reset_2sucmm.Invoke(&((lzham_lzcompressor*)@this)->field_16);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			((lzham_lzcompressor*)@this)->field_22 = 0;
			((lzham_lzcompressor*)@this)->field_23 = 0;
			if (((lzham_lzcompressor*)@this)->field_1.m_num_seed_bytes != 0)
			{
				bool flag = init_seed_bytes.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					return false;
				}
			}
			bool result = send_zlib_header.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			return result;
		}
	}
}
