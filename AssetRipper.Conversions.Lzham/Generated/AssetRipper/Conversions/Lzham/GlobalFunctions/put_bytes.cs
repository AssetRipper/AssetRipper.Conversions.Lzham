using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?put_bytes@lzcompressor@lzham@@QEAA_NPEBXI@Z")]
[DemangledName("public: bool __cdecl lzham::lzcompressor::put_bytes(void const *, unsigned int)")]
internal static partial class put_bytes
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("void const *")] void* pBuf, [NativeType("unsigned int")] int buf_len)
	{
		unchecked
		{
			if ((((lzham_lzcompressor*)@this)->field_13 & 1) == 1)
			{
				return false;
			}
			sbyte b = 1;
			if (pBuf == null)
			{
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
					bool flag2 = send_final_block.Invoke(@this);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag2)
					{
						b = 0;
					}
				}
				((lzham_lzcompressor*)@this)->field_13 = 1;
			}
			else
			{
				void* ptr = pBuf;
				int num = buf_len;
				while (num != 0)
				{
					int num2 = (((uint)num >= (uint)(((lzham_lzcompressor*)@this)->field_1.m_block_size - size_s5xcpk.Invoke(&((lzham_lzcompressor*)@this)->field_8))) ? (((lzham_lzcompressor*)@this)->field_1.m_block_size - size_s5xcpk.Invoke(&((lzham_lzcompressor*)@this)->field_8)) : num);
					if (num2 == ((lzham_lzcompressor*)@this)->field_1.m_block_size)
					{
						bool flag3 = compress_block.Invoke(@this, ptr, num2);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						b = (flag3 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						bool flag4 = append_tcvg7j.Invoke(&((lzham_lzcompressor*)@this)->field_8, ptr, num2);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag4)
						{
							return false;
						}
						if (size_s5xcpk.Invoke(&((lzham_lzcompressor*)@this)->field_8) == ((lzham_lzcompressor*)@this)->field_1.m_block_size)
						{
							bool flag5 = compress_block.Invoke(buf_len: size_s5xcpk.Invoke(&((lzham_lzcompressor*)@this)->field_8), @this: @this, pBuf: Get_ptr_cpjzjc.Invoke(&((lzham_lzcompressor*)@this)->field_8));
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							b = (flag5 ? ((sbyte)1) : ((sbyte)0));
							try_resize_m9x9dy.Invoke(&((lzham_lzcompressor*)@this)->field_8, 0, grow_hint: false);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
						}
					}
					if ((b & 1) != 1)
					{
						return false;
					}
					ptr = (byte*)ptr + (uint)num2;
					num -= num2;
				}
			}
			lzham_flush_buffered_printf.Invoke();
			return (b & 1) == 1;
		}
	}
}
